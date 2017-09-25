using System;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Windows.Forms;
using BusinessCardHolder.Actions;
using System.ComponentModel.DataAnnotations;

namespace BusinessCardHolder.Forms.Forms
{
    public partial class FirmForm : Form
    {
        private Actions.FirmActions firmActions;
        private Entities.Firm firmInCurrentForm;
        private Entities.Person employee;
        private PersonActions personActions;
        private FirmPersonActions firmAndPersonActions;

        public FirmForm()
        {
            InitializeComponent();
            firmActions = new FirmActions();
            personActions = new PersonActions();
            firmAndPersonActions = new FirmPersonActions();
        }

        public FirmForm(Entities.Firm firmProp) : this()
        {
            //firm = new Entities.Firm();
            firmInCurrentForm = firmProp;
            AssertFirmDataToTextboxes(firmProp);
        }

        private void FirmForm_Load(object sender, EventArgs e)
        {
            TextBoxesAreReadOnly(true);
            DownloadEmployees();
            DownloadDefaultEmployee();
            this.Text = "Firm: " + firmInCurrentForm.Name;
        }
        //-----------------------------------------------------------
        //FIRM STUFF
        //-----------------------------------------------------------

        private void AssertFirmDataToTextboxes(Entities.Firm firmProp)
        {
            ActiveForm.Text = firmProp.Name;
            textBox_FirmName.Text = firmProp.Name.ToString();
            textBox_FirmCity.Text = firmProp.City.ToString();
            textBox_FirmStreet.Text = firmProp.Street.ToString();
            textBox_FirmNumber.Text = firmProp.Number.ToString();
            textBox_FirmZip.Text = firmProp.Zip.ToString();
            
        }

        private Entities.Firm SaveDataFromTextboxes()
        {
            var firmToSave = new Entities.Firm()
            {
                FirmId = firmInCurrentForm.FirmId,
                Name = textBox_FirmName.Text,
                City = textBox_FirmCity.Text,
                Street = textBox_FirmStreet.Text,
                Number = int.Parse(textBox_FirmNumber.Text),
                Zip = textBox_FirmZip.Text
            };
            return firmToSave;
        }

        private void button_AddEmployee_Click(object sender, EventArgs e)
        {
            
        }

        private void button_FirmEdit_Click(object sender, EventArgs e)
        {
            button_FirmEdit.Visible = false;
            button_FirmSaveChanges.Visible = true;
            button_FirmCancel.Visible = true;
            TextBoxesAreReadOnly(false);
        }

