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
using static BusinessCardHolder.Forms.Forms.FirmsForm;

namespace BusinessCardHolder.Forms.Forms.Firm
{
    public partial class AddFirmForm : Form
    {
        private object f2_FormClosed;

        public AddFirmForm()
        {
            InitializeComponent();
            
        }

        private void AddFirmForm_Load(object sender, EventArgs e)
        {
            
        }

        public void button_Add_Click(object sender, EventArgs e)
        {

            try
            {
                Actions.FirmActions firm = new Actions.FirmActions();
                
                firm.CreateFirm(textBox_Name.Text.ToString(), textBox_City.Text.ToString(), textBox_Street.Text.ToString(), int.Parse(textBox_Number.Text), textBox_Zip.Text.ToString());
                
                ActiveForm.Close();

            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    MessageBox.Show("Mising fields.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if(ex is DbEntityValidationException)
                {
                    MessageBox.Show("Wrong ZIP code format", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_Zip.BackColor = Color.Tomato;
                }
                if (ex is FormatException && ex is DbEntityValidationException)
                {
                    MessageBox.Show("Missing fields.\nWrong ZIP code format\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_Zip.BackColor = Color.Tomato;
                }
            }
            //ActiveMdiChild.Close();

        }




        public void button_Cancel_Click(object sender, EventArgs e)
        {
            //ActiveForm.Close();
            ActiveMdiChild.Close();
        }

        private void AddFirmForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        

        
    }
}
