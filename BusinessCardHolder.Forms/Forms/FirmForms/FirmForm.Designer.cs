namespace BusinessCardHolder.Forms.Forms
{
    partial class FirmForm
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
            this.groupBox_Firm = new System.Windows.Forms.GroupBox();
            this.label_FirmZip = new System.Windows.Forms.Label();
            this.label_FirmStreet = new System.Windows.Forms.Label();
            this.label_FirmCity = new System.Windows.Forms.Label();
            this.textBox_FirmZip = new System.Windows.Forms.TextBox();
            this.textBox_FirmNumber = new System.Windows.Forms.TextBox();
            this.textBox_FirmStreet = new System.Windows.Forms.TextBox();
            this.textBox_FirmCity = new System.Windows.Forms.TextBox();
            this.label_FirmName = new System.Windows.Forms.Label();
            this.textBox_FirmName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bithDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_AddEmployee = new System.Windows.Forms.Button();
            this.groupBox_Firm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Firm
            // 
            this.groupBox_Firm.Controls.Add(this.label_FirmZip);
            this.groupBox_Firm.Controls.Add(this.label_FirmStreet);
            this.groupBox_Firm.Controls.Add(this.label_FirmCity);
            this.groupBox_Firm.Controls.Add(this.textBox_FirmZip);
            this.groupBox_Firm.Controls.Add(this.textBox_FirmNumber);
            this.groupBox_Firm.Controls.Add(this.textBox_FirmStreet);
            this.groupBox_Firm.Controls.Add(this.textBox_FirmCity);
            this.groupBox_Firm.Controls.Add(this.label_FirmName);
            this.groupBox_Firm.Controls.Add(this.textBox_FirmName);
            this.groupBox_Firm.Location = new System.Drawing.Point(12, 39);
            this.groupBox_Firm.Name = "groupBox_Firm";
            this.groupBox_Firm.Size = new System.Drawing.Size(222, 177);
            this.groupBox_Firm.TabIndex = 0;
            this.groupBox_Firm.TabStop = false;
            this.groupBox_Firm.Text = "Firm";
            // 
            // label_FirmZip
            // 
            this.label_FirmZip.AutoSize = true;
            this.label_FirmZip.Location = new System.Drawing.Point(71, 128);
            this.label_FirmZip.Name = "label_FirmZip";
            this.label_FirmZip.Size = new System.Drawing.Size(52, 13);
            this.label_FirmZip.TabIndex = 9;
            this.label_FirmZip.Text = "Zip code:";
            // 
            // label_FirmStreet
            // 
            this.label_FirmStreet.AutoSize = true;
            this.label_FirmStreet.Location = new System.Drawing.Point(6, 93);
            this.label_FirmStreet.Name = "label_FirmStreet";
            this.label_FirmStreet.Size = new System.Drawing.Size(38, 13);
            this.label_FirmStreet.TabIndex = 7;
            this.label_FirmStreet.Text = "Street:";
            // 
            // label_FirmCity
            // 
            this.label_FirmCity.AutoSize = true;
            this.label_FirmCity.Location = new System.Drawing.Point(6, 57);
            this.label_FirmCity.Name = "label_FirmCity";
            this.label_FirmCity.Size = new System.Drawing.Size(27, 13);
            this.label_FirmCity.TabIndex = 6;
            this.label_FirmCity.Text = "City:";
            // 
            // textBox_FirmZip
            // 
            this.textBox_FirmZip.Location = new System.Drawing.Point(129, 125);
            this.textBox_FirmZip.Name = "textBox_FirmZip";
            this.textBox_FirmZip.Size = new System.Drawing.Size(85, 20);
            this.textBox_FirmZip.TabIndex = 5;
            // 
            // textBox_FirmNumber
            // 
            this.textBox_FirmNumber.Location = new System.Drawing.Point(167, 90);
            this.textBox_FirmNumber.Name = "textBox_FirmNumber";
            this.textBox_FirmNumber.Size = new System.Drawing.Size(47, 20);
            this.textBox_FirmNumber.TabIndex = 4;
            // 
            // textBox_FirmStreet
            // 
            this.textBox_FirmStreet.Location = new System.Drawing.Point(62, 90);
            this.textBox_FirmStreet.Name = "textBox_FirmStreet";
            this.textBox_FirmStreet.Size = new System.Drawing.Size(103, 20);
            this.textBox_FirmStreet.TabIndex = 3;
            // 
            // textBox_FirmCity
            // 
            this.textBox_FirmCity.Location = new System.Drawing.Point(62, 54);
            this.textBox_FirmCity.Name = "textBox_FirmCity";
            this.textBox_FirmCity.Size = new System.Drawing.Size(152, 20);
            this.textBox_FirmCity.TabIndex = 2;
            // 
            // label_FirmName
            // 
            this.label_FirmName.AutoSize = true;
            this.label_FirmName.Location = new System.Drawing.Point(6, 22);
            this.label_FirmName.Name = "label_FirmName";
            this.label_FirmName.Size = new System.Drawing.Size(35, 13);
            this.label_FirmName.TabIndex = 1;
            this.label_FirmName.Text = "Name";
            // 
            // textBox_FirmName
            // 
            this.textBox_FirmName.Location = new System.Drawing.Point(62, 19);
            this.textBox_FirmName.Name = "textBox_FirmName";
            this.textBox_FirmName.Size = new System.Drawing.Size(152, 20);
            this.textBox_FirmName.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personIdDataGridViewTextBoxColumn,
            this.fornameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.cellPhoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.bithDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(240, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 381);
            this.dataGridView1.TabIndex = 1;
            // 
            // personIdDataGridViewTextBoxColumn
            // 
            this.personIdDataGridViewTextBoxColumn.DataPropertyName = "PersonId";
            this.personIdDataGridViewTextBoxColumn.HeaderText = "PersonId";
            this.personIdDataGridViewTextBoxColumn.Name = "personIdDataGridViewTextBoxColumn";
            this.personIdDataGridViewTextBoxColumn.Width = 30;
            // 
            // fornameDataGridViewTextBoxColumn
            // 
            this.fornameDataGridViewTextBoxColumn.DataPropertyName = "Forname";
            this.fornameDataGridViewTextBoxColumn.HeaderText = "Forname";
            this.fornameDataGridViewTextBoxColumn.Name = "fornameDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // cellPhoneDataGridViewTextBoxColumn
            // 
            this.cellPhoneDataGridViewTextBoxColumn.DataPropertyName = "CellPhone";
            this.cellPhoneDataGridViewTextBoxColumn.HeaderText = "CellPhone";
            this.cellPhoneDataGridViewTextBoxColumn.Name = "cellPhoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // bithDateDataGridViewTextBoxColumn
            // 
            this.bithDateDataGridViewTextBoxColumn.DataPropertyName = "BithDate";
            this.bithDateDataGridViewTextBoxColumn.HeaderText = "BithDate";
            this.bithDateDataGridViewTextBoxColumn.Name = "bithDateDataGridViewTextBoxColumn";
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(BusinessCardHolder.Entities.Person);
            // 
            // button_AddEmployee
            // 
            this.button_AddEmployee.Location = new System.Drawing.Point(41, 232);
            this.button_AddEmployee.Name = "button_AddEmployee";
            this.button_AddEmployee.Size = new System.Drawing.Size(167, 29);
            this.button_AddEmployee.TabIndex = 2;
            this.button_AddEmployee.Text = "Add Employee";
            this.button_AddEmployee.UseVisualStyleBackColor = true;
            this.button_AddEmployee.Click += new System.EventHandler(this.button_AddEmployee_Click);
            // 
            // FirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 437);
            this.Controls.Add(this.button_AddEmployee);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox_Firm);
            this.Name = "FirmForm";
            this.Text = "FirmForm";
            this.Load += new System.EventHandler(this.FirmForm_Load);
            this.groupBox_Firm.ResumeLayout(false);
            this.groupBox_Firm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Firm;
        private System.Windows.Forms.Label label_FirmName;
        private System.Windows.Forms.TextBox textBox_FirmName;
        private System.Windows.Forms.Label label_FirmZip;
        private System.Windows.Forms.Label label_FirmStreet;
        private System.Windows.Forms.Label label_FirmCity;
        private System.Windows.Forms.TextBox textBox_FirmZip;
        private System.Windows.Forms.TextBox textBox_FirmNumber;
        private System.Windows.Forms.TextBox textBox_FirmStreet;
        private System.Windows.Forms.TextBox textBox_FirmCity;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bithDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.Button button_AddEmployee;
    }
}