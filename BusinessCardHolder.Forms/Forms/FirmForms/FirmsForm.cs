using BusinessCardHolder.Forms.Forms.Firm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BusinessCardHolder.Entities;

namespace BusinessCardHolder.Forms.Forms
{
    public partial class FirmsForm : Form
    {
        private Actions.FirmActions firmActions;
        private AddFirmForm addFirmForm;
        private SearchEngineFirm searchFirm;
        

        public FirmsForm()
        {
            InitializeComponent();
            firmActions = new Actions.FirmActions();
            searchFirm = new SearchEngineFirm();
        }

        private void FirmsForm_Load(object sender, EventArgs e)
        {  
            dataGridView_Firms.DataSource = firmActions.ReadAllFirms();
        }

        
        private void button_AddFirm_Click(object sender, EventArgs e)
        {
            addFirmForm = new AddFirmForm();
            addFirmForm.MdiParent = this.MdiParent;
            addFirmForm.Show();
        }
        


        public void button_EditFirm_Click(object sender, EventArgs e)
        {
            
            int currentId = GetFirmIdFromTable(0);
            Entities.Firm firm = firmActions.ReadFirm(currentId);

            var editFirmForm = new EditFirmForm(firm);
            editFirmForm.MdiParent = this.MdiParent;
            editFirmForm.Show();
        }

        private void button_RemoveFirm_Click(object sender, EventArgs e)
        {
            int currentId = GetFirmIdFromTable(0);
            //Entities.Firm firm = firmActions.DownloadSingleFirmData(currentId);
            var firm = firmActions.ReadFirm(currentId);

            DialogResult messageBox = MessageBox.Show("Are you sure you want remove firm"+ firm.Name + " ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(messageBox == DialogResult.Yes)
            {
                if (firmActions.CheckIfFirmExist(currentId) == true)
                {
                    try
                    {
                        firmActions.DeleteFirm(currentId);
                        MessageBox.Show(firm.Name + "(id: " + firm.FirmId + ")" + " was deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch(System.Data.Entity.Infrastructure.DbUpdateException)
                    {
                        MessageBox.Show("Firm have assigned employees.\nDelete them before deleting firm", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
                else MessageBox.Show("No data record in database!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            

        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            //ReloadTable();
            //dataGridView_Firms.Update();
            dataGridView_Firms.DataSource = firmActions.ReadAllFirms();
        }
        
        public void ReloadTable()
        {
            dataGridView_Firms.DataSource = firmActions.ReadAllFirms();
        }



        private int GetFirmIdFromTable(int columnIndex)
        {
            int result = 0;

            try
            {
                int rowindex = dataGridView_Firms.CurrentCell.RowIndex;
                result = int.Parse(dataGridView_Firms.Rows[rowindex].Cells[columnIndex].Value.ToString());
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return result;
        }

        private int GetFirmIdFromTable()
        {
            int result = 0;

            try
            {
                int rowindex = dataGridView_Firms.CurrentCell.RowIndex;
                result = int.Parse(dataGridView_Firms.Rows[rowindex].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return result;
        }

        private void button_Nuke_Click(object sender, EventArgs e)
        {
            DialogResult messageBox = MessageBox.Show("Are you sure?\nAll firms in database will be Removed", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(messageBox == DialogResult.Yes)
            {
                firmActions.NukeFirms();
                MessageBox.Show("Done");
            }
        }

        private void dataGridView_Firms_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //MessageBox.Show(GetFirmIdFromTable(dataGridView_Firms.CurrentCell.RowIndex).ToString());
            Entities.Firm firm = firmActions.ReadFirm(GetFirmIdFromTable());
            var firmForm = new FirmForm(firm);
            firmForm.MdiParent = this.MdiParent;
            firmForm.Show();
        }

        private void button_Search_Basic_Click(object sender, EventArgs e)
        {
            string name = textBox_SearchName.Text;

            if (checkBox_AdvancedSearch.Checked)
            {
                
                string city = textBox_SearchCity.Text;
                string street = textBox_SearchStreet.Text;
                //string[] s = { name, city, street };
                //var list = searchFirm.SearchFirmAllWords(s);
                var list = searchFirm.SearchFirmAnyWord(name, city, street);
                dataGridView_Firms.DataSource = list;
            }
            else
            {
                var list = searchFirm.SearchFirmByName(name);
                dataGridView_Firms.DataSource = list;
            }
            
        }

        private void checkBox_AdvancedSearch_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_AdvancedSearch.Checked)
            {
                label_SearchCity.Visible = true;
                label_searchStreet.Visible = true;
                textBox_SearchCity.Visible = true;
                textBox_SearchStreet.Visible = true;
            }
            else
            {
                label_SearchCity.Visible = false;
                label_searchStreet.Visible = false;
                textBox_SearchCity.Visible = false;
                textBox_SearchStreet.Visible = false;
            }
            
        }
    }
}


