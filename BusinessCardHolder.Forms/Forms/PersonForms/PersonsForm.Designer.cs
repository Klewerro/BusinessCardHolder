namespace BusinessCardHolder.Forms.Forms
{
    partial class PersonsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView_Persons = new System.Windows.Forms.DataGridView();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bithDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Persons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Persons
            // 
            this.dataGridView_Persons.AllowUserToAddRows = false;
            this.dataGridView_Persons.AutoGenerateColumns = false;
            this.dataGridView_Persons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Persons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personIdDataGridViewTextBoxColumn,
            this.forenameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.cellPhoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.bithDateDataGridViewTextBoxColumn,
            this.firmNameDataGridViewTextBoxColumn});
            this.dataGridView_Persons.DataSource = this.personBindingSource;
            this.dataGridView_Persons.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Persons.Name = "dataGridView_Persons";
            this.dataGridView_Persons.ReadOnly = true;
            this.dataGridView_Persons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Persons.Size = new System.Drawing.Size(873, 506);
            this.dataGridView_Persons.TabIndex = 0;
            this.dataGridView_Persons.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Persons_CellContentDoubleClick);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(BusinessCardHolder.Entities.Person);
            // 
            // personIdDataGridViewTextBoxColumn
            // 
            this.personIdDataGridViewTextBoxColumn.DataPropertyName = "PersonId";
            this.personIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.personIdDataGridViewTextBoxColumn.Name = "personIdDataGridViewTextBoxColumn";
            this.personIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.personIdDataGridViewTextBoxColumn.Width = 40;
            // 
            // forenameDataGridViewTextBoxColumn
            // 
            this.forenameDataGridViewTextBoxColumn.DataPropertyName = "Forename";
            this.forenameDataGridViewTextBoxColumn.HeaderText = "Forename";
            this.forenameDataGridViewTextBoxColumn.Name = "forenameDataGridViewTextBoxColumn";
            this.forenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 140;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cellPhoneDataGridViewTextBoxColumn
            // 
            this.cellPhoneDataGridViewTextBoxColumn.DataPropertyName = "CellPhone";
            this.cellPhoneDataGridViewTextBoxColumn.HeaderText = "CellPhone";
            this.cellPhoneDataGridViewTextBoxColumn.Name = "cellPhoneDataGridViewTextBoxColumn";
            this.cellPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bithDateDataGridViewTextBoxColumn
            // 
            this.bithDateDataGridViewTextBoxColumn.DataPropertyName = "BithDate";
            this.bithDateDataGridViewTextBoxColumn.HeaderText = "BithDate";
            this.bithDateDataGridViewTextBoxColumn.Name = "bithDateDataGridViewTextBoxColumn";
            this.bithDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firmNameDataGridViewTextBoxColumn
            // 
            this.firmNameDataGridViewTextBoxColumn.DataPropertyName = "FirmName";
            this.firmNameDataGridViewTextBoxColumn.HeaderText = "FirmName";
            this.firmNameDataGridViewTextBoxColumn.Name = "firmNameDataGridViewTextBoxColumn";
            this.firmNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firmNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // PersonsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 555);
            this.Controls.Add(this.dataGridView_Persons);
            this.Name = "PersonsForm";
            this.Text = "PersonsForm";
            this.Load += new System.EventHandler(this.PersonsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Persons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Persons;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn forenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bithDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource personBindingSource;
    }
}