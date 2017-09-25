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

        public PersonsForm()
        {
            InitializeComponent();
            personActions = new PersonActions();
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
            personForm.Show();
        }
    }
}
