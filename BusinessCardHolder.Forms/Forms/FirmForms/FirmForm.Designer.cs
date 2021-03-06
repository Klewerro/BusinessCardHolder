﻿namespace BusinessCardHolder.Forms.Forms
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
            this.label_FirmZip = new System.Windows.Forms.Label();
            this.label_FirmStreet = new System.Windows.Forms.Label();
            this.label_FirmCity = new System.Windows.Forms.Label();
            this.textBox_FirmZip = new System.Windows.Forms.TextBox();
            this.textBox_FirmNumber = new System.Windows.Forms.TextBox();
            this.textBox_FirmStreet = new System.Windows.Forms.TextBox();
            this.textBox_FirmCity = new System.Windows.Forms.TextBox();
            this.label_FirmName = new System.Windows.Forms.Label();
            this.textBox_FirmName = new System.Windows.Forms.TextBox();
            this.dataGridView_EmployeesTable = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip_InTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.texyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_AddEmployee = new System.Windows.Forms.Button();
            this.tabControl_Firm = new System.Windows.Forms.TabControl();
            this.tabPage_Firm = new System.Windows.Forms.TabPage();
            this.button_FirmCancel = new System.Windows.Forms.Button();
            this.button_FirmEdit = new System.Windows.Forms.Button();
            this.button_FirmSaveChanges = new System.Windows.Forms.Button();
            this.tabPage_Employees = new System.Windows.Forms.TabPage();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_EmployeeRemove = new System.Windows.Forms.Button();
            this.button_EmployeeEdit = new System.Windows.Forms.Button();
            this.button_EmployeeAdd = new System.Windows.Forms.Button();
            this.label_EmployeeBirthDate = new System.Windows.Forms.Label();
            this.label_EmployeeEmail = new System.Windows.Forms.Label();
            this.label_EmployeeCellPhone = new System.Windows.Forms.Label();
            this.label_EmployeePhone = new System.Windows.Forms.Label();
            this.label_EmployeeName = new System.Windows.Forms.Label();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.textBox_EmployeeEmail = new System.Windows.Forms.TextBox();
            this.textBox_EmployeeCellPhone = new System.Windows.Forms.TextBox();
            this.textBox_EmployeePhone = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.label_EmployeeForename = new System.Windows.Forms.Label();
            this.textBox_EmployeeForename = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label_SearchName = new System.Windows.Forms.Label();
            this.textBox_SearchName = new System.Windows.Forms.TextBox();
            this.textBox_SearchForename = new System.Windows.Forms.TextBox();
            this.textBox_SearchEmail = new System.Windows.Forms.TextBox();
            this.textBox_SearchFirmName = new System.Windows.Forms.TextBox();
            this.label_SearchForename = new System.Windows.Forms.Label();
            this.label_SearchEmail = new System.Windows.Forms.Label();
            this.label_SearchFirmName = new System.Windows.Forms.Label();
            this.button_SearchAction = new System.Windows.Forms.Button();
            this.bithDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EmployeesTable)).BeginInit();
            this.contextMenuStrip_InTable.SuspendLayout();
            this.tabControl_Firm.SuspendLayout();
            this.tabPage_Firm.SuspendLayout();
            this.tabPage_Employees.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label_FirmZip
            // 
            this.label_FirmZip.AutoSize = true;
            this.label_FirmZip.Location = new System.Drawing.Point(71, 139);
            this.label_FirmZip.Name = "label_FirmZip";
            this.label_FirmZip.Size = new System.Drawing.Size(52, 13);
            this.label_FirmZip.TabIndex = 9;
            this.label_FirmZip.Text = "Zip code:";
            // 
            // label_FirmStreet
            // 
            this.label_FirmStreet.AutoSize = true;
            this.label_FirmStreet.Location = new System.Drawing.Point(6, 104);
            this.label_FirmStreet.Name = "label_FirmStreet";
            this.label_FirmStreet.Size = new System.Drawing.Size(38, 13);
            this.label_FirmStreet.TabIndex = 7;
            this.label_FirmStreet.Text = "Street:";
            // 
            // label_FirmCity
            // 
            this.label_FirmCity.AutoSize = true;
            this.label_FirmCity.Location = new System.Drawing.Point(6, 68);
            this.label_FirmCity.Name = "label_FirmCity";
            this.label_FirmCity.Size = new System.Drawing.Size(27, 13);
            this.label_FirmCity.TabIndex = 6;
            this.label_FirmCity.Text = "City:";
            // 
            // textBox_FirmZip
            // 
            this.textBox_FirmZip.Location = new System.Drawing.Point(129, 136);
            this.textBox_FirmZip.Name = "textBox_FirmZip";
            this.textBox_FirmZip.ReadOnly = true;
            this.textBox_FirmZip.Size = new System.Drawing.Size(85, 20);
            this.textBox_FirmZip.TabIndex = 5;
            // 
            // textBox_FirmNumber
            // 
            this.textBox_FirmNumber.Location = new System.Drawing.Point(167, 101);
            this.textBox_FirmNumber.Name = "textBox_FirmNumber";
            this.textBox_FirmNumber.ReadOnly = true;
            this.textBox_FirmNumber.Size = new System.Drawing.Size(47, 20);
            this.textBox_FirmNumber.TabIndex = 4;
            // 
            // textBox_FirmStreet
            // 
            this.textBox_FirmStreet.Location = new System.Drawing.Point(62, 101);
            this.textBox_FirmStreet.Name = "textBox_FirmStreet";
            this.textBox_FirmStreet.ReadOnly = true;
            this.textBox_FirmStreet.Size = new System.Drawing.Size(103, 20);
            this.textBox_FirmStreet.TabIndex = 3;
            // 
            // textBox_FirmCity
            // 
            this.textBox_FirmCity.Location = new System.Drawing.Point(62, 65);
            this.textBox_FirmCity.Name = "textBox_FirmCity";
            this.textBox_FirmCity.Size = new System.Drawing.Size(152, 20);
            this.textBox_FirmCity.TabIndex = 2;
            // 
            // label_FirmName
            // 
            this.label_FirmName.AutoSize = true;
            this.label_FirmName.Location = new System.Drawing.Point(6, 33);
            this.label_FirmName.Name = "label_FirmName";
            this.label_FirmName.Size = new System.Drawing.Size(35, 13);
            this.label_FirmName.TabIndex = 1;
            this.label_FirmName.Text = "Name";
            // 
            // textBox_FirmName
            // 
            this.textBox_FirmName.Location = new System.Drawing.Point(62, 30);
            this.textBox_FirmName.Name = "textBox_FirmName";
            this.textBox_FirmName.Size = new System.Drawing.Size(152, 20);
            this.textBox_FirmName.TabIndex = 0;
            // 
            // dataGridView_EmployeesTable
            // 
            this.dataGridView_EmployeesTable.AutoGenerateColumns = false;
            this.dataGridView_EmployeesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_EmployeesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personIdDataGridViewTextBoxColumn,
            this.forenameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.cellPhoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.bithDateDataGridViewTextBoxColumn});
            this.dataGridView_EmployeesTable.ContextMenuStrip = this.contextMenuStrip_InTable;
            this.dataGridView_EmployeesTable.DataSource = this.personBindingSource;
            this.dataGridView_EmployeesTable.Location = new System.Drawing.Point(257, 39);
            this.dataGridView_EmployeesTable.MultiSelect = false;
            this.dataGridView_EmployeesTable.Name = "dataGridView_EmployeesTable";
            this.dataGridView_EmployeesTable.ReadOnly = true;
            this.dataGridView_EmployeesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_EmployeesTable.Size = new System.Drawing.Size(742, 381);
            this.dataGridView_EmployeesTable.TabIndex = 1;
            this.dataGridView_EmployeesTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_EmployeesTable_CellContentClick);
            this.dataGridView_EmployeesTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_EmployeesTable_CellMouseClick);
            // 
            // contextMenuStrip_InTable
            // 
            this.contextMenuStrip_InTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textToolStripMenuItem,
            this.texyToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.contextMenuStrip_InTable.Name = "contextMenuStrip_InTable";
            this.contextMenuStrip_InTable.Size = new System.Drawing.Size(118, 70);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.textToolStripMenuItem.Text = "Edit";
            // 
            // texyToolStripMenuItem
            // 
            this.texyToolStripMenuItem.Name = "texyToolStripMenuItem";
            this.texyToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.texyToolStripMenuItem.Text = "Remove";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // button_AddEmployee
            // 
            this.button_AddEmployee.Location = new System.Drawing.Point(41, 248);
            this.button_AddEmployee.Name = "button_AddEmployee";
            this.button_AddEmployee.Size = new System.Drawing.Size(167, 29);
            this.button_AddEmployee.TabIndex = 2;
            this.button_AddEmployee.Text = "Add Employee";
            this.button_AddEmployee.UseVisualStyleBackColor = true;
            this.button_AddEmployee.Click += new System.EventHandler(this.button_AddEmployee_Click);
            // 
            // tabControl_Firm
            // 
            this.tabControl_Firm.Controls.Add(this.tabPage_Firm);
            this.tabControl_Firm.Controls.Add(this.tabPage_Employees);
            this.tabControl_Firm.Controls.Add(this.tabPage1);
            this.tabControl_Firm.Location = new System.Drawing.Point(12, 39);
            this.tabControl_Firm.Name = "tabControl_Firm";
            this.tabControl_Firm.SelectedIndex = 0;
            this.tabControl_Firm.Size = new System.Drawing.Size(239, 316);
            this.tabControl_Firm.TabIndex = 4;
            // 
            // tabPage_Firm
            // 
            this.tabPage_Firm.Controls.Add(this.button_FirmCancel);
            this.tabPage_Firm.Controls.Add(this.button_FirmEdit);
            this.tabPage_Firm.Controls.Add(this.button_FirmSaveChanges);
            this.tabPage_Firm.Controls.Add(this.label_FirmZip);
            this.tabPage_Firm.Controls.Add(this.textBox_FirmName);
            this.tabPage_Firm.Controls.Add(this.label_FirmStreet);
            this.tabPage_Firm.Controls.Add(this.label_FirmName);
            this.tabPage_Firm.Controls.Add(this.label_FirmCity);
            this.tabPage_Firm.Controls.Add(this.textBox_FirmCity);
            this.tabPage_Firm.Controls.Add(this.textBox_FirmZip);
            this.tabPage_Firm.Controls.Add(this.textBox_FirmStreet);
            this.tabPage_Firm.Controls.Add(this.textBox_FirmNumber);
            this.tabPage_Firm.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Firm.Name = "tabPage_Firm";
            this.tabPage_Firm.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Firm.Size = new System.Drawing.Size(231, 290);
            this.tabPage_Firm.TabIndex = 0;
            this.tabPage_Firm.Text = "Firm";
            this.tabPage_Firm.UseVisualStyleBackColor = true;
            // 
            // button_FirmCancel
            // 
            this.button_FirmCancel.Location = new System.Drawing.Point(115, 189);
            this.button_FirmCancel.Name = "button_FirmCancel";
            this.button_FirmCancel.Size = new System.Drawing.Size(96, 25);
            this.button_FirmCancel.TabIndex = 12;
            this.button_FirmCancel.Text = "Cancel";
            this.button_FirmCancel.UseVisualStyleBackColor = true;
            this.button_FirmCancel.Visible = false;
            this.button_FirmCancel.Click += new System.EventHandler(this.button_FirmCancel_Click);
            // 
            // button_FirmEdit
            // 
            this.button_FirmEdit.Location = new System.Drawing.Point(62, 189);
            this.button_FirmEdit.Name = "button_FirmEdit";
            this.button_FirmEdit.Size = new System.Drawing.Size(123, 25);
            this.button_FirmEdit.TabIndex = 11;
            this.button_FirmEdit.Text = "Edit firm";
            this.button_FirmEdit.UseVisualStyleBackColor = true;
            this.button_FirmEdit.Click += new System.EventHandler(this.button_FirmEdit_Click);
            // 
            // button_FirmSaveChanges
            // 
            this.button_FirmSaveChanges.Location = new System.Drawing.Point(9, 189);
            this.button_FirmSaveChanges.Name = "button_FirmSaveChanges";
            this.button_FirmSaveChanges.Size = new System.Drawing.Size(100, 25);
            this.button_FirmSaveChanges.TabIndex = 10;
            this.button_FirmSaveChanges.Text = "Save changes";
            this.button_FirmSaveChanges.UseVisualStyleBackColor = true;
            this.button_FirmSaveChanges.Visible = false;
            this.button_FirmSaveChanges.Click += new System.EventHandler(this.button_FirmSaveEdit_Click);
            // 
            // tabPage_Employees
            // 
            this.tabPage_Employees.Controls.Add(this.button_Clear);
            this.tabPage_Employees.Controls.Add(this.button_EmployeeRemove);
            this.tabPage_Employees.Controls.Add(this.button_EmployeeEdit);
            this.tabPage_Employees.Controls.Add(this.button_EmployeeAdd);
            this.tabPage_Employees.Controls.Add(this.label_EmployeeBirthDate);
            this.tabPage_Employees.Controls.Add(this.label_EmployeeEmail);
            this.tabPage_Employees.Controls.Add(this.label_EmployeeCellPhone);
            this.tabPage_Employees.Controls.Add(this.label_EmployeePhone);
            this.tabPage_Employees.Controls.Add(this.label_EmployeeName);
            this.tabPage_Employees.Controls.Add(this.birthDatePicker);
            this.tabPage_Employees.Controls.Add(this.textBox_EmployeeEmail);
            this.tabPage_Employees.Controls.Add(this.textBox_EmployeeCellPhone);
            this.tabPage_Employees.Controls.Add(this.textBox_EmployeePhone);
            this.tabPage_Employees.Controls.Add(this.textBoxEmployeeName);
            this.tabPage_Employees.Controls.Add(this.label_EmployeeForename);
            this.tabPage_Employees.Controls.Add(this.textBox_EmployeeForename);
            this.tabPage_Employees.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Employees.Name = "tabPage_Employees";
            this.tabPage_Employees.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Employees.Size = new System.Drawing.Size(231, 290);
            this.tabPage_Employees.TabIndex = 1;
            this.tabPage_Employees.Text = "Employees";
            this.tabPage_Employees.UseVisualStyleBackColor = true;
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(170, 197);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(46, 39);
            this.button_Clear.TabIndex = 17;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_EmployeeRemove
            // 
            this.button_EmployeeRemove.Location = new System.Drawing.Point(136, 245);
            this.button_EmployeeRemove.Name = "button_EmployeeRemove";
            this.button_EmployeeRemove.Size = new System.Drawing.Size(56, 27);
            this.button_EmployeeRemove.TabIndex = 16;
            this.button_EmployeeRemove.Text = "Remove";
            this.button_EmployeeRemove.UseVisualStyleBackColor = true;
            this.button_EmployeeRemove.Click += new System.EventHandler(this.button_EmployeeRemove_Click);
            // 
            // button_EmployeeEdit
            // 
            this.button_EmployeeEdit.Location = new System.Drawing.Point(70, 245);
            this.button_EmployeeEdit.Name = "button_EmployeeEdit";
            this.button_EmployeeEdit.Size = new System.Drawing.Size(56, 27);
            this.button_EmployeeEdit.TabIndex = 15;
            this.button_EmployeeEdit.Text = "Edit";
            this.button_EmployeeEdit.UseVisualStyleBackColor = true;
            this.button_EmployeeEdit.Click += new System.EventHandler(this.button_EmployeeEdit_Click);
            // 
            // button_EmployeeAdd
            // 
            this.button_EmployeeAdd.Location = new System.Drawing.Point(8, 245);
            this.button_EmployeeAdd.Name = "button_EmployeeAdd";
            this.button_EmployeeAdd.Size = new System.Drawing.Size(56, 27);
            this.button_EmployeeAdd.TabIndex = 14;
            this.button_EmployeeAdd.Text = "Add";
            this.button_EmployeeAdd.UseVisualStyleBackColor = true;
            this.button_EmployeeAdd.Click += new System.EventHandler(this.button_EmployeeAdd_Click);
            // 
            // label_EmployeeBirthDate
            // 
            this.label_EmployeeBirthDate.AutoSize = true;
            this.label_EmployeeBirthDate.Location = new System.Drawing.Point(6, 203);
            this.label_EmployeeBirthDate.Name = "label_EmployeeBirthDate";
            this.label_EmployeeBirthDate.Size = new System.Drawing.Size(55, 13);
            this.label_EmployeeBirthDate.TabIndex = 13;
            this.label_EmployeeBirthDate.Text = "Birth date:";
            // 
            // label_EmployeeEmail
            // 
            this.label_EmployeeEmail.AutoSize = true;
            this.label_EmployeeEmail.Location = new System.Drawing.Point(6, 163);
            this.label_EmployeeEmail.Name = "label_EmployeeEmail";
            this.label_EmployeeEmail.Size = new System.Drawing.Size(35, 13);
            this.label_EmployeeEmail.TabIndex = 12;
            this.label_EmployeeEmail.Text = "E-mail";
            // 
            // label_EmployeeCellPhone
            // 
            this.label_EmployeeCellPhone.AutoSize = true;
            this.label_EmployeeCellPhone.Location = new System.Drawing.Point(6, 127);
            this.label_EmployeeCellPhone.Name = "label_EmployeeCellPhone";
            this.label_EmployeeCellPhone.Size = new System.Drawing.Size(58, 13);
            this.label_EmployeeCellPhone.TabIndex = 11;
            this.label_EmployeeCellPhone.Text = "Cell Phone";
            // 
            // label_EmployeePhone
            // 
            this.label_EmployeePhone.AutoSize = true;
            this.label_EmployeePhone.Location = new System.Drawing.Point(6, 92);
            this.label_EmployeePhone.Name = "label_EmployeePhone";
            this.label_EmployeePhone.Size = new System.Drawing.Size(38, 13);
            this.label_EmployeePhone.TabIndex = 10;
            this.label_EmployeePhone.Text = "Phone";
            // 
            // label_EmployeeName
            // 
            this.label_EmployeeName.AutoSize = true;
            this.label_EmployeeName.Location = new System.Drawing.Point(8, 57);
            this.label_EmployeeName.Name = "label_EmployeeName";
            this.label_EmployeeName.Size = new System.Drawing.Size(35, 13);
            this.label_EmployeeName.TabIndex = 9;
            this.label_EmployeeName.Text = "Name";
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.CustomFormat = "dd-MM-yyyy";
            this.birthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDatePicker.ImeMode = System.Windows.Forms.ImeMode.On;
            this.birthDatePicker.Location = new System.Drawing.Point(64, 204);
            this.birthDatePicker.MaxDate = new System.DateTime(4000, 12, 31, 0, 0, 0, 0);
            this.birthDatePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(93, 20);
            this.birthDatePicker.TabIndex = 8;
            this.birthDatePicker.Value = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            // 
            // textBox_EmployeeEmail
            // 
            this.textBox_EmployeeEmail.Location = new System.Drawing.Point(64, 160);
            this.textBox_EmployeeEmail.Name = "textBox_EmployeeEmail";
            this.textBox_EmployeeEmail.Size = new System.Drawing.Size(152, 20);
            this.textBox_EmployeeEmail.TabIndex = 6;
            // 
            // textBox_EmployeeCellPhone
            // 
            this.textBox_EmployeeCellPhone.Location = new System.Drawing.Point(64, 124);
            this.textBox_EmployeeCellPhone.Name = "textBox_EmployeeCellPhone";
            this.textBox_EmployeeCellPhone.Size = new System.Drawing.Size(152, 20);
            this.textBox_EmployeeCellPhone.TabIndex = 5;
            // 
            // textBox_EmployeePhone
            // 
            this.textBox_EmployeePhone.Location = new System.Drawing.Point(64, 89);
            this.textBox_EmployeePhone.Name = "textBox_EmployeePhone";
            this.textBox_EmployeePhone.Size = new System.Drawing.Size(152, 20);
            this.textBox_EmployeePhone.TabIndex = 4;
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Location = new System.Drawing.Point(64, 54);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.Size = new System.Drawing.Size(152, 20);
            this.textBoxEmployeeName.TabIndex = 3;
            // 
            // label_EmployeeForename
            // 
            this.label_EmployeeForename.AutoSize = true;
            this.label_EmployeeForename.Location = new System.Drawing.Point(6, 22);
            this.label_EmployeeForename.Name = "label_EmployeeForename";
            this.label_EmployeeForename.Size = new System.Drawing.Size(54, 13);
            this.label_EmployeeForename.TabIndex = 2;
            this.label_EmployeeForename.Text = "Forename";
            // 
            // textBox_EmployeeForename
            // 
            this.textBox_EmployeeForename.Location = new System.Drawing.Point(64, 19);
            this.textBox_EmployeeForename.Name = "textBox_EmployeeForename";
            this.textBox_EmployeeForename.Size = new System.Drawing.Size(152, 20);
            this.textBox_EmployeeForename.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_SearchAction);
            this.tabPage1.Controls.Add(this.label_SearchFirmName);
            this.tabPage1.Controls.Add(this.label_SearchEmail);
            this.tabPage1.Controls.Add(this.label_SearchForename);
            this.tabPage1.Controls.Add(this.textBox_SearchFirmName);
            this.tabPage1.Controls.Add(this.textBox_SearchEmail);
            this.tabPage1.Controls.Add(this.textBox_SearchForename);
            this.tabPage1.Controls.Add(this.textBox_SearchName);
            this.tabPage1.Controls.Add(this.label_SearchName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(231, 290);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label_SearchName
            // 
            this.label_SearchName.AutoSize = true;
            this.label_SearchName.Location = new System.Drawing.Point(22, 20);
            this.label_SearchName.Name = "label_SearchName";
            this.label_SearchName.Size = new System.Drawing.Size(38, 13);
            this.label_SearchName.TabIndex = 0;
            this.label_SearchName.Text = "Name:";
            // 
            // textBox_SearchName
            // 
            this.textBox_SearchName.Location = new System.Drawing.Point(91, 13);
            this.textBox_SearchName.Name = "textBox_SearchName";
            this.textBox_SearchName.Size = new System.Drawing.Size(128, 20);
            this.textBox_SearchName.TabIndex = 1;
            // 
            // textBox_SearchForename
            // 
            this.textBox_SearchForename.Location = new System.Drawing.Point(91, 48);
            this.textBox_SearchForename.Name = "textBox_SearchForename";
            this.textBox_SearchForename.Size = new System.Drawing.Size(128, 20);
            this.textBox_SearchForename.TabIndex = 2;
            // 
            // textBox_SearchEmail
            // 
            this.textBox_SearchEmail.Location = new System.Drawing.Point(91, 83);
            this.textBox_SearchEmail.Name = "textBox_SearchEmail";
            this.textBox_SearchEmail.Size = new System.Drawing.Size(128, 20);
            this.textBox_SearchEmail.TabIndex = 3;
            // 
            // textBox_SearchFirmName
            // 
            this.textBox_SearchFirmName.Location = new System.Drawing.Point(91, 118);
            this.textBox_SearchFirmName.Name = "textBox_SearchFirmName";
            this.textBox_SearchFirmName.Size = new System.Drawing.Size(128, 20);
            this.textBox_SearchFirmName.TabIndex = 4;
            // 
            // label_SearchForename
            // 
            this.label_SearchForename.AutoSize = true;
            this.label_SearchForename.Location = new System.Drawing.Point(22, 51);
            this.label_SearchForename.Name = "label_SearchForename";
            this.label_SearchForename.Size = new System.Drawing.Size(57, 13);
            this.label_SearchForename.TabIndex = 5;
            this.label_SearchForename.Text = "Forename:";
            // 
            // label_SearchEmail
            // 
            this.label_SearchEmail.AutoSize = true;
            this.label_SearchEmail.Location = new System.Drawing.Point(22, 86);
            this.label_SearchEmail.Name = "label_SearchEmail";
            this.label_SearchEmail.Size = new System.Drawing.Size(35, 13);
            this.label_SearchEmail.TabIndex = 6;
            this.label_SearchEmail.Text = "Email:";
            // 
            // label_SearchFirmName
            // 
            this.label_SearchFirmName.AutoSize = true;
            this.label_SearchFirmName.Location = new System.Drawing.Point(22, 121);
            this.label_SearchFirmName.Name = "label_SearchFirmName";
            this.label_SearchFirmName.Size = new System.Drawing.Size(60, 13);
            this.label_SearchFirmName.TabIndex = 7;
            this.label_SearchFirmName.Text = "Firm Name:";
            // 
            // button_SearchAction
            // 
            this.button_SearchAction.Location = new System.Drawing.Point(144, 158);
            this.button_SearchAction.Name = "button_SearchAction";
            this.button_SearchAction.Size = new System.Drawing.Size(75, 23);
            this.button_SearchAction.TabIndex = 8;
            this.button_SearchAction.Text = "Search";
            this.button_SearchAction.UseVisualStyleBackColor = true;
            this.button_SearchAction.Click += new System.EventHandler(this.button_SearchAction_Click);
            // 
            // bithDateDataGridViewTextBoxColumn
            // 
            this.bithDateDataGridViewTextBoxColumn.DataPropertyName = "BithDate";
            this.bithDateDataGridViewTextBoxColumn.HeaderText = "BithDate";
            this.bithDateDataGridViewTextBoxColumn.Name = "bithDateDataGridViewTextBoxColumn";
            this.bithDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cellPhoneDataGridViewTextBoxColumn
            // 
            this.cellPhoneDataGridViewTextBoxColumn.DataPropertyName = "CellPhone";
            this.cellPhoneDataGridViewTextBoxColumn.HeaderText = "CellPhone";
            this.cellPhoneDataGridViewTextBoxColumn.Name = "cellPhoneDataGridViewTextBoxColumn";
            this.cellPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // forenameDataGridViewTextBoxColumn
            // 
            this.forenameDataGridViewTextBoxColumn.DataPropertyName = "Forename";
            this.forenameDataGridViewTextBoxColumn.HeaderText = "Forename";
            this.forenameDataGridViewTextBoxColumn.Name = "forenameDataGridViewTextBoxColumn";
            this.forenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personIdDataGridViewTextBoxColumn
            // 
            this.personIdDataGridViewTextBoxColumn.DataPropertyName = "PersonId";
            this.personIdDataGridViewTextBoxColumn.HeaderText = "PersonId";
            this.personIdDataGridViewTextBoxColumn.Name = "personIdDataGridViewTextBoxColumn";
            this.personIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.personIdDataGridViewTextBoxColumn.Width = 40;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(BusinessCardHolder.Entities.Person);
            // 
            // FirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 461);
            this.Controls.Add(this.tabControl_Firm);
            this.Controls.Add(this.button_AddEmployee);
            this.Controls.Add(this.dataGridView_EmployeesTable);
            this.Name = "FirmForm";
            this.Text = "FirmForm";
            this.Load += new System.EventHandler(this.FirmForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EmployeesTable)).EndInit();
            this.contextMenuStrip_InTable.ResumeLayout(false);
            this.tabControl_Firm.ResumeLayout(false);
            this.tabPage_Firm.ResumeLayout(false);
            this.tabPage_Firm.PerformLayout();
            this.tabPage_Employees.ResumeLayout(false);
            this.tabPage_Employees.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_FirmName;
        private System.Windows.Forms.TextBox textBox_FirmName;
        private System.Windows.Forms.Label label_FirmZip;
        private System.Windows.Forms.Label label_FirmStreet;
        private System.Windows.Forms.Label label_FirmCity;
        private System.Windows.Forms.TextBox textBox_FirmZip;
        private System.Windows.Forms.TextBox textBox_FirmNumber;
        private System.Windows.Forms.TextBox textBox_FirmStreet;
        private System.Windows.Forms.TextBox textBox_FirmCity;
        private System.Windows.Forms.DataGridView dataGridView_EmployeesTable;
        private System.Windows.Forms.Button button_AddEmployee;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_InTable;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem texyToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl_Firm;
        private System.Windows.Forms.TabPage tabPage_Firm;
        private System.Windows.Forms.TabPage tabPage_Employees;
        private System.Windows.Forms.Button button_FirmSaveChanges;
        private System.Windows.Forms.Button button_FirmEdit;
        private System.Windows.Forms.Button button_FirmCancel;
        private System.Windows.Forms.TextBox textBox_EmployeeCellPhone;
        private System.Windows.Forms.TextBox textBox_EmployeePhone;
        private System.Windows.Forms.TextBox textBoxEmployeeName;
        private System.Windows.Forms.Label label_EmployeeForename;
        private System.Windows.Forms.TextBox textBox_EmployeeForename;
        private System.Windows.Forms.DateTimePicker birthDatePicker;
        private System.Windows.Forms.TextBox textBox_EmployeeEmail;
        private System.Windows.Forms.Label label_EmployeeBirthDate;
        private System.Windows.Forms.Label label_EmployeeEmail;
        private System.Windows.Forms.Label label_EmployeeCellPhone;
        private System.Windows.Forms.Label label_EmployeePhone;
        private System.Windows.Forms.Label label_EmployeeName;
        private System.Windows.Forms.Button button_EmployeeRemove;
        private System.Windows.Forms.Button button_EmployeeEdit;
        private System.Windows.Forms.Button button_EmployeeAdd;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label_SearchFirmName;
        private System.Windows.Forms.Label label_SearchEmail;
        private System.Windows.Forms.Label label_SearchForename;
        private System.Windows.Forms.TextBox textBox_SearchFirmName;
        private System.Windows.Forms.TextBox textBox_SearchEmail;
        private System.Windows.Forms.TextBox textBox_SearchForename;
        private System.Windows.Forms.TextBox textBox_SearchName;
        private System.Windows.Forms.Label label_SearchName;
        private System.Windows.Forms.Button button_SearchAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn forenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bithDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource personBindingSource;
    }
}