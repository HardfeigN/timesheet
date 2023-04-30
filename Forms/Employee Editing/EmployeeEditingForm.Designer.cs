namespace time_sheet.Forms.Employee_Editing
{
    partial class EmployeeEditingForm
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
            Employee_DataGrinView = new DataGridView();
            EmployeeName = new DataGridViewTextBoxColumn();
            Secondname = new DataGridViewTextBoxColumn();
            SurName = new DataGridViewTextBoxColumn();
            Departament = new DataGridViewTextBoxColumn();
            DateOfBirth = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            ResidenceAddress = new DataGridViewTextBoxColumn();
            employeeid = new DataGridViewTextBoxColumn();
            AddEmployeeButton = new Button();
            EditEmployeeButton = new Button();
            DeleteEmployeeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)Employee_DataGrinView).BeginInit();
            SuspendLayout();
            // 
            // Employee_DataGrinView
            // 
            Employee_DataGrinView.AllowUserToAddRows = false;
            Employee_DataGrinView.AllowUserToDeleteRows = false;
            Employee_DataGrinView.AllowUserToOrderColumns = true;
            Employee_DataGrinView.BackgroundColor = SystemColors.ControlLight;
            Employee_DataGrinView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Employee_DataGrinView.Columns.AddRange(new DataGridViewColumn[] { EmployeeName, Secondname, SurName, Departament, DateOfBirth, Position, ResidenceAddress, employeeid });
            Employee_DataGrinView.Location = new Point(12, 83);
            Employee_DataGrinView.MultiSelect = false;
            Employee_DataGrinView.Name = "Employee_DataGrinView";
            Employee_DataGrinView.RowHeadersVisible = false;
            Employee_DataGrinView.RowTemplate.Height = 25;
            Employee_DataGrinView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Employee_DataGrinView.Size = new Size(1183, 505);
            Employee_DataGrinView.TabIndex = 0;
            // 
            // EmployeeName
            // 
            EmployeeName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EmployeeName.Frozen = true;
            EmployeeName.HeaderText = "Имя";
            EmployeeName.Name = "EmployeeName";
            EmployeeName.ReadOnly = true;
            EmployeeName.Resizable = DataGridViewTriState.True;
            EmployeeName.SortMode = DataGridViewColumnSortMode.NotSortable;
            EmployeeName.Width = 37;
            // 
            // Secondname
            // 
            Secondname.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Secondname.Frozen = true;
            Secondname.HeaderText = "Фамилия";
            Secondname.Name = "Secondname";
            Secondname.ReadOnly = true;
            Secondname.Resizable = DataGridViewTriState.True;
            Secondname.SortMode = DataGridViewColumnSortMode.NotSortable;
            Secondname.Width = 64;
            // 
            // SurName
            // 
            SurName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SurName.Frozen = true;
            SurName.HeaderText = "Отчество";
            SurName.Name = "SurName";
            SurName.ReadOnly = true;
            SurName.Width = 83;
            // 
            // Departament
            // 
            Departament.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Departament.Frozen = true;
            Departament.HeaderText = "Отдел";
            Departament.Name = "Departament";
            Departament.ReadOnly = true;
            Departament.Width = 65;
            // 
            // DateOfBirth
            // 
            DateOfBirth.Frozen = true;
            DateOfBirth.HeaderText = "Дата рождения";
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.ReadOnly = true;
            DateOfBirth.Width = 150;
            // 
            // Position
            // 
            Position.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Position.Frozen = true;
            Position.HeaderText = "Должность";
            Position.Name = "Position";
            Position.ReadOnly = true;
            Position.Width = 94;
            // 
            // ResidenceAddress
            // 
            ResidenceAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ResidenceAddress.Frozen = true;
            ResidenceAddress.HeaderText = "Адрес";
            ResidenceAddress.Name = "ResidenceAddress";
            ResidenceAddress.ReadOnly = true;
            ResidenceAddress.Width = 65;
            // 
            // employeeid
            // 
            employeeid.Frozen = true;
            employeeid.HeaderText = "id";
            employeeid.Name = "employeeid";
            employeeid.ReadOnly = true;
            employeeid.Visible = false;
            // 
            // AddEmployeeButton
            // 
            AddEmployeeButton.Location = new Point(22, 29);
            AddEmployeeButton.Name = "AddEmployeeButton";
            AddEmployeeButton.Size = new Size(75, 23);
            AddEmployeeButton.TabIndex = 1;
            AddEmployeeButton.Text = "Добавить";
            AddEmployeeButton.UseVisualStyleBackColor = true;
            AddEmployeeButton.Click += AddEmployeeButton_Click;
            // 
            // EditEmployeeButton
            // 
            EditEmployeeButton.Location = new Point(167, 29);
            EditEmployeeButton.Name = "EditEmployeeButton";
            EditEmployeeButton.Size = new Size(75, 23);
            EditEmployeeButton.TabIndex = 2;
            EditEmployeeButton.Text = "Изменить";
            EditEmployeeButton.UseVisualStyleBackColor = true;
            EditEmployeeButton.Click += EditEmployeeButton_Click;
            // 
            // DeleteEmployeeButton
            // 
            DeleteEmployeeButton.Location = new Point(313, 29);
            DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            DeleteEmployeeButton.Size = new Size(75, 23);
            DeleteEmployeeButton.TabIndex = 3;
            DeleteEmployeeButton.Text = "Удалить";
            DeleteEmployeeButton.UseVisualStyleBackColor = true;
            DeleteEmployeeButton.Click += DeleteEmployeeButton_Click;
            // 
            // EmployeeEditingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 600);
            Controls.Add(DeleteEmployeeButton);
            Controls.Add(EditEmployeeButton);
            Controls.Add(AddEmployeeButton);
            Controls.Add(Employee_DataGrinView);
            Name = "EmployeeEditingForm";
            ShowIcon = false;
            Text = "Редактирование сотрудников";
            FormClosed += EmployeeEditingForm_FormClosed;
            Load += EmployeeEditingForm_Load;
            VisibleChanged += EmployeeEditingForm_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)Employee_DataGrinView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Employee_DataGrinView;
        private Button AddEmployeeButton;
        private Button EditEmployeeButton;
        private Button DeleteEmployeeButton;
        private DataGridViewTextBoxColumn EmployeeName;
        private DataGridViewTextBoxColumn Secondname;
        private DataGridViewTextBoxColumn SurName;
        private DataGridViewTextBoxColumn Departament;
        private DataGridViewTextBoxColumn DateOfBirth;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn ResidenceAddress;
        private DataGridViewTextBoxColumn employeeid;
    }
}