namespace BusinessCardHolder.Forms.Forms
{
    partial class PersonForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_overview = new System.Windows.Forms.TabPage();
            this.label_EmployedIn = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_BirthDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_CellPhone = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Nameheader = new System.Windows.Forms.Label();
            this.label_Phone = new System.Windows.Forms.Label();
            this.label_Forename = new System.Windows.Forms.Label();
            this.tabPage_Edit = new System.Windows.Forms.TabPage();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_EmployeeRemove = new System.Windows.Forms.Button();
            this.button_EmployeeEdit = new System.Windows.Forms.Button();
            this.label_EmployeeBirthDate = new System.Windows.Forms.Label();
            this.label_EmployeeEmail = new System.Windows.Forms.Label();
            this.label_EmployeeCellPhone = new System.Windows.Forms.Label();
            this.label_EmployeePhone = new System.Windows.Forms.Label();
            this.label_EmployeeName = new System.Windows.Forms.Label();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.textBox_EmployeeEmail = new System.Windows.Forms.TextBox();
            this.textBox_EmployeeCellPhone = new System.Windows.Forms.TextBox();
            this.textBox_EmployeePhone = new System.Windows.Forms.TextBox();
            this.textBox_EmployeeName = new System.Windows.Forms.TextBox();
            this.label_EmployeeForename = new System.Windows.Forms.Label();
            this.textBox_EmployeeForename = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage_overview.SuspendLayout();
            this.tabPage_Edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_overview);
            this.tabControl1.Controls.Add(this.tabPage_Edit);
            this.tabControl1.Location = new System.Drawing.Point(12, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(453, 296);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage_overview
            // 
            this.tabPage_overview.Controls.Add(this.label_EmployedIn);
            this.tabPage_overview.Controls.Add(this.label5);
            this.tabPage_overview.Controls.Add(this.label_BirthDate);
            this.tabPage_overview.Controls.Add(this.label4);
            this.tabPage_overview.Controls.Add(this.label_Email);
            this.tabPage_overview.Controls.Add(this.label1);
            this.tabPage_overview.Controls.Add(this.label3);
            this.tabPage_overview.Controls.Add(this.label_CellPhone);
            this.tabPage_overview.Controls.Add(this.label2);
            this.tabPage_overview.Controls.Add(this.label_Nameheader);
            this.tabPage_overview.Controls.Add(this.label_Phone);
            this.tabPage_overview.Controls.Add(this.label_Forename);
            this.tabPage_overview.Location = new System.Drawing.Point(4, 22);
            this.tabPage_overview.Name = "tabPage_overview";
            this.tabPage_overview.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_overview.Size = new System.Drawing.Size(445, 270);
            this.tabPage_overview.TabIndex = 0;
            this.tabPage_overview.Text = "Overview";
            this.tabPage_overview.UseVisualStyleBackColor = true;
            // 
            // label_EmployedIn
            // 
            this.label_EmployedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_EmployedIn.Location = new System.Drawing.Point(234, 225);
            this.label_EmployedIn.Name = "label_EmployedIn";
            this.label_EmployedIn.Size = new System.Drawing.Size(203, 42);
            this.label_EmployedIn.TabIndex = 11;
            this.label_EmployedIn.Text = "label1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Employed in:";
            // 
            // label_BirthDate
            // 
            this.label_BirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_BirthDate.Location = new System.Drawing.Point(6, 225);
            this.label_BirthDate.Name = "label_BirthDate";
            this.label_BirthDate.Size = new System.Drawing.Size(224, 42);
            this.label_BirthDate.TabIndex = 9;
            this.label_BirthDate.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Birth date:";
            // 
            // label_Email
            // 
            this.label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Email.Location = new System.Drawing.Point(6, 159);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(224, 42);
            this.label_Email.TabIndex = 7;
            this.label_Email.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "E-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cell phone number:";
            // 
            // label_CellPhone
            // 
            this.label_CellPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_CellPhone.Location = new System.Drawing.Point(236, 92);
            this.label_CellPhone.Name = "label_CellPhone";
            this.label_CellPhone.Size = new System.Drawing.Size(203, 42);
            this.label_CellPhone.TabIndex = 4;
            this.label_CellPhone.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phone number:";
            // 
            // label_Nameheader
            // 
            this.label_Nameheader.AutoSize = true;
            this.label_Nameheader.Location = new System.Drawing.Point(8, 20);
            this.label_Nameheader.Name = "label_Nameheader";
            this.label_Nameheader.Size = new System.Drawing.Size(107, 13);
            this.label_Nameheader.TabIndex = 2;
            this.label_Nameheader.Text = "Forename and name:";
            // 
            // label_Phone
            // 
            this.label_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Phone.Location = new System.Drawing.Point(6, 92);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(224, 42);
            this.label_Phone.TabIndex = 1;
            this.label_Phone.Text = "label1";
            // 
            // label_Forename
            // 
            this.label_Forename.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Forename.Location = new System.Drawing.Point(6, 33);
            this.label_Forename.Name = "label_Forename";
            this.label_Forename.Size = new System.Drawing.Size(433, 42);
            this.label_Forename.TabIndex = 0;
            this.label_Forename.Text = "label1";
            // 
            // tabPage_Edit
            // 
            this.tabPage_Edit.Controls.Add(this.button_Clear);
            this.tabPage_Edit.Controls.Add(this.button_EmployeeRemove);
            this.tabPage_Edit.Controls.Add(this.button_EmployeeEdit);
            this.tabPage_Edit.Controls.Add(this.label_EmployeeBirthDate);
            this.tabPage_Edit.Controls.Add(this.label_EmployeeEmail);
            this.tabPage_Edit.Controls.Add(this.label_EmployeeCellPhone);
            this.tabPage_Edit.Controls.Add(this.label_EmployeePhone);
            this.tabPage_Edit.Controls.Add(this.label_EmployeeName);
            this.tabPage_Edit.Controls.Add(this.birthDatePicker);
            this.tabPage_Edit.Controls.Add(this.textBox_EmployeeEmail);
            this.tabPage_Edit.Controls.Add(this.textBox_EmployeeCellPhone);
            this.tabPage_Edit.Controls.Add(this.textBox_EmployeePhone);
            this.tabPage_Edit.Controls.Add(this.textBox_EmployeeName);
            this.tabPage_Edit.Controls.Add(this.label_EmployeeForename);
            this.tabPage_Edit.Controls.Add(this.textBox_EmployeeForename);
            this.tabPage_Edit.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Edit.Name = "tabPage_Edit";
            this.tabPage_Edit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Edit.Size = new System.Drawing.Size(445, 270);
            this.tabPage_Edit.TabIndex = 1;
            this.tabPage_Edit.Text = "Edit information";
            this.tabPage_Edit.UseVisualStyleBackColor = true;
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(278, 187);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(46, 39);
            this.button_Clear.TabIndex = 33;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_EmployeeRemove
            // 
            this.button_EmployeeRemove.Location = new System.Drawing.Point(244, 235);
            this.button_EmployeeRemove.Name = "button_EmployeeRemove";
            this.button_EmployeeRemove.Size = new System.Drawing.Size(56, 27);
            this.button_EmployeeRemove.TabIndex = 32;
            this.button_EmployeeRemove.Text = "Remove";
            this.button_EmployeeRemove.UseVisualStyleBackColor = true;
            this.button_EmployeeRemove.Click += new System.EventHandler(this.button_EmployeeRemove_Click);
            // 
            // button_EmployeeEdit
            // 
            this.button_EmployeeEdit.Location = new System.Drawing.Point(178, 235);
            this.button_EmployeeEdit.Name = "button_EmployeeEdit";
            this.button_EmployeeEdit.Size = new System.Drawing.Size(56, 27);
            this.button_EmployeeEdit.TabIndex = 31;
            this.button_EmployeeEdit.Text = "Edit";
            this.button_EmployeeEdit.UseVisualStyleBackColor = true;
            this.button_EmployeeEdit.Click += new System.EventHandler(this.button_EmployeeEdit_Click);
            // 
            // label_EmployeeBirthDate
            // 
            this.label_EmployeeBirthDate.AutoSize = true;
            this.label_EmployeeBirthDate.Location = new System.Drawing.Point(114, 193);
            this.label_EmployeeBirthDate.Name = "label_EmployeeBirthDate";
            this.label_EmployeeBirthDate.Size = new System.Drawing.Size(55, 13);
            this.label_EmployeeBirthDate.TabIndex = 29;
            this.label_EmployeeBirthDate.Text = "Birth date:";
            // 
            // label_EmployeeEmail
            // 
            this.label_EmployeeEmail.AutoSize = true;
            this.label_EmployeeEmail.Location = new System.Drawing.Point(114, 153);
            this.label_EmployeeEmail.Name = "label_EmployeeEmail";
            this.label_EmployeeEmail.Size = new System.Drawing.Size(35, 13);
            this.label_EmployeeEmail.TabIndex = 28;
            this.label_EmployeeEmail.Text = "E-mail";
            // 
            // label_EmployeeCellPhone
            // 
            this.label_EmployeeCellPhone.AutoSize = true;
            this.label_EmployeeCellPhone.Location = new System.Drawing.Point(114, 117);
            this.label_EmployeeCellPhone.Name = "label_EmployeeCellPhone";
            this.label_EmployeeCellPhone.Size = new System.Drawing.Size(58, 13);
            this.label_EmployeeCellPhone.TabIndex = 27;
            this.label_EmployeeCellPhone.Text = "Cell Phone";
            // 
            // label_EmployeePhone
            // 
            this.label_EmployeePhone.AutoSize = true;
            this.label_EmployeePhone.Location = new System.Drawing.Point(114, 82);
            this.label_EmployeePhone.Name = "label_EmployeePhone";
            this.label_EmployeePhone.Size = new System.Drawing.Size(38, 13);
            this.label_EmployeePhone.TabIndex = 26;
            this.label_EmployeePhone.Text = "Phone";
            // 
            // label_EmployeeName
            // 
            this.label_EmployeeName.AutoSize = true;
            this.label_EmployeeName.Location = new System.Drawing.Point(116, 47);
            this.label_EmployeeName.Name = "label_EmployeeName";
            this.label_EmployeeName.Size = new System.Drawing.Size(35, 13);
            this.label_EmployeeName.TabIndex = 25;
            this.label_EmployeeName.Text = "Name";
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.CustomFormat = "dd-MM-yyyy";
            this.birthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDatePicker.ImeMode = System.Windows.Forms.ImeMode.On;
            this.birthDatePicker.Location = new System.Drawing.Point(172, 194);
            this.birthDatePicker.MaxDate = new System.DateTime(4000, 12, 31, 0, 0, 0, 0);
            this.birthDatePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(93, 20);
            this.birthDatePicker.TabIndex = 24;
            this.birthDatePicker.Value = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            // 
            // textBox_EmployeeEmail
            // 
            this.textBox_EmployeeEmail.Location = new System.Drawing.Point(172, 150);
            this.textBox_EmployeeEmail.Name = "textBox_EmployeeEmail";
            this.textBox_EmployeeEmail.Size = new System.Drawing.Size(152, 20);
            this.textBox_EmployeeEmail.TabIndex = 23;
            // 
            // textBox_EmployeeCellPhone
            // 
            this.textBox_EmployeeCellPhone.Location = new System.Drawing.Point(172, 114);
            this.textBox_EmployeeCellPhone.Name = "textBox_EmployeeCellPhone";
            this.textBox_EmployeeCellPhone.Size = new System.Drawing.Size(152, 20);
            this.textBox_EmployeeCellPhone.TabIndex = 22;
            // 
            // textBox_EmployeePhone
            // 
            this.textBox_EmployeePhone.Location = new System.Drawing.Point(172, 79);
            this.textBox_EmployeePhone.Name = "textBox_EmployeePhone";
            this.textBox_EmployeePhone.Size = new System.Drawing.Size(152, 20);
            this.textBox_EmployeePhone.TabIndex = 21;
            // 
            // textBox_EmployeeName
            // 
            this.textBox_EmployeeName.Location = new System.Drawing.Point(172, 44);
            this.textBox_EmployeeName.Name = "textBox_EmployeeName";
            this.textBox_EmployeeName.Size = new System.Drawing.Size(152, 20);
            this.textBox_EmployeeName.TabIndex = 20;
            // 
            // label_EmployeeForename
            // 
            this.label_EmployeeForename.AutoSize = true;
            this.label_EmployeeForename.Location = new System.Drawing.Point(114, 12);
            this.label_EmployeeForename.Name = "label_EmployeeForename";
            this.label_EmployeeForename.Size = new System.Drawing.Size(54, 13);
            this.label_EmployeeForename.TabIndex = 19;
            this.label_EmployeeForename.Text = "Forename";
            // 
            // textBox_EmployeeForename
            // 
            this.textBox_EmployeeForename.Location = new System.Drawing.Point(172, 9);
            this.textBox_EmployeeForename.Name = "textBox_EmployeeForename";
            this.textBox_EmployeeForename.Size = new System.Drawing.Size(152, 20);
            this.textBox_EmployeeForename.TabIndex = 18;
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 344);
            this.Controls.Add(this.tabControl1);
            this.Name = "PersonForm";
            this.Text = "PersonForm";
            this.Load += new System.EventHandler(this.PersonForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_overview.ResumeLayout(false);
            this.tabPage_overview.PerformLayout();
            this.tabPage_Edit.ResumeLayout(false);
            this.tabPage_Edit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_overview;
        private System.Windows.Forms.Label label_Forename;
        private System.Windows.Forms.TabPage tabPage_Edit;
        private System.Windows.Forms.Label label_Nameheader;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_CellPhone;
        private System.Windows.Forms.Label label_BirthDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_EmployedIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_EmployeeRemove;
        private System.Windows.Forms.Button button_EmployeeEdit;
        private System.Windows.Forms.Label label_EmployeeBirthDate;
        private System.Windows.Forms.Label label_EmployeeEmail;
        private System.Windows.Forms.Label label_EmployeeCellPhone;
        private System.Windows.Forms.Label label_EmployeePhone;
        private System.Windows.Forms.Label label_EmployeeName;
        private System.Windows.Forms.DateTimePicker birthDatePicker;
        private System.Windows.Forms.TextBox textBox_EmployeeEmail;
        private System.Windows.Forms.TextBox textBox_EmployeeCellPhone;
        private System.Windows.Forms.TextBox textBox_EmployeePhone;
        private System.Windows.Forms.TextBox textBox_EmployeeName;
        private System.Windows.Forms.Label label_EmployeeForename;
        private System.Windows.Forms.TextBox textBox_EmployeeForename;
    }
}