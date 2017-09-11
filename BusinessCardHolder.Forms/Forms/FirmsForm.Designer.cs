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
            this.businessCardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Firms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessCardBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Firms
            // 
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
            // businessCardBindingSource
            // 
            this.businessCardBindingSource.DataSource = typeof(BusinessCardHolder.Entities.Firm);
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(12, 22);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(118, 32);
            this.button_Refresh.TabIndex = 1;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // FirmsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 561);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.dataGridView_Firms);
            this.Name = "FirmsForm";
            this.Text = "FirmsForm";
            this.Load += new System.EventHandler(this.FirmsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Firms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessCardBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Firms;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessCardIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource businessCardBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource firmBindingSource;
    }
}