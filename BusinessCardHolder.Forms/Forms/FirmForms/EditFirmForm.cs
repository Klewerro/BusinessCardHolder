using System.Windows.Forms;

namespace BusinessCardHolder.Forms.Forms.Firm
{
    public partial class EditFirmForm : Form
    {
        Entities.Firm firm;
        Actions.FirmActions firmActions;
        private int firmId;

        public EditFirmForm()
        {
            InitializeComponent(); 
        }

        public EditFirmForm(Entities.Firm firmProp) : this()
        {
            this.firm = firmProp;
            this.firmActions = new Actions.FirmActions();
            firmId = firmProp.FirmId;
        }

        private void EditFirmForm_Load(object sender, System.EventArgs e)
        {
            textBox_Name.Text = firm.Name;
            textBox_City.Text = firm.City;
            textBox_Street.Text = firm.Street;
            textBox_Number.Text = firm.Number.ToString();
            textBox_Zip.Text = firm.Zip;
        }

        private void button_Edit_Click(object sender, System.EventArgs e)
        {
            Entities.Firm editedFirm = new Entities.Firm();

            firmActions.Edit(firmId, textBox_Name.Text, textBox_City.Text, textBox_Street.Text, int.Parse(textBox_Number.Text), textBox_Zip.Text);
            ActiveForm.Close();
        }
    }
}
