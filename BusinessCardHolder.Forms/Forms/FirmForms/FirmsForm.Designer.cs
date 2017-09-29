namespace BusinessCardHolder.Forms.Forms
{
    partial class FirmsForm
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
            this.dataGridView_Firms = new System.Windows.Forms.DataGridView();
            this.firmIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_RemoveFirm = new System.Windows.Forms.Button();
            this.button_EditFirm = new System.Windows.Forms.Button();
            this.button_AddFirm = new System.Windows.Forms.Button();
            this.button_Nuke = new System.Windows.Forms.Button();
            this.groupBox_Search = new System.Windows.Forms.GroupBox();
            this.label_searchStreet = new System.Windows.Forms.Label();
            this.label_SearchCity = new System.Windows.Forms.Label();
            this.label_SearchName = new System.Windows.Forms.Label();
            this.textBox_SearchStreet = new System.Windows.Forms.TextBox();
            this.textBox_SearchCity = new System.Windows.Forms.TextBox();
            this.checkBox_AdvancedSearch = new System.Windows.Forms.CheckBox();
            this.button_Search_Basic = new System.Windows.Forms.Button();
            this.textBox_SearchName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Firms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Firms
            // 
            this.dataGridView_Firms.AllowUserToAddRows = false;
            this.dataGridView_Firms.AllowUserToDeleteRows = false;
            this.dataGridView_Firms.AllowUserToOrderColumns = true;
            this.dataGridView_Firms.AutoGenerateColumns = false;
            this.dataGridView_Firms.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Firms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Firms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firmIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.zipDataGridViewTextBoxColumn});
            this.dataGridView_Firms.DataSource = this.firmBindingSource;
            this.dataGridView_Firms.Location = new System.Drawing.Point(226, 12);
            this.dataGridView_Firms.MultiSelect = false;
            this.dataGridView_Firms.Name = "dataGridView_Firms";
            this.dataGridView_Firms.ReadOnly = true;
            this.dataGridView_Firms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Firms.Size = new System.Drawing.Size(644, 537);
            this.dataGridView_Firms.TabIndex = 0;
            this.dataGridView_Firms.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Firms_CellMouseDoubleClick);
            // 
            // firmIdDataGridViewTextBoxColumn
            // 
            this.firmIdDataGridViewTextBoxColumn.DataPropertyName = "FirmId";
            this.firmIdDataGridViewTextBoxColumn.HeaderText = "FirmId";
            this.firmIdDataGridViewTextBoxColumn.Name = "firmIdDataGridViewTextBoxColumn";
            this.firmIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zipDataGridViewTextBoxColumn
            // 
            this.zipDataGridViewTextBoxColumn.DataPropertyName = "Zip";
            this.zipDataGridViewTextBoxColumn.HeaderText = "Zip";
            this.zipDataGridViewTextBoxColumn.Name = "zipDataGridViewTextBoxColumn";
            this.zipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firmBindingSource
            // 
            this.firmBindingSource.DataSource = typeof(BusinessCardHolder.Entities.Firm);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Refresh);
            this.groupBox1.Controls.Add(this.button_RemoveFirm);
            this.groupBox1.Controls.Add(this.button_EditFirm);
            this.groupBox1.Controls.Add(this.button_AddFirm);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 252);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(6, 195);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(188, 39);
            this.button_Refresh.TabIndex = 3;
            this.button_Refresh.Text = "Refresh table";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // button_RemoveFirm
            // 
            this.button_RemoveFirm.Location = new System.Drawing.Point(6, 138);
            this.button_RemoveFirm.Name = "button_RemoveFirm";
            this.button_RemoveFirm.Size = new System.Drawing.Size(188, 39);
            this.button_RemoveFirm.TabIndex = 2;
            this.button_RemoveFirm.Text = "Remove Firm";
            this.button_RemoveFirm.UseVisualStyleBackColor = true;
            this.button_RemoveFirm.Click += new System.EventHandler(this.button_RemoveFirm_Click);
            // 
            // button_EditFirm
            // 
            this.button_EditFirm.Location = new System.Drawing.Point(6, 79);
            this.button_EditFirm.Name = "button_EditFirm";
            this.button_EditFirm.Size = new System.Drawing.Size(188, 39);
            this.button_EditFirm.TabIndex = 1;
            this.button_EditFirm.Text = "Edit Firm";
            this.button_EditFirm.UseVisualStyleBackColor = true;
            this.button_EditFirm.Click += new System.EventHandler(this.button_EditFirm_Click);
            // 
            // button_AddFirm
            // 
            this.button_AddFirm.Location = new System.Drawing.Point(6, 19);
            this.button_AddFirm.Name = "button_AddFirm";
            this.button_AddFirm.Size = new System.Drawing.Size(188, 39);
            this.button_AddFirm.TabIndex = 0;
            this.button_AddFirm.Text = "Add Firm";
            this.button_AddFirm.UseVisualStyleBackColor = true;
            this.button_AddFirm.Click += new System.EventHandler(this.button_AddFirm_Click);
            // 
            // button_Nuke
            // 
            this.button_Nuke.Location = new System.Drawing.Point(34, 495);
            this.button_Nuke.Name = "button_Nuke";
            this.button_Nuke.Size = new System.Drawing.Size(140, 23);
            this.button_Nuke.TabIndex = 2;
            this.button_Nuke.Text = "TACTICAL NUKE";
            this.button_Nuke.UseVisualStyleBackColor = true;
            this.button_Nuke.Click += new System.EventHandler(this.button_Nuke_Click);
            // 
            // groupBox_Search
            // 
            this.groupBox_Search.Controls.Add(this.label_searchStreet);
            this.groupBox_Search.Controls.Add(this.label_SearchCity);
            this.groupBox_Search.Controls.Add(this.label_SearchName);
            this.groupBox_Search.Controls.Add(this.textBox_SearchStreet);
            this.groupBox_Search.Controls.Add(this.textBox_SearchCity);
            this.groupBox_Search.Controls.Add(this.checkBox_AdvancedSearch);
            this.groupBox_Search.Controls.Add(this.button_Search_Basic);
            this.groupBox_Search.Controls.Add(this.textBox_SearchName);
            this.groupBox_Search.Location = new System.Drawing.Point(12, 270);
            this.groupBox_Search.Name = "groupBox_Search";
            this.groupBox_Search.Size = new System.Drawing.Size(200, 193);
            this.groupBox_Search.TabIndex = 4;
            this.groupBox_Search.TabStop = false;
            this.groupBox_Search.Text = "Search";
            // 
            // label_searchStreet
            // 
            this.label_searchStreet.AutoSize = true;
            this.label_searchStreet.Location = new System.Drawing.Point(6, 120);
            this.label_searchStreet.Name = "label_searchStreet";
            this.label_searchStreet.Size = new System.Drawing.Size(38, 13);
            this.label_searchStreet.TabIndex = 7;
            this.label_searchStreet.Text = "Street:";
            this.label_searchStreet.Visible = false;
            // 
            // label_SearchCity
            // 
            this.label_SearchCity.AutoSize = true;
            this.label_SearchCity.Location = new System.Drawing.Point(6, 98);
            this.label_SearchCity.Name = "label_SearchCity";
            this.label_SearchCity.Size = new System.Drawing.Size(27, 13);
            this.label_SearchCity.TabIndex = 6;
            this.label_SearchCity.Text = "City:";
            this.label_SearchCity.Visible = false;
            // 
            // label_SearchName
            // 
            this.label_SearchName.AutoSize = true;
            this.label_SearchName.Location = new System.Drawing.Point(6, 26);
            this.label_SearchName.Name = "label_SearchName";
            this.label_SearchName.Size = new System.Drawing.Size(38, 13);
            this.label_SearchName.TabIndex = 5;
            this.label_SearchName.Text = "Name:";
            // 
            // textBox_SearchStreet
            // 
            this.textBox_SearchStreet.Location = new System.Drawing.Point(56, 117);
            this.textBox_SearchStreet.Name = "textBox_SearchStreet";
            this.textBox_SearchStreet.Size = new System.Drawing.Size(138, 20);
            this.textBox_SearchStreet.TabIndex = 4;
            this.textBox_SearchStreet.Visible = false;
            // 
            // textBox_SearchCity
            // 
            this.textBox_SearchCity.Location = new System.Drawing.Point(56, 91);
            this.textBox_SearchCity.Name = "textBox_SearchCity";
            this.textBox_SearchCity.Size = new System.Drawing.Size(138, 20);
            this.textBox_SearchCity.TabIndex = 3;
            this.textBox_SearchCity.Visible = false;
            // 
            // checkBox_AdvancedSearch
            // 
            this.checkBox_AdvancedSearch.AutoSize = true;
            this.checkBox_AdvancedSearch.Location = new System.Drawing.Point(6, 68);
            this.checkBox_AdvancedSearch.Name = "checkBox_AdvancedSearch";
            this.checkBox_AdvancedSearch.Size = new System.Drawing.Size(112, 17);
            this.checkBox_AdvancedSearch.TabIndex = 2;
            this.checkBox_AdvancedSearch.Text = "Advanced Search";
            this.checkBox_AdvancedSearch.UseVisualStyleBackColor = true;
            this.checkBox_AdvancedSearch.CheckedChanged += new System.EventHandler(this.checkBox_AdvancedSearch_CheckedChanged);
            // 
            // button_Search_Basic
            // 
            this.button_Search_Basic.Location = new System.Drawing.Point(150, 42);
            this.button_Search_Basic.Name = "button_Search_Basic";
            this.button_Search_Basic.Size = new System.Drawing.Size(44, 23);
            this.button_Search_Basic.TabIndex = 1;
            this.button_Search_Basic.Text = "button1";
            this.button_Search_Basic.UseVisualStyleBackColor = true;
            this.button_Search_Basic.Click += new System.EventHandler(this.button_Search_Basic_Click);
            // 
            // textBox_SearchName
            // 
            this.textBox_SearchName.Location = new System.Drawing.Point(6, 42);
            this.textBox_SearchName.Name = "textBox_SearchName";
            this.textBox_SearchName.Size = new System.Drawing.Size(138, 20);
            this.textBox_SearchName.TabIndex = 0;
            // 
            // FirmsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 561);
            this.Controls.Add(this.groupBox_Search);
            this.Controls.Add(this.button_Nuke);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView_Firms);
            this.Name = "FirmsForm";
            this.Text = "FirmsForm";
            this.Load += new System.EventHandler(this.FirmsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Firms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox_Search.ResumeLayout(false);
            this.groupBox_Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Firms;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessCardIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource firmBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_RemoveFirm;
        private System.Windows.Forms.Button button_EditFirm;
        private System.Windows.Forms.Button button_AddFirm;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Button button_Nuke;
        private System.Windows.Forms.GroupBox groupBox_Search;
        private System.Windows.Forms.Button button_Search_Basic;
        private System.Windows.Forms.TextBox textBox_SearchName;
        private System.Windows.Forms.CheckBox checkBox_AdvancedSearch;
        private System.Windows.Forms.TextBox textBox_SearchStreet;
        private System.Windows.Forms.TextBox textBox_SearchCity;
        private System.Windows.Forms.Label label_searchStreet;
        private System.Windows.Forms.Label label_SearchCity;
        private System.Windows.Forms.Label label_SearchName;
    }
}