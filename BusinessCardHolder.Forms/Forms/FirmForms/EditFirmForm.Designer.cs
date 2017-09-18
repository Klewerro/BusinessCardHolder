namespace BusinessCardHolder.Forms.Forms.Firm
{
    partial class EditFirmForm
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
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.textBox_Zip = new System.Windows.Forms.TextBox();
            this.textBox_Number = new System.Windows.Forms.TextBox();
            this.label_Zip = new System.Windows.Forms.Label();
            this.label_Number = new System.Windows.Forms.Label();
            this.label_Street = new System.Windows.Forms.Label();
            this.label_City = new System.Windows.Forms.Label();
            this.label_FirmName = new System.Windows.Forms.Label();
            this.textBox_Street = new System.Windows.Forms.TextBox();
            this.textBox_City = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(215, 214);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(90, 38);
            this.button_Cancel.TabIndex = 23;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(105, 214);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(90, 38);
            this.button_Edit.TabIndex = 22;
            this.button_Edit.Text = "Edit";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // textBox_Zip
            // 
            this.textBox_Zip.Location = new System.Drawing.Point(105, 173);
            this.textBox_Zip.Name = "textBox_Zip";
            this.textBox_Zip.Size = new System.Drawing.Size(200, 20);
            this.textBox_Zip.TabIndex = 21;
            // 
            // textBox_Number
            // 
            this.textBox_Number.Location = new System.Drawing.Point(105, 136);
            this.textBox_Number.Name = "textBox_Number";
            this.textBox_Number.Size = new System.Drawing.Size(200, 20);
            this.textBox_Number.TabIndex = 20;
            // 
            // label_Zip
            // 
            this.label_Zip.AutoSize = true;
            this.label_Zip.Location = new System.Drawing.Point(49, 176);
            this.label_Zip.Name = "label_Zip";
            this.label_Zip.Size = new System.Drawing.Size(50, 13);
            this.label_Zip.TabIndex = 19;
            this.label_Zip.Text = "Zip Code";
            // 
            // label_Number
            // 
            this.label_Number.AutoSize = true;
            this.label_Number.Location = new System.Drawing.Point(26, 139);
            this.label_Number.Name = "label_Number";
            this.label_Number.Size = new System.Drawing.Size(73, 13);
            this.label_Number.TabIndex = 18;
            this.label_Number.Text = "Local Number";
            // 
            // label_Street
            // 
            this.label_Street.AutoSize = true;
            this.label_Street.Location = new System.Drawing.Point(64, 100);
            this.label_Street.Name = "label_Street";
            this.label_Street.Size = new System.Drawing.Size(35, 13);
            this.label_Street.TabIndex = 17;
            this.label_Street.Text = "Street";
            // 
            // label_City
            // 
            this.label_City.AutoSize = true;
            this.label_City.Location = new System.Drawing.Point(75, 64);
            this.label_City.Name = "label_City";
            this.label_City.Size = new System.Drawing.Size(24, 13);
            this.label_City.TabIndex = 16;
            this.label_City.Text = "City";
            // 
            // label_FirmName
            // 
            this.label_FirmName.AutoSize = true;
            this.label_FirmName.Location = new System.Drawing.Point(42, 26);
            this.label_FirmName.Name = "label_FirmName";
            this.label_FirmName.Size = new System.Drawing.Size(57, 13);
            this.label_FirmName.TabIndex = 15;
            this.label_FirmName.Text = "Firm Name";
            // 
            // textBox_Street
            // 
            this.textBox_Street.Location = new System.Drawing.Point(105, 97);
            this.textBox_Street.Name = "textBox_Street";
            this.textBox_Street.Size = new System.Drawing.Size(200, 20);
            this.textBox_Street.TabIndex = 14;
            // 
            // textBox_City
            // 
            this.textBox_City.Location = new System.Drawing.Point(105, 61);
            this.textBox_City.Name = "textBox_City";
            this.textBox_City.Size = new System.Drawing.Size(200, 20);
            this.textBox_City.TabIndex = 13;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(105, 23);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(200, 20);
            this.textBox_Name.TabIndex = 12;
            // 
            // EditFirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 301);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.textBox_Zip);
            this.Controls.Add(this.textBox_Number);
            this.Controls.Add(this.label_Zip);
            this.Controls.Add(this.label_Number);
            this.Controls.Add(this.label_Street);
            this.Controls.Add(this.label_City);
            this.Controls.Add(this.label_FirmName);
            this.Controls.Add(this.textBox_Street);
            this.Controls.Add(this.textBox_City);
            this.Controls.Add(this.textBox_Name);
            this.Name = "EditFirmForm";
            this.Text = "EditFirmForm";
            this.Load += new System.EventHandler(this.EditFirmForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.TextBox textBox_Zip;
        private System.Windows.Forms.TextBox textBox_Number;
        private System.Windows.Forms.Label label_Zip;
        private System.Windows.Forms.Label label_Number;
        private System.Windows.Forms.Label label_Street;
        private System.Windows.Forms.Label label_City;
        private System.Windows.Forms.Label label_FirmName;
        private System.Windows.Forms.TextBox textBox_Street;
        private System.Windows.Forms.TextBox textBox_City;
        private System.Windows.Forms.TextBox textBox_Name;
    }
}