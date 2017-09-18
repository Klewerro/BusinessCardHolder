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
    public partial class FirmForm : Form
    {
        private int firmId;

        public FirmForm()
        {
            InitializeComponent();
        }

        public FirmForm(Entities.Firm firmProp) : this()
        {
            AssertDataToTextboxes(firmProp);
            
        }

        private void FirmForm_Load(object sender, EventArgs e)
        {

        }

        private void AssertDataToTextboxes(Entities.Firm firmProp)
        {
            ActiveForm.Text = firmProp.Name;
            textBox_FirmName.Text = firmProp.Name.ToString();
            textBox_FirmCity.Text = firmProp.City.ToString();
            textBox_FirmStreet.Text = firmProp.Street.ToString();
            textBox_FirmNumber.Text = firmProp.Number.ToString();
            textBox_FirmZip.Text = firmProp.Zip.ToString();
            firmId = int.Parse(firmProp.FirmId.ToString());
        }

        private void button_AddEmployee_Click(object sender, EventArgs e)
        {

        }
    }
}
