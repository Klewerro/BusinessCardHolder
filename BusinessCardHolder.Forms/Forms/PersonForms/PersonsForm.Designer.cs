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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_SearchName = new System.Windows.Forms.TextBox();
            this.textBox_SearchForename = new System.Windows.Forms.TextBox();
            this.textBox_SearchEmail = new System.Windows.Forms.TextBox();
            this.textBox_SearchFirmName = new System.Windows.Forms.TextBox();
            this.button_SearchAction = new System.Windows.Forms.Button();
            this.personIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bithDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Persons)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_SearchAction);
            this.groupBox1.Controls.Add(this.textBox_SearchFirmName);
            this.groupBox1.Controls.Add(this.textBox_SearchEmail);
            this.groupBox1.Controls.Add(this.textBox_SearchForename);
            this.groupBox1.Controls.Add(this.textBox_SearchName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(917, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 354);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search person";
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(810, 524);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 23);
            this.button_Search.TabIndex = 2;
            this.button_Search.Text = "Search >>";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Forename:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Frim name:";
            // 
            // textBox_SearchName
            // 
            this.textBox_SearchName.Location = new System.Drawing.Point(79, 13);
            this.textBox_SearchName.Name = "textBox_SearchName";
            this.textBox_SearchName.Size = new System.Drawing.Size(120, 20);
            this.textBox_SearchName.TabIndex = 6;
            // 
            // textBox_SearchForename
            // 
            this.textBox_SearchForename.Location = new System.Drawing.Point(79, 39);
            this.textBox_SearchForename.Name = "textBox_SearchForename";
            this.textBox_SearchForename.Size = new System.Drawing.Size(120, 20);
            this.textBox_SearchForename.TabIndex = 7;
            // 
            // textBox_SearchEmail
            // 
            this.textBox_SearchEmail.Location = new System.Drawing.Point(79, 65);
            this.textBox_SearchEmail.Name = "textBox_SearchEmail";
            this.textBox_SearchEmail.Size = new System.Drawing.Size(120, 20);
            this.textBox_SearchEmail.TabIndex = 8;
            // 
            // textBox_SearchFirmName
            // 
            this.textBox_SearchFirmName.Location = new System.Drawing.Point(79, 91);
            this.textBox_SearchFirmName.Name = "textBox_SearchFirmName";
            this.textBox_SearchFirmName.Size = new System.Drawing.Size(120, 20);
            this.textBox_SearchFirmName.TabIndex = 9;
            // 
            // button_SearchAction
            // 
            this.button_SearchAction.Location = new System.Drawing.Point(124, 134);
            this.button_SearchAction.Name = "button_SearchAction";
            this.button_SearchAction.Size = new System.Drawing.Size(75, 23);
            this.button_SearchAction.TabIndex = 10;
            this.button_SearchAction.Text = "Search";
            this.button_SearchAction.UseVisualStyleBackColor = true;
            this.button_SearchAction.Click += new System.EventHandler(this.button_SearchAction_Click);
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
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(BusinessCardHolder.Entities.Person);
            // 
            // PersonsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 555);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView_Persons);
            this.Name = "PersonsForm";
            this.Text = "PersonsForm";
            this.Load += new System.EventHandler(this.PersonsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Persons)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_SearchAction;
        private System.Windows.Forms.TextBox textBox_SearchFirmName;
        private System.Windows.Forms.TextBox textBox_SearchEmail;
        private System.Windows.Forms.TextBox textBox_SearchForename;
        private System.Windows.Forms.TextBox textBox_SearchName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}