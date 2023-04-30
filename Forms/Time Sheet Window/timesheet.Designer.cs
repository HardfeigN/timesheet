namespace time_sheet
{
    partial class timesheet
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            timesheet_splitcontainer = new SplitContainer();
            changeUserTypeButton = new Button();
            departaments_listbox = new ListBox();
            selectedYear_label = new Label();
            selectedYear_combobox = new ComboBox();
            yearViewTabControl = new TabControl();
            january_page = new TabPage();
            month_dataGridView = new DataGridView();
            cellMarkChange_contextMenuStrip = new ContextMenuStrip(components);
            february_page = new TabPage();
            march_page = new TabPage();
            april_page = new TabPage();
            may_page = new TabPage();
            june_page = new TabPage();
            jule_page = new TabPage();
            august_page = new TabPage();
            september_page = new TabPage();
            october_page = new TabPage();
            november_page = new TabPage();
            december_page = new TabPage();
            FIO = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            EmployeeId = new DataGridViewTextBoxColumn();
            day1 = new DataGridViewTextBoxColumn();
            day2 = new DataGridViewTextBoxColumn();
            day3 = new DataGridViewTextBoxColumn();
            day4 = new DataGridViewTextBoxColumn();
            day5 = new DataGridViewTextBoxColumn();
            day6 = new DataGridViewTextBoxColumn();
            day7 = new DataGridViewTextBoxColumn();
            day8 = new DataGridViewTextBoxColumn();
            day9 = new DataGridViewTextBoxColumn();
            day10 = new DataGridViewTextBoxColumn();
            day11 = new DataGridViewTextBoxColumn();
            day12 = new DataGridViewTextBoxColumn();
            day13 = new DataGridViewTextBoxColumn();
            day14 = new DataGridViewTextBoxColumn();
            day15 = new DataGridViewTextBoxColumn();
            day16 = new DataGridViewTextBoxColumn();
            day17 = new DataGridViewTextBoxColumn();
            day18 = new DataGridViewTextBoxColumn();
            day19 = new DataGridViewTextBoxColumn();
            day20 = new DataGridViewTextBoxColumn();
            day21 = new DataGridViewTextBoxColumn();
            day22 = new DataGridViewTextBoxColumn();
            day23 = new DataGridViewTextBoxColumn();
            day24 = new DataGridViewTextBoxColumn();
            day25 = new DataGridViewTextBoxColumn();
            day26 = new DataGridViewTextBoxColumn();
            day27 = new DataGridViewTextBoxColumn();
            day28 = new DataGridViewTextBoxColumn();
            day29 = new DataGridViewTextBoxColumn();
            day30 = new DataGridViewTextBoxColumn();
            day31 = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)timesheet_splitcontainer).BeginInit();
            timesheet_splitcontainer.Panel1.SuspendLayout();
            timesheet_splitcontainer.Panel2.SuspendLayout();
            timesheet_splitcontainer.SuspendLayout();
            yearViewTabControl.SuspendLayout();
            january_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)month_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // timesheet_splitcontainer
            // 
            timesheet_splitcontainer.Dock = DockStyle.Fill;
            timesheet_splitcontainer.Location = new Point(0, 0);
            timesheet_splitcontainer.Name = "timesheet_splitcontainer";
            // 
            // timesheet_splitcontainer.Panel1
            // 
            timesheet_splitcontainer.Panel1.Controls.Add(changeUserTypeButton);
            timesheet_splitcontainer.Panel1.Controls.Add(departaments_listbox);
            // 
            // timesheet_splitcontainer.Panel2
            // 
            timesheet_splitcontainer.Panel2.Controls.Add(selectedYear_label);
            timesheet_splitcontainer.Panel2.Controls.Add(selectedYear_combobox);
            timesheet_splitcontainer.Panel2.Controls.Add(yearViewTabControl);
            timesheet_splitcontainer.Size = new Size(1434, 686);
            timesheet_splitcontainer.SplitterDistance = 281;
            timesheet_splitcontainer.TabIndex = 0;
            // 
            // changeUserTypeButton
            // 
            changeUserTypeButton.Dock = DockStyle.Top;
            changeUserTypeButton.Location = new Point(0, 0);
            changeUserTypeButton.Name = "changeUserTypeButton";
            changeUserTypeButton.Size = new Size(281, 46);
            changeUserTypeButton.TabIndex = 1;
            changeUserTypeButton.Text = "Смена пользователя";
            changeUserTypeButton.UseVisualStyleBackColor = true;
            changeUserTypeButton.Click += changeUserTypeButton_Click;
            // 
            // departaments_listbox
            // 
            departaments_listbox.BackColor = SystemColors.InactiveCaption;
            departaments_listbox.Dock = DockStyle.Bottom;
            departaments_listbox.FormattingEnabled = true;
            departaments_listbox.ItemHeight = 15;
            departaments_listbox.Location = new Point(0, 52);
            departaments_listbox.Name = "departaments_listbox";
            departaments_listbox.Size = new Size(281, 634);
            departaments_listbox.TabIndex = 0;
            departaments_listbox.SelectedIndexChanged += departaments_listbox_SelectedIndexChanged;
            departaments_listbox.DoubleClick += departaments_listbox_DoubleClick;
            // 
            // selectedYear_label
            // 
            selectedYear_label.AutoSize = true;
            selectedYear_label.Location = new Point(916, 15);
            selectedYear_label.Name = "selectedYear_label";
            selectedYear_label.Size = new Size(97, 15);
            selectedYear_label.TabIndex = 2;
            selectedYear_label.Text = "Выбранный год:";
            // 
            // selectedYear_combobox
            // 
            selectedYear_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            selectedYear_combobox.Location = new Point(1016, 12);
            selectedYear_combobox.Name = "selectedYear_combobox";
            selectedYear_combobox.Size = new Size(121, 23);
            selectedYear_combobox.TabIndex = 1;
            selectedYear_combobox.SelectedIndexChanged += selectedYear_combobox_SelectedIndexChanged;
            // 
            // yearViewTabControl
            // 
            yearViewTabControl.Controls.Add(january_page);
            yearViewTabControl.Controls.Add(february_page);
            yearViewTabControl.Controls.Add(march_page);
            yearViewTabControl.Controls.Add(april_page);
            yearViewTabControl.Controls.Add(may_page);
            yearViewTabControl.Controls.Add(june_page);
            yearViewTabControl.Controls.Add(jule_page);
            yearViewTabControl.Controls.Add(august_page);
            yearViewTabControl.Controls.Add(september_page);
            yearViewTabControl.Controls.Add(october_page);
            yearViewTabControl.Controls.Add(november_page);
            yearViewTabControl.Controls.Add(december_page);
            yearViewTabControl.Dock = DockStyle.Bottom;
            yearViewTabControl.Location = new Point(0, 29);
            yearViewTabControl.Name = "yearViewTabControl";
            yearViewTabControl.SelectedIndex = 0;
            yearViewTabControl.Size = new Size(1149, 657);
            yearViewTabControl.TabIndex = 0;
            yearViewTabControl.SelectedIndexChanged += yearViewTabControl_SelectedIndexChanged;
            // 
            // january_page
            // 
            january_page.Controls.Add(month_dataGridView);
            january_page.Location = new Point(4, 24);
            january_page.Name = "january_page";
            january_page.Padding = new Padding(3);
            january_page.Size = new Size(1141, 629);
            january_page.TabIndex = 0;
            january_page.Text = "Январь";
            january_page.UseVisualStyleBackColor = true;
            // 
            // month_dataGridView
            // 
            month_dataGridView.AllowUserToAddRows = false;
            month_dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridViewCellStyle1.ForeColor = Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = Color.Aquamarine;
            month_dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            month_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            month_dataGridView.BorderStyle = BorderStyle.None;
            month_dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            month_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            month_dataGridView.Columns.AddRange(new DataGridViewColumn[] { FIO, Position, EmployeeId, day1, day2, day3, day4, day5, day6, day7, day8, day9, day10, day11, day12, day13, day14, day15, day16, day17, day18, day19, day20, day21, day22, day23, day24, day25, day26, day27, day28, day29, day30, day31, total });
            month_dataGridView.ContextMenuStrip = cellMarkChange_contextMenuStrip;
            month_dataGridView.Dock = DockStyle.Fill;
            month_dataGridView.Location = new Point(3, 3);
            month_dataGridView.MultiSelect = false;
            month_dataGridView.Name = "month_dataGridView";
            month_dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            month_dataGridView.RowHeadersVisible = false;
            month_dataGridView.RowTemplate.Height = 25;
            month_dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            month_dataGridView.Size = new Size(1135, 623);
            month_dataGridView.TabIndex = 0;
            month_dataGridView.CellMouseDoubleClick += month_dataGridView_CellMouseDoubleClick;
            month_dataGridView.MouseDown += month_dataGridView_MouseDown;
            // 
            // cellMarkChange_contextMenuStrip
            // 
            cellMarkChange_contextMenuStrip.Name = "contextMenuStrip1";
            cellMarkChange_contextMenuStrip.Size = new Size(61, 4);
            cellMarkChange_contextMenuStrip.Opening += markChange_contextMenuStrip_Opening;
            cellMarkChange_contextMenuStrip.ItemClicked += cellMarkChange_contextMenuStrip_ItemClicked;
            // 
            // february_page
            // 
            february_page.Location = new Point(4, 24);
            february_page.Name = "february_page";
            february_page.Padding = new Padding(3);
            february_page.Size = new Size(1141, 629);
            february_page.TabIndex = 1;
            february_page.Text = "Февраль";
            february_page.UseVisualStyleBackColor = true;
            // 
            // march_page
            // 
            march_page.Location = new Point(4, 24);
            march_page.Name = "march_page";
            march_page.Padding = new Padding(3);
            march_page.Size = new Size(1141, 629);
            march_page.TabIndex = 2;
            march_page.Text = "Март";
            march_page.UseVisualStyleBackColor = true;
            // 
            // april_page
            // 
            april_page.Location = new Point(4, 24);
            april_page.Name = "april_page";
            april_page.Padding = new Padding(3);
            april_page.Size = new Size(1141, 629);
            april_page.TabIndex = 3;
            april_page.Text = "Апрель";
            april_page.UseVisualStyleBackColor = true;
            // 
            // may_page
            // 
            may_page.Location = new Point(4, 24);
            may_page.Name = "may_page";
            may_page.Padding = new Padding(3);
            may_page.Size = new Size(1141, 629);
            may_page.TabIndex = 4;
            may_page.Text = "Май";
            may_page.UseVisualStyleBackColor = true;
            // 
            // june_page
            // 
            june_page.Location = new Point(4, 24);
            june_page.Name = "june_page";
            june_page.Padding = new Padding(3);
            june_page.Size = new Size(1141, 629);
            june_page.TabIndex = 5;
            june_page.Text = "Июнь";
            june_page.UseVisualStyleBackColor = true;
            // 
            // jule_page
            // 
            jule_page.Location = new Point(4, 24);
            jule_page.Name = "jule_page";
            jule_page.Padding = new Padding(3);
            jule_page.Size = new Size(1141, 629);
            jule_page.TabIndex = 6;
            jule_page.Text = "Июль";
            jule_page.UseVisualStyleBackColor = true;
            // 
            // august_page
            // 
            august_page.Location = new Point(4, 24);
            august_page.Name = "august_page";
            august_page.Padding = new Padding(3);
            august_page.Size = new Size(1141, 629);
            august_page.TabIndex = 7;
            august_page.Text = "Август";
            august_page.UseVisualStyleBackColor = true;
            // 
            // september_page
            // 
            september_page.Location = new Point(4, 24);
            september_page.Name = "september_page";
            september_page.Padding = new Padding(3);
            september_page.Size = new Size(1141, 629);
            september_page.TabIndex = 8;
            september_page.Text = "Сентябрь";
            september_page.UseVisualStyleBackColor = true;
            // 
            // october_page
            // 
            october_page.Location = new Point(4, 24);
            october_page.Name = "october_page";
            october_page.Padding = new Padding(3);
            october_page.Size = new Size(1141, 629);
            october_page.TabIndex = 9;
            october_page.Text = "Октябрь";
            october_page.UseVisualStyleBackColor = true;
            // 
            // november_page
            // 
            november_page.Location = new Point(4, 24);
            november_page.Name = "november_page";
            november_page.Padding = new Padding(3);
            november_page.Size = new Size(1141, 629);
            november_page.TabIndex = 10;
            november_page.Text = "Ноябрь";
            november_page.UseVisualStyleBackColor = true;
            // 
            // december_page
            // 
            december_page.Location = new Point(4, 24);
            december_page.Name = "december_page";
            december_page.Padding = new Padding(3);
            december_page.Size = new Size(1141, 629);
            december_page.TabIndex = 11;
            december_page.Text = "Декабрь";
            december_page.UseVisualStyleBackColor = true;
            // 
            // FIO
            // 
            FIO.HeaderText = "ФИО";
            FIO.Name = "FIO";
            FIO.ReadOnly = true;
            FIO.Width = 250;
            // 
            // Position
            // 
            Position.HeaderText = "Должность";
            Position.Name = "Position";
            Position.ReadOnly = true;
            Position.Width = 130;
            // 
            // EmployeeId
            // 
            EmployeeId.HeaderText = "Табельный №";
            EmployeeId.Name = "EmployeeId";
            EmployeeId.ReadOnly = true;
            EmployeeId.Width = 110;
            // 
            // day1
            // 
            day1.HeaderText = "1";
            day1.Name = "day1";
            day1.ReadOnly = true;
            day1.Width = 30;
            // 
            // day2
            // 
            day2.HeaderText = "2";
            day2.Name = "day2";
            day2.ReadOnly = true;
            day2.Width = 30;
            // 
            // day3
            // 
            day3.HeaderText = "3";
            day3.Name = "day3";
            day3.ReadOnly = true;
            day3.Width = 30;
            // 
            // day4
            // 
            day4.HeaderText = "4";
            day4.Name = "day4";
            day4.ReadOnly = true;
            day4.Width = 30;
            // 
            // day5
            // 
            day5.HeaderText = "5";
            day5.Name = "day5";
            day5.ReadOnly = true;
            day5.Width = 30;
            // 
            // day6
            // 
            day6.HeaderText = "6";
            day6.Name = "day6";
            day6.ReadOnly = true;
            day6.Width = 30;
            // 
            // day7
            // 
            day7.HeaderText = "7";
            day7.Name = "day7";
            day7.ReadOnly = true;
            day7.Width = 30;
            // 
            // day8
            // 
            day8.HeaderText = "8";
            day8.Name = "day8";
            day8.ReadOnly = true;
            day8.Width = 30;
            // 
            // day9
            // 
            day9.HeaderText = "9";
            day9.Name = "day9";
            day9.ReadOnly = true;
            day9.Width = 30;
            // 
            // day10
            // 
            day10.HeaderText = "10";
            day10.Name = "day10";
            day10.ReadOnly = true;
            day10.Width = 30;
            // 
            // day11
            // 
            day11.HeaderText = "11";
            day11.Name = "day11";
            day11.ReadOnly = true;
            day11.Width = 30;
            // 
            // day12
            // 
            day12.HeaderText = "12";
            day12.Name = "day12";
            day12.ReadOnly = true;
            day12.Width = 30;
            // 
            // day13
            // 
            day13.HeaderText = "13";
            day13.Name = "day13";
            day13.ReadOnly = true;
            day13.Width = 30;
            // 
            // day14
            // 
            day14.HeaderText = "14";
            day14.Name = "day14";
            day14.ReadOnly = true;
            day14.Width = 30;
            // 
            // day15
            // 
            day15.HeaderText = "15";
            day15.Name = "day15";
            day15.ReadOnly = true;
            day15.Width = 30;
            // 
            // day16
            // 
            day16.HeaderText = "16";
            day16.Name = "day16";
            day16.ReadOnly = true;
            day16.Width = 30;
            // 
            // day17
            // 
            day17.HeaderText = "17";
            day17.Name = "day17";
            day17.ReadOnly = true;
            day17.Width = 30;
            // 
            // day18
            // 
            day18.HeaderText = "18";
            day18.Name = "day18";
            day18.ReadOnly = true;
            day18.Width = 30;
            // 
            // day19
            // 
            day19.HeaderText = "19";
            day19.Name = "day19";
            day19.ReadOnly = true;
            day19.Width = 30;
            // 
            // day20
            // 
            day20.HeaderText = "20";
            day20.Name = "day20";
            day20.ReadOnly = true;
            day20.Width = 30;
            // 
            // day21
            // 
            day21.HeaderText = "21";
            day21.Name = "day21";
            day21.ReadOnly = true;
            day21.Width = 30;
            // 
            // day22
            // 
            day22.HeaderText = "22";
            day22.Name = "day22";
            day22.ReadOnly = true;
            day22.Width = 30;
            // 
            // day23
            // 
            day23.HeaderText = "23";
            day23.Name = "day23";
            day23.ReadOnly = true;
            day23.Width = 30;
            // 
            // day24
            // 
            day24.HeaderText = "24";
            day24.Name = "day24";
            day24.ReadOnly = true;
            day24.Width = 30;
            // 
            // day25
            // 
            day25.HeaderText = "25";
            day25.Name = "day25";
            day25.ReadOnly = true;
            day25.Width = 30;
            // 
            // day26
            // 
            day26.HeaderText = "26";
            day26.Name = "day26";
            day26.ReadOnly = true;
            day26.Width = 30;
            // 
            // day27
            // 
            day27.HeaderText = "27";
            day27.Name = "day27";
            day27.ReadOnly = true;
            day27.Width = 30;
            // 
            // day28
            // 
            day28.HeaderText = "28";
            day28.Name = "day28";
            day28.ReadOnly = true;
            day28.Width = 30;
            // 
            // day29
            // 
            day29.HeaderText = "29";
            day29.Name = "day29";
            day29.ReadOnly = true;
            day29.Width = 30;
            // 
            // day30
            // 
            day30.HeaderText = "30";
            day30.Name = "day30";
            day30.ReadOnly = true;
            day30.Width = 30;
            // 
            // day31
            // 
            day31.HeaderText = "31";
            day31.Name = "day31";
            day31.ReadOnly = true;
            day31.Width = 30;
            // 
            // total
            // 
            total.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            total.HeaderText = "Итого";
            total.Name = "total";
            total.ReadOnly = true;
            total.Width = 65;
            // 
            // timesheet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1434, 686);
            Controls.Add(timesheet_splitcontainer);
            Name = "timesheet";
            ShowIcon = false;
            Text = "Табель";
            FormClosing += timesheet_FormClosing;
            Load += timesheet_Load;
            VisibleChanged += timesheet_VisibleChanged;
            timesheet_splitcontainer.Panel1.ResumeLayout(false);
            timesheet_splitcontainer.Panel2.ResumeLayout(false);
            timesheet_splitcontainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)timesheet_splitcontainer).EndInit();
            timesheet_splitcontainer.ResumeLayout(false);
            yearViewTabControl.ResumeLayout(false);
            january_page.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)month_dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer timesheet_splitcontainer;
        private ListBox departaments_listbox;
        private TabControl yearViewTabControl;
        private TabPage january_page;
        private TabPage february_page;
        private TabPage march_page;
        private TabPage april_page;
        private TabPage may_page;
        private TabPage june_page;
        private TabPage jule_page;
        private TabPage august_page;
        private TabPage september_page;
        private TabPage october_page;
        private TabPage november_page;
        private TabPage december_page;
        private DataGridView month_dataGridView;
        private ContextMenuStrip cellMarkChange_contextMenuStrip;
        private Label selectedYear_label;
        private ComboBox selectedYear_combobox;
        private Button changeUserTypeButton;
        private DataGridViewTextBoxColumn FIO;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn EmployeeId;
        private DataGridViewTextBoxColumn day1;
        private DataGridViewTextBoxColumn day2;
        private DataGridViewTextBoxColumn day3;
        private DataGridViewTextBoxColumn day4;
        private DataGridViewTextBoxColumn day5;
        private DataGridViewTextBoxColumn day6;
        private DataGridViewTextBoxColumn day7;
        private DataGridViewTextBoxColumn day8;
        private DataGridViewTextBoxColumn day9;
        private DataGridViewTextBoxColumn day10;
        private DataGridViewTextBoxColumn day11;
        private DataGridViewTextBoxColumn day12;
        private DataGridViewTextBoxColumn day13;
        private DataGridViewTextBoxColumn day14;
        private DataGridViewTextBoxColumn day15;
        private DataGridViewTextBoxColumn day16;
        private DataGridViewTextBoxColumn day17;
        private DataGridViewTextBoxColumn day18;
        private DataGridViewTextBoxColumn day19;
        private DataGridViewTextBoxColumn day20;
        private DataGridViewTextBoxColumn day21;
        private DataGridViewTextBoxColumn day22;
        private DataGridViewTextBoxColumn day23;
        private DataGridViewTextBoxColumn day24;
        private DataGridViewTextBoxColumn day25;
        private DataGridViewTextBoxColumn day26;
        private DataGridViewTextBoxColumn day27;
        private DataGridViewTextBoxColumn day28;
        private DataGridViewTextBoxColumn day29;
        private DataGridViewTextBoxColumn day30;
        private DataGridViewTextBoxColumn day31;
        private DataGridViewTextBoxColumn total;
    }
}