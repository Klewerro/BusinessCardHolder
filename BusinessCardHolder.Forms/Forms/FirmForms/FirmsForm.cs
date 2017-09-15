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
        private Actions.FirmActions firmActions;
        private AddFirmForm addFirmForm;

        public FirmsForm()
        {
            InitializeComponent();
            firmActions = new Actions.FirmActions();
        }

        private void FirmsForm_Load(object sender, EventArgs e)
        {  
            dataGridView_Firms.DataSource = firmActions.DownloadFirmDataIntoList();
        }

        
        private void button_AddFirm_Click(object sender, EventArgs e)
        {
            addFirmForm = new AddFirmForm();
            //addFirmForm.MdiParent = MDIParent.ActiveForm;
            //AddFirmForm activeMdiChild = this.ActiveMdiChild as AddFirmForm;

            addFirmForm.Show();
        }
        //private void addFirmForm_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    addFirmForm = null;
        //}

        private void button_EditFirm_Click(object sender, EventArgs e)
        {
            
            int currentId = GetFirmIdFromTable(0);
            Entities.Firm firm = firmActions.DownloadSingleFirmData(currentId);

            var editFirmForm = new EditFirmForm(firm);
            editFirmForm.Show();
        }

        private void button_RemoveFirm_Click(object sender, EventArgs e)
        {
            int currentId = GetFirmIdFromTable(0);
            //Entities.Firm firm = firmActions.DownloadSingleFirmData(currentId);
            
           
            
            if(firmActions.CheckIfExist(currentId) == true)
            {
                firmActions.Remove(currentId);
                MessageBox.Show("Ukończono", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Brak rekordu w bazie danych!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            //ReloadTable();
            //dataGridView_Firms.Update();
            dataGridView_Firms.DataSource = firmActions.DownloadFirmDataIntoList();
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


