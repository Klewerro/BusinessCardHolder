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
            this.button_RemoveFirm = new System.Windows.Forms.Button();
            this.button_EditFirm = new System.Windows.Forms.Button();
            this.button_AddFirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Firms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Firms
            // 
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
            this.dataGridView_Firms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Firms.Size = new System.Drawing.Size(644, 537);
            this.dataGridView_Firms.TabIndex = 0;
            // 
            // firmIdDataGridViewTextBoxColumn
            // 
            this.firmIdDataGridViewTextBoxColumn.DataPropertyName = "FirmId";
            this.firmIdDataGridViewTextBoxColumn.HeaderText = "FirmId";
            this.firmIdDataGridViewTextBoxColumn.Name = "firmIdDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // zipDataGridViewTextBoxColumn
            // 
            this.zipDataGridViewTextBoxColumn.DataPropertyName = "Zip";
            this.zipDataGridViewTextBoxColumn.HeaderText = "Zip";
            this.zipDataGridViewTextBoxColumn.Name = "zipDataGridViewTextBoxColumn";
            // 
            // firmBindingSource
            // 
            this.firmBindingSource.DataSource = typeof(BusinessCardHolder.Entities.Firm);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_RemoveFirm);
            this.groupBox1.Controls.Add(this.button_EditFirm);
            this.groupBox1.Controls.Add(this.button_AddFirm);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 201);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // button_RemoveFirm
            // 
            this.button_RemoveFirm.Location = new System.Drawing.Point(6, 138);
            this.button_RemoveFirm.Name = "button_RemoveFirm";
            this.button_RemoveFirm.Size = new System.Drawing.Size(188, 39);
            this.button_RemoveFirm.TabIndex = 2;
            this.button_RemoveFirm.Text = "Remove Firm";
            this.button_RemoveFirm.UseVisualStyleBackColor = true;
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
            // FirmsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView_Firms);
            this.Name = "FirmsForm";
            this.Text = "FirmsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Firms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
    }
}