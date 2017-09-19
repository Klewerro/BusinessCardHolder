using BusinessCardHolder.Forms.Forms.Firm;
using System;
using System.Windows.Forms;

namespace BusinessCardHolder.Forms.Forms
{
    public partial class MDIParent : Form
    {
        FirmsForm firmsForm;
        Form2 f2;

        public MDIParent()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.MdiParent = this;
            f1.Show();
        }

        
        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (f2 == null)
            {
                f2 = new Form2();
                f2.MdiParent = this;
                f2.FormClosed += new FormClosedEventHandler(f2_FormClosed);
                f2.Show();
            }
            else
                f2.Activate();
        }
        private void f2_FormClosed(object sender, FormClosedEventArgs e)
        {
            f2 = null;
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in MdiChildren)
            {
                item.Close();
            }
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        
        private void firmsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (firmsForm == null)
            {
                firmsForm = new FirmsForm();
                firmsForm.MdiParent = this;
                firmsForm.FormClosed += new FormClosedEventHandler(firmsForm_FormClosed);
                firmsForm.Show();
            }
            else
                firmsForm.Activate();   
        }
        private void firmsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            firmsForm = null;
        }
    }
}

