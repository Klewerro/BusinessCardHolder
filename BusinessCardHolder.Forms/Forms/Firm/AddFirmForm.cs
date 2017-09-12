using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessCardHolder.Forms.Forms.Firm
{
    public partial class AddFirmForm : Form
    {
        public AddFirmForm()
        {
            InitializeComponent();
        }

        private void AddFirmForm_Load(object sender, EventArgs e)

        {
            
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                Actions.Firm firm = new Actions.Firm();
                firm.Add(textBox_Name.Text.ToString(), textBox_City.Text.ToString(), textBox_Street.Text.ToString(), int.Parse(textBox_Number.Text), textBox_Zip.Text.ToString());
            } catch(FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActiveForm.Show();
            } 

                ActiveForm.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

    }
}
