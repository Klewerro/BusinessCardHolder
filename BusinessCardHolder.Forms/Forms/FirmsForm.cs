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
            BusinessCardContext dc = new BusinessCardContext();
            var firms = from Firm in dc.Firm
                        select Firm;
            dataGridView_Firms.DataSource = firms.ToList();
        }

        private void FirmsForm_Load(object sender, EventArgs e)
        {

        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            BusinessCardContext dc = new BusinessCardContext();
            var firms = from Firm in dc.Firm
                        select Firm;
            dataGridView_Firms.DataSource = firms.ToList();
        }
    }
}