        private void button_FirmSaveEdit_Click(object sender, EventArgs e)
        {
            TextBoxesAreReadOnly(false);
            try
            {
                if (textBox_FirmName.Text == "" || textBox_FirmCity.Text == "" || textBox_FirmStreet.Text == "" || textBox_FirmNumber.Text == null || textBox_FirmZip.Text == "")
                {
                    MessageBox.Show("Mising fields.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AssertFirmDataToTextboxes(firmInCurrentForm);
                } 
                else
                {
                    Entities.Firm firmToSave = new Entities.Firm()
                    {
                        FirmId = firmInCurrentForm.FirmId,
                        Name = textBox_FirmName.Text,
                        City = textBox_FirmCity.Text,
                        Street = textBox_FirmStreet.Text,
                        Number = int.Parse(textBox_FirmNumber.Text),
                        Zip = textBox_FirmZip.Text
                    };

                    firmActions.UpdateFirm(firmToSave);
                    MessageBox.Show("Changes saved.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button_FirmSaveChanges.Visible = false;
                    button_FirmCancel.Visible = false;
                    button_FirmEdit.Visible = true;
                    TextBoxesAreReadOnly(true);
                } 
            }
            catch (Exception ex)
            {
                if (ex is DbEntityValidationException)
                {
                    MessageBox.Show("Wrong ZIP code format", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_FirmZip.BackColor = Color.Tomato;
                }
                if (ex is FormatException && ex is DbEntityValidationException)
                {
                    MessageBox.Show("Missing fields.\nWrong ZIP code format\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_FirmZip.BackColor = Color.Tomato;
                }
            }
            
            
        }

        private void TextBoxesAreReadOnly(bool prop)
        {
            textBox_FirmName.ReadOnly = prop;
            textBox_FirmCity.ReadOnly = prop;
            textBox_FirmStreet.ReadOnly = prop;
            textBox_FirmNumber.ReadOnly = prop;
            textBox_FirmZip.ReadOnly = prop;
        }

        private void button_FirmCancel_Click(object sender, EventArgs e)
        {
            button_FirmSaveChanges.Visible = false;
            button_FirmCancel.Visible = false;
            button_FirmEdit.Visible = true;
            TextBoxesAreReadOnly(true);
        }

        private void button_EmployeeAdd_Click(object sender, EventArgs e)
        {
            Entities.Person person= new Entities.Person();
            person.Name = textBoxEmployeeName.Text;
            person.Forename = textBox_EmployeeForename.Text;
            person.Phone = textBox_EmployeePhone.Text;
            person.CellPhone = textBox_EmployeeCellPhone.Text;
            person.Email = textBox_EmployeeEmail.Text;
            person.BithDate = birthDatePicker.Value;

            try
            {
                personActions.CreatePersonAndAddToFirm(person, firmInCurrentForm.FirmId);
                
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (ex is DbEntityValidationException)
                {
                    MessageBox.Show("Mising fields or wrong data type.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (new EmailAddressAttribute().IsValid(textBox_EmployeeEmail.Text) == false)
                        textBox_EmployeeEmail.BackColor = Color.Tomato;
                }
            }

        }





        //-----------------------------------------------------------
        //EMPLOYEE STUFF
        //-----------------------------------------------------------

        private void DownloadEmployees()
        {
            try
            {
                var employeesList = personActions.ReadPersonsForFirm(firmInCurrentForm);
                dataGridView_EmployeesTable.DataSource = employeesList;
            }
            catch(NullReferenceException ex)
            {
                //MessageBox.Show("Firm" + firmInCurrentForm.Name + "have not any employees.\n" + ex.Message, "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace.ToString());
            }
        }


        private int GetPerosnIdFromTable(int columnIndex)
        {
            int result = 0;

            try
            {
                int rowindex = dataGridView_EmployeesTable.CurrentCell.RowIndex;
                result = int.Parse(dataGridView_EmployeesTable.Rows[rowindex].Cells[columnIndex].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return result;
        }

        private int GetPersonIdFromTable()
        {
            int result = 0;

            try
            {
                int rowindex = dataGridView_EmployeesTable.CurrentCell.RowIndex;
                result = int.Parse(dataGridView_EmployeesTable.Rows[rowindex].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return result;
        }

        private void DownloadDefaultEmployee()
        {
            if(personActions.ReadPersonsForFirm(firmInCurrentForm).Count != 0)
            {
                int id = int.Parse(dataGridView_EmployeesTable.Rows[0].Cells[0].Value.ToString());

                Entities.Person person = personActions.ReadPerson(id);

                textBoxEmployeeName.Text = person.Name;
                textBox_EmployeeForename.Text = person.Forename;
                textBox_EmployeePhone.Text = person.Phone;
                textBox_EmployeeCellPhone.Text = person.CellPhone;
                textBox_EmployeeEmail.Text = person.Email;
                birthDatePicker.Value = person.BithDate;
            }
        }


        //-----------------------------------------------------------
        //Events
        //-----------------------------------------------------------

        private void button_EmployeeRemove_Click(object sender, EventArgs e)
        {
            int currentId = GetPersonIdFromTable();
            var person = personActions.ReadPerson(currentId);

            DialogResult messageBox = MessageBox.Show(String.Format("Are you sure you want remove person {0} {1} (id: {2})?", person.Forename, person.Name, person.PersonId), "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (messageBox == DialogResult.Yes)
            {
                try
                {
                    personActions.DeletePerson(currentId);
                    MessageBox.Show(String.Format("{0} {1} (id: {2}) was deleted.", person.Forename, person.Name, person.PersonId), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    ex.StackTrace.ToString();
                }
            }
        }



        private void dataGridView_EmployeesTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int currentId = GetPersonIdFromTable();
            Entities.Person person = personActions.ReadPerson(currentId);

            textBoxEmployeeName.Text = person.Name;
            textBox_EmployeeForename.Text = person.Forename;
            textBox_EmployeePhone.Text = person.Phone;
            textBox_EmployeeCellPhone.Text = person.CellPhone;
            textBox_EmployeeEmail.Text = person.Email;
            birthDatePicker.Value = person.BithDate;

            tabControl_Firm.SelectedIndex = 1;
        }


        private void button_EmployeeEdit_Click(object sender, EventArgs e)
        {
            int currentId = GetPersonIdFromTable();
            Entities.Person person = new Entities.Person()
            {          
                Name = textBoxEmployeeName.Text,
                Forename = textBox_EmployeeForename.Text,
                Phone = textBox_EmployeePhone.Text,
                CellPhone = textBox_EmployeeCellPhone.Text,
                Email = textBox_EmployeeEmail.Text,
                BithDate = birthDatePicker.Value
            };
            
            try
            {
                personActions.UpdatePerson(currentId, person);
            }catch(Exception ex)
            {
                ex.StackTrace.ToString();
            }
            
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBoxEmployeeName.Text = null;
            textBox_EmployeeForename.Text = null;
            textBox_EmployeePhone.Text = null;
            textBox_EmployeeCellPhone.Text = null;
            textBox_EmployeeEmail.Text = null;
            birthDatePicker.Value = new DateTime(1980, 1, 1);
        }







        //-----------------------------------------------------------
        //Context menu strip actions
        //-----------------------------------------------------------
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DownloadEmployees();
        }

        
    }
}
