namespace BusinessCardHolder.Forms.Forms.Firm
{
    partial class AddFirmForm
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
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_City = new System.Windows.Forms.TextBox();
            this.textBox_Street = new System.Windows.Forms.TextBox();
            this.label_FirmName = new System.Windows.Forms.Label();
            this.label_City = new System.Windows.Forms.Label();
            this.label_Street = new System.Windows.Forms.Label();
            this.label_Number = new System.Windows.Forms.Label();
            this.label_Zip = new System.Windows.Forms.Label();
            this.textBox_Number = new System.Windows.Forms.TextBox();
            this.textBox_Zip = new System.Windows.Forms.TextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(102, 34);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(200, 20);
            this.textBox_Name.TabIndex = 0;
            // 
            // textBox_City
            // 
            this.textBox_City.Location = new System.Drawing.Point(102, 72);
            this.textBox_City.Name = "textBox_City";
            this.textBox_City.Size = new System.Drawing.Size(200, 20);
            this.textBox_City.TabIndex = 1;
            // 
            // textBox_Street
            // 
            this.textBox_Street.Location = new System.Drawing.Point(102, 108);
            this.textBox_Street.Name = "textBox_Street";
            this.textBox_Street.Size = new System.Drawing.Size(200, 20);
            this.textBox_Street.TabIndex = 2;
            // 
            // label_FirmName
            // 
            this.label_FirmName.AutoSize = true;
            this.label_FirmName.Location = new System.Drawing.Point(39, 37);
            this.label_FirmName.Name = "label_FirmName";
            this.label_FirmName.Size = new System.Drawing.Size(57, 13);
            this.label_FirmName.TabIndex = 3;
            this.label_FirmName.Text = "Firm Name";
            // 
            // label_City
            // 
            this.label_City.AutoSize = true;
            this.label_City.Location = new System.Drawing.Point(72, 75);
            this.label_City.Name = "label_City";
            this.label_City.Size = new System.Drawing.Size(24, 13);
            this.label_City.TabIndex = 4;
            this.label_City.Text = "City";
            // 
            // label_Street
            // 
            this.label_Street.AutoSize = true;
            this.label_Street.Location = new System.Drawing.Point(61, 111);
            this.label_Street.Name = "label_Street";
            this.label_Street.Size = new System.Drawing.Size(35, 13);
            this.label_Street.TabIndex = 5;
            this.label_Street.Text = "Street";
            // 
            // label_Number
            // 
            this.label_Number.AutoSize = true;
            this.label_Number.Location = new System.Drawing.Point(23, 150);
            this.label_Number.Name = "label_Number";
            this.label_Number.Size = new System.Drawing.Size(73, 13);
            this.label_Number.TabIndex = 6;
            this.label_Number.Text = "Local Number";
            // 
            // label_Zip
            // 
            this.label_Zip.AutoSize = true;
            this.label_Zip.Location = new System.Drawing.Point(46, 187);
            this.label_Zip.Name = "label_Zip";
            this.label_Zip.Size = new System.Drawing.Size(50, 13);
            this.label_Zip.TabIndex = 7;
            this.label_Zip.Text = "Zip Code";
            // 
            // textBox_Number
            // 
            this.textBox_Number.Location = new System.Drawing.Point(102, 147);
            this.textBox_Number.Name = "textBox_Number";
            this.textBox_Number.Size = new System.Drawing.Size(200, 20);
            this.textBox_Number.TabIndex = 8;
            // 
            // textBox_Zip
            // 
            this.textBox_Zip.Location = new System.Drawing.Point(102, 184);
            this.textBox_Zip.Name = "textBox_Zip";
            this.textBox_Zip.Size = new System.Drawing.Size(200, 20);
            this.textBox_Zip.TabIndex = 9;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(102, 225);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(90, 38);
            this.button_Add.TabIndex = 10;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(212, 225);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(90, 38);
            this.button_Cancel.TabIndex = 11;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // AddFirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 301);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Add);
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
            this.Name = "AddFirmForm";
            this.Text = "Add Firm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddFirmForm_FormClosing);
            this.Load += new System.EventHandler(this.AddFirmForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_City;
        private System.Windows.Forms.TextBox textBox_Street;
        private System.Windows.Forms.Label label_FirmName;
        private System.Windows.Forms.Label label_City;
        private System.Windows.Forms.Label label_Street;
        private System.Windows.Forms.Label label_Number;
        private System.Windows.Forms.Label label_Zip;
        private System.Windows.Forms.TextBox textBox_Number;
        private System.Windows.Forms.TextBox textBox_Zip;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Cancel;
    }
}