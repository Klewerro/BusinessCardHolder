using BusinessCardHolder.Forms.Forms.Firm;
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
    public partial class FirmsForm : Form
    {
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

            BusinessCardContext context = new BusinessCardContext();
            var firms = from Firm in context.Firm
                        select Firm;
            dataGridView_Firms.DataSource = firms.ToList();
        }

        private void button_AddFirm_Click(object sender, EventArgs e)
        {
            AddFirmForm addFirmForm= new AddFirmForm();
            addFirmForm.Show();
        }

        public void ReloadTable()
        {
            BusinessCardContext context = new BusinessCardContext();
            var firms = from Firm in context.Firm
                        select Firm;
            dataGridView_Firms.DataSource = firms.ToList();
        }


        private void button_EditFirm_Click(object sender, EventArgs e)
        {
            ReloadTable();
        }

    }
}


