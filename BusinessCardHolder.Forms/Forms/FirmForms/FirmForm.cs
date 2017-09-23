using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessCardHolder.Actions;

namespace BusinessCardHolder.Forms.Forms
{
    public partial class FirmForm : Form
    {
        private Actions.FirmActions firmActions;
        private Entities.Firm firm;
        private Entities.Person employee;
        private PersonActions personActions;

        public FirmForm()
        {
            InitializeComponent();
            firmActions = new Actions.FirmActions();
        }

        public FirmForm(Entities.Firm firmProp) : this()
        {
            //firm = new Entities.Firm();
            firm = firmProp;
            AssertFirmDataToTextboxes(firmProp);
        }

        private void FirmForm_Load(object sender, EventArgs e)
        {
            TextBoxesAreReadOnly(true);
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
                FirmId = firm.FirmId,
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
                    AssertFirmDataToTextboxes(firm);
                } 
                else
                {
                    Entities.Firm firmToSave = new Entities.Firm()
                    {
                        FirmId = firm.FirmId,
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

        }





        //-----------------------------------------------------------
        //EMPLOYEE STUFF
        //-----------------------------------------------------------



    }
}
