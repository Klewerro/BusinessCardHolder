using BusinessCardHolder.Actions;
using BusinessCardHolder.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessCardHolder.Forms.Forms
{
    public partial class PersonForm : Form
    {
        private PersonActions personActions;
        private Person personInCurrentForm;

        public PersonForm()
        {
            InitializeComponent();
            personActions = new PersonActions();
        }

        public PersonForm(Person person) :this()
        {
            personInCurrentForm = person;
            
        }

        private void PersonForm_Load(object sender, EventArgs e)
        {
            this.Text = personInCurrentForm.Forename + " " + personInCurrentForm.Name;

            LoadData();
        }

        private void button_EmployeeEdit_Click(object sender, EventArgs e)
        {
            int currentId = personInCurrentForm.PersonId;

            

            Person person = new Person()
            {
                Name = textBox_EmployeeName.Text,
                Forename = textBox_EmployeeForename.Text,
                Phone = textBox_EmployeePhone.Text,
                CellPhone = textBox_EmployeeCellPhone.Text,
                Email = textBox_EmployeeEmail.Text,
                BithDate = birthDatePicker.Value
            };

            try
            {
                personActions.UpdatePerson(currentId, person);
                personInCurrentForm = person;
            }
            catch (Exception ex)
            {
                ex.StackTrace.ToString();
            }
        }

        private void button_EmployeeRemove_Click(object sender, EventArgs e)
        {
            int currentId = personInCurrentForm.PersonId;
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
            ActiveForm.Close();
        }

        private void LoadData()
        {
            label_Forename.Text = personInCurrentForm.Forename + " " + personInCurrentForm.Name;
            label_Phone.Text = personInCurrentForm.Phone;
            label_CellPhone.Text = personInCurrentForm.CellPhone;
            label_BirthDate.Text = personInCurrentForm.BithDate.ToShortDateString();
            label_EmployedIn.Text = personInCurrentForm.FirmName;

            textBox_EmployeeForename.Text = personInCurrentForm.Forename;
            textBox_EmployeeName.Text = personInCurrentForm.Name;
            textBox_EmployeePhone.Text = personInCurrentForm.Phone;
            textBox_EmployeeCellPhone.Text = personInCurrentForm.CellPhone;
            textBox_EmployeeEmail.Text = personInCurrentForm.Email;
            birthDatePicker.Value = personInCurrentForm.BithDate;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_EmployeeForename.Text = null;
            textBox_EmployeeName.Text = null;
            textBox_EmployeePhone.Text = null;
            textBox_EmployeeCellPhone.Text = null;
            textBox_EmployeeEmail.Text = null;
            birthDatePicker.Value = new DateTime(1980, 1, 1);
        }
    }
}
