namespace time_sheet.Forms.Employee_Editing
{
    partial class EmployeeDetailsForm
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
            nameEmployee_textbox = new TextBox();
            secondnameEmployee_textbox = new TextBox();
            surnameEmployee_textbox = new TextBox();
            residenceAddressEmployee_textbox = new TextBox();
            positionEmployee_textbox = new TextBox();
            saveEmployeeButton = new Button();
            label1 = new Label();
            dateOfBirth_monthCalendar = new MonthCalendar();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            departamentEmployee_comboBox = new ComboBox();
            createEmployee_groupbox = new GroupBox();
            noFillWeekdays_radiobutton = new RadioButton();
            setRandomTurnoutToWork_radioButton = new RadioButton();
            allWeekdaysWorked_radioButton = new RadioButton();
            employeeDetails_lable = new Label();
            createEmployee_groupbox.SuspendLayout();
            SuspendLayout();
            // 
            // nameEmployee_textbox
            // 
            nameEmployee_textbox.Location = new Point(6, 90);
            nameEmployee_textbox.Name = "nameEmployee_textbox";
            nameEmployee_textbox.Size = new Size(256, 23);
            nameEmployee_textbox.TabIndex = 0;
            // 
            // secondnameEmployee_textbox
            // 
            secondnameEmployee_textbox.Location = new Point(6, 152);
            secondnameEmployee_textbox.Name = "secondnameEmployee_textbox";
            secondnameEmployee_textbox.Size = new Size(256, 23);
            secondnameEmployee_textbox.TabIndex = 1;
            // 
            // surnameEmployee_textbox
            // 
            surnameEmployee_textbox.Location = new Point(6, 210);
            surnameEmployee_textbox.Name = "surnameEmployee_textbox";
            surnameEmployee_textbox.Size = new Size(256, 23);
            surnameEmployee_textbox.TabIndex = 2;
            // 
            // residenceAddressEmployee_textbox
            // 
            residenceAddressEmployee_textbox.Location = new Point(295, 90);
            residenceAddressEmployee_textbox.Name = "residenceAddressEmployee_textbox";
            residenceAddressEmployee_textbox.Size = new Size(247, 23);
            residenceAddressEmployee_textbox.TabIndex = 4;
            // 
            // positionEmployee_textbox
            // 
            positionEmployee_textbox.Location = new Point(6, 328);
            positionEmployee_textbox.Name = "positionEmployee_textbox";
            positionEmployee_textbox.Size = new Size(256, 23);
            positionEmployee_textbox.TabIndex = 6;
            // 
            // saveEmployeeButton
            // 
            saveEmployeeButton.Location = new Point(273, 370);
            saveEmployeeButton.Name = "saveEmployeeButton";
            saveEmployeeButton.Size = new Size(75, 23);
            saveEmployeeButton.TabIndex = 7;
            saveEmployeeButton.Text = "Сохранить";
            saveEmployeeButton.UseVisualStyleBackColor = true;
            saveEmployeeButton.Click += saveEmployeeButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 72);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 8;
            label1.Text = "Имя";
            // 
            // dateOfBirth_monthCalendar
            // 
            dateOfBirth_monthCalendar.Location = new Point(295, 163);
            dateOfBirth_monthCalendar.Name = "dateOfBirth_monthCalendar";
            dateOfBirth_monthCalendar.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 134);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 10;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 192);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 11;
            label3.Text = "Отчество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 254);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 12;
            label4.Text = "Департамент";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 310);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 13;
            label5.Text = "Должность";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(295, 72);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 14;
            label6.Text = "Адрес";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(295, 134);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 15;
            label7.Text = "Дата рождения";
            // 
            // departamentEmployee_comboBox
            // 
            departamentEmployee_comboBox.FormattingEnabled = true;
            departamentEmployee_comboBox.Location = new Point(6, 272);
            departamentEmployee_comboBox.Name = "departamentEmployee_comboBox";
            departamentEmployee_comboBox.Size = new Size(256, 23);
            departamentEmployee_comboBox.TabIndex = 16;
            // 
            // createEmployee_groupbox
            // 
            createEmployee_groupbox.Controls.Add(noFillWeekdays_radiobutton);
            createEmployee_groupbox.Controls.Add(setRandomTurnoutToWork_radioButton);
            createEmployee_groupbox.Controls.Add(allWeekdaysWorked_radioButton);
            createEmployee_groupbox.Location = new Point(471, 163);
            createEmployee_groupbox.Name = "createEmployee_groupbox";
            createEmployee_groupbox.Size = new Size(149, 162);
            createEmployee_groupbox.TabIndex = 17;
            createEmployee_groupbox.TabStop = false;
            createEmployee_groupbox.Text = "Тип заполнения года";
            // 
            // noFillWeekdays_radiobutton
            // 
            noFillWeekdays_radiobutton.AutoSize = true;
            noFillWeekdays_radiobutton.Location = new Point(6, 137);
            noFillWeekdays_radiobutton.Name = "noFillWeekdays_radiobutton";
            noFillWeekdays_radiobutton.Size = new Size(135, 19);
            noFillWeekdays_radiobutton.TabIndex = 2;
            noFillWeekdays_radiobutton.TabStop = true;
            noFillWeekdays_radiobutton.Text = "Не заполнять будни\r\n";
            noFillWeekdays_radiobutton.UseVisualStyleBackColor = true;
            // 
            // setRandomTurnoutToWork_radioButton
            // 
            setRandomTurnoutToWork_radioButton.AutoSize = true;
            setRandomTurnoutToWork_radioButton.Location = new Point(6, 77);
            setRandomTurnoutToWork_radioButton.Name = "setRandomTurnoutToWork_radioButton";
            setRandomTurnoutToWork_radioButton.Size = new Size(142, 49);
            setRandomTurnoutToWork_radioButton.TabIndex = 1;
            setRandomTurnoutToWork_radioButton.TabStop = true;
            setRandomTurnoutToWork_radioButton.Text = "Случайное\r\nВсе будни будут\r\nзаполнены случайно\r\n";
            setRandomTurnoutToWork_radioButton.UseVisualStyleBackColor = true;
            // 
            // allWeekdaysWorked_radioButton
            // 
            allWeekdaysWorked_radioButton.AutoSize = true;
            allWeekdaysWorked_radioButton.Location = new Point(6, 22);
            allWeekdaysWorked_radioButton.Name = "allWeekdaysWorked_radioButton";
            allWeekdaysWorked_radioButton.Size = new Size(121, 49);
            allWeekdaysWorked_radioButton.TabIndex = 0;
            allWeekdaysWorked_radioButton.TabStop = true;
            allWeekdaysWorked_radioButton.Text = "\"Идеальное\"\r\nВсе будни будут\r\nзаполнены явкой\r\n";
            allWeekdaysWorked_radioButton.UseVisualStyleBackColor = true;
            // 
            // employeeDetails_lable
            // 
            employeeDetails_lable.AutoSize = true;
            employeeDetails_lable.Location = new Point(12, 24);
            employeeDetails_lable.Name = "employeeDetails_lable";
            employeeDetails_lable.Size = new Size(25, 15);
            employeeDetails_lable.TabIndex = 18;
            employeeDetails_lable.Text = "123";
            // 
            // EmployeeDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 405);
            Controls.Add(employeeDetails_lable);
            Controls.Add(createEmployee_groupbox);
            Controls.Add(departamentEmployee_comboBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateOfBirth_monthCalendar);
            Controls.Add(label1);
            Controls.Add(saveEmployeeButton);
            Controls.Add(positionEmployee_textbox);
            Controls.Add(residenceAddressEmployee_textbox);
            Controls.Add(surnameEmployee_textbox);
            Controls.Add(secondnameEmployee_textbox);
            Controls.Add(nameEmployee_textbox);
            Name = "EmployeeDetailsForm";
            ShowIcon = false;
            Text = "Данные о работнике";
            FormClosed += EmployeeDetailsForm_FormClosed;
            Load += EmployeeDetailsForm_Load;
            createEmployee_groupbox.ResumeLayout(false);
            createEmployee_groupbox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameEmployee_textbox;
        private TextBox secondnameEmployee_textbox;
        private TextBox surnameEmployee_textbox;
        private TextBox residenceAddressEmployee_textbox;
        private TextBox positionEmployee_textbox;
        private Button saveEmployeeButton;
        private Label label1;
        private MonthCalendar dateOfBirth_monthCalendar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox departamentEmployee_comboBox;
        private GroupBox createEmployee_groupbox;
        private RadioButton setRandomTurnoutToWork_radioButton;
        private RadioButton allWeekdaysWorked_radioButton;
        private Label employeeDetails_lable;
        private RadioButton noFillWeekdays_radiobutton;
    }
}