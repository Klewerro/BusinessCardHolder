using System;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Windows.Forms;
using BusinessCardHolder.Actions;
using System.ComponentModel.DataAnnotations;

namespace BusinessCardHolder.Forms.Forms
{
    public partial class PersonsForm : Form
    {
        private PersonActions personActions;
        private SearchEnginePerson searchPerson;

        public PersonsForm()
        {
            InitializeComponent();
            personActions = new PersonActions();
            searchPerson = new SearchEnginePerson();
        }

        private void PersonsForm_Load(object sender, EventArgs e)
        {
            DownloadEmployees();
        }

        private void DownloadEmployees()
        {
            var personsList = personActions.ReadPersons();
            
            dataGridView_Persons.DataSource = personsList;
            //try
            //{
                
            //}
            //catch (NullReferenceException ex)
            //{
            //    //MessageBox.Show("Firm" + firmInCurrentForm.Name + "have not any employees.\n" + ex.Message, "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    MessageBox.Show(ex.Message);
            //    MessageBox.Show(ex.StackTrace.ToString());
            //}
        }

        private int GetPersonIdFromTable()
        {
            int result = 0;

            try
            {
                int rowindex = dataGridView_Persons.CurrentCell.RowIndex;
                result = int.Parse(dataGridView_Persons.Rows[rowindex].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return result;
        }

        private void dataGridView_Persons_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Entities.Person person = personActions.ReadPerson(GetPersonIdFromTable());
            //person.FirmName = person.Firm.Name.ToString();


            var personForm = new PersonForm(person);
            personForm.MdiParent = this.MdiParent;
            personForm.Show();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            if (this.Width < 1150)
            {
                button_Search.Text = "<< Search";
                this.Width = 1150;
            } 
            else 
            {
                button_Search.Text = "Search >>";
                this.Width = 910;
            }
                
        }

        private void button_SearchAction_Click(object sender, EventArgs e)
        {
            string name = textBox_SearchName.Text;
            string forename = textBox_SearchForename.Text;
            string email = textBox_SearchEmail.Text;
            string firmname = textBox_SearchFirmName.Text;

            var list = searchPerson.SearchPersonAnyWord(name, forename, email, firmname);
            dataGridView_Persons.DataSource = list;
        }
    }
}
