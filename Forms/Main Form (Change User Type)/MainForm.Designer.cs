namespace time_sheet.Forms.Change_User_Type
{
    partial class MainForm
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
            openTimesheetButton = new Button();
            changeDataSourceString_checkbox = new CheckBox();
            dataSourceString_textbox = new TextBox();
            selectUserType_groupbox = new GroupBox();
            employeeDirectoryAdministrator_radioButton = new RadioButton();
            departmentDirectoryAdministrator_radioButton = new RadioButton();
            timekeeper_radioButton = new RadioButton();
            selectUserType_groupbox.SuspendLayout();
            SuspendLayout();
            // 
            // openTimesheetButton
            // 
            openTimesheetButton.Location = new Point(326, 386);
            openTimesheetButton.Name = "openTimesheetButton";
            openTimesheetButton.Size = new Size(137, 23);
            openTimesheetButton.TabIndex = 0;
            openTimesheetButton.Text = "открыть журнал";
            openTimesheetButton.UseVisualStyleBackColor = true;
            openTimesheetButton.Click += openTimesheetButton_Click;
            // 
            // changeDataSourceString_checkbox
            // 
            changeDataSourceString_checkbox.AutoSize = true;
            changeDataSourceString_checkbox.Checked = true;
            changeDataSourceString_checkbox.CheckState = CheckState.Checked;
            changeDataSourceString_checkbox.Location = new Point(12, 230);
            changeDataSourceString_checkbox.Name = "changeDataSourceString_checkbox";
            changeDataSourceString_checkbox.Size = new Size(199, 19);
            changeDataSourceString_checkbox.TabIndex = 1;
            changeDataSourceString_checkbox.Text = "Изменить строку подключения";
            changeDataSourceString_checkbox.UseVisualStyleBackColor = true;
            changeDataSourceString_checkbox.CheckedChanged += changeDataSourceString_checkbox_CheckedChanged;
            // 
            // dataSourceString_textbox
            // 
            dataSourceString_textbox.Location = new Point(12, 274);
            dataSourceString_textbox.Multiline = true;
            dataSourceString_textbox.Name = "dataSourceString_textbox";
            dataSourceString_textbox.Size = new Size(776, 85);
            dataSourceString_textbox.TabIndex = 2;
            // 
            // selectUserType_groupbox
            // 
            selectUserType_groupbox.Controls.Add(employeeDirectoryAdministrator_radioButton);
            selectUserType_groupbox.Controls.Add(departmentDirectoryAdministrator_radioButton);
            selectUserType_groupbox.Controls.Add(timekeeper_radioButton);
            selectUserType_groupbox.Location = new Point(198, 24);
            selectUserType_groupbox.Name = "selectUserType_groupbox";
            selectUserType_groupbox.Size = new Size(391, 181);
            selectUserType_groupbox.TabIndex = 3;
            selectUserType_groupbox.TabStop = false;
            selectUserType_groupbox.Text = "Выберите тип пользователя";
            // 
            // employeeDirectoryAdministrator_radioButton
            // 
            employeeDirectoryAdministrator_radioButton.AutoSize = true;
            employeeDirectoryAdministrator_radioButton.Location = new Point(20, 135);
            employeeDirectoryAdministrator_radioButton.Name = "employeeDirectoryAdministrator_radioButton";
            employeeDirectoryAdministrator_radioButton.Size = new Size(255, 19);
            employeeDirectoryAdministrator_radioButton.TabIndex = 2;
            employeeDirectoryAdministrator_radioButton.TabStop = true;
            employeeDirectoryAdministrator_radioButton.Text = "Администратор справочника работников";
            employeeDirectoryAdministrator_radioButton.UseVisualStyleBackColor = true;
            employeeDirectoryAdministrator_radioButton.CheckedChanged += employeeDirectoryAdministrator_radioButton_CheckedChanged;
            // 
            // departmentDirectoryAdministrator_radioButton
            // 
            departmentDirectoryAdministrator_radioButton.AutoSize = true;
            departmentDirectoryAdministrator_radioButton.Location = new Point(20, 82);
            departmentDirectoryAdministrator_radioButton.Name = "departmentDirectoryAdministrator_radioButton";
            departmentDirectoryAdministrator_radioButton.Size = new Size(273, 19);
            departmentDirectoryAdministrator_radioButton.TabIndex = 1;
            departmentDirectoryAdministrator_radioButton.TabStop = true;
            departmentDirectoryAdministrator_radioButton.Text = "Администратор справочника департаментов";
            departmentDirectoryAdministrator_radioButton.UseVisualStyleBackColor = true;
            departmentDirectoryAdministrator_radioButton.CheckedChanged += departmentDirectoryAdministrator_radioButton_CheckedChanged;
            // 
            // timekeeper_radioButton
            // 
            timekeeper_radioButton.AutoSize = true;
            timekeeper_radioButton.Location = new Point(20, 32);
            timekeeper_radioButton.Name = "timekeeper_radioButton";
            timekeeper_radioButton.Size = new Size(87, 19);
            timekeeper_radioButton.TabIndex = 0;
            timekeeper_radioButton.TabStop = true;
            timekeeper_radioButton.Text = "Табельщик";
            timekeeper_radioButton.UseVisualStyleBackColor = true;
            timekeeper_radioButton.CheckedChanged += timekeeper_radioButton_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(selectUserType_groupbox);
            Controls.Add(dataSourceString_textbox);
            Controls.Add(changeDataSourceString_checkbox);
            Controls.Add(openTimesheetButton);
            Name = "MainForm";
            ShowIcon = false;
            Text = "Меню";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            selectUserType_groupbox.ResumeLayout(false);
            selectUserType_groupbox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button openTimesheetButton;
        private CheckBox changeDataSourceString_checkbox;
        private TextBox dataSourceString_textbox;
        private GroupBox selectUserType_groupbox;
        private RadioButton employeeDirectoryAdministrator_radioButton;
        private RadioButton departmentDirectoryAdministrator_radioButton;
        private RadioButton timekeeper_radioButton;
    }
}