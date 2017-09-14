using BusinessCardHolder.Forms.Forms.Firm;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BusinessCardHolder.Actions;

namespace BusinessCardHolder.Forms.Forms
{
    public partial class FirmsForm : Form
    {
        Actions.FirmActions firmActions;

        public FirmsForm()
        {
            InitializeComponent();
            //BusinessCardContext dc = new BusinessCardContext();
            //dataGridView_Firms.Columns.Add("Names", "Firm Name");
            //dataGridView_Firms.Columns.Add("Cities", "City");
            //BusinessCardContext context = new BusinessCardContext();
            //foreach (var item in context.Firm)
            //{
            //    var name = item.Name.ToString();
            //    var city = item.City.ToString();
            //    var street = item.Street.ToString();
            //    dataGridView_Firms.Rows.Add(name, city, street);
            //}


            firmActions = new Actions.FirmActions();

        }

        private void FirmsForm_Load(object sender, EventArgs e)
        {
            
            dataGridView_Firms.DataSource = firmActions.DownloadFirmDataIntoList();
        }

        
        private void button_AddFirm_Click(object sender, EventArgs e)
        {
            AddFirmForm addFirmForm = new AddFirmForm();
            addFirmForm.Show();
        }

        private void button_EditFirm_Click(object sender, EventArgs e)
        {
            
            int currentId = GetFirmIdFromTable(0);
            Entities.Firm firm = firmActions.DownloadSingleFirmData(currentId);

            var editFirmForm = new EditFirmForm(firm);
            editFirmForm.Show();
        }

        private void button_RemoveFirm_Click(object sender, EventArgs e)
        {
            int currentId = int.Parse(dataGridView_Firms.CurrentCell.Value.ToString());

        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            //ReloadTable();
            dataGridView_Firms.Update();

        }
        
        public void ReloadTable()
        {
            dataGridView_Firms.DataSource = firmActions.DownloadFirmDataIntoList();
        }

        

        private int GetFirmIdFromTable(int indexPop)
        {
            int rowindex = dataGridView_Firms.CurrentCell.RowIndex;
            //int columnindex = dataGridView_Firms.CurrentCell.ColumnIndex;
            return int.Parse(dataGridView_Firms.Rows[rowindex].Cells[indexPop].Value.ToString());
        }


    }
}


