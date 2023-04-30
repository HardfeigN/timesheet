using time_sheet.Db_Classes;
using time_sheet.Other_Classes;
using time_sheet.Db_Contexts;
using time_sheet.Time_Sheet_Window;
using System.Text.RegularExpressions;
using time_sheet.Departaments_Editing;
using time_sheet.Forms.Employee_Editing;
using time_sheet.Forms.Change_User_Type;

namespace time_sheet
{
    public partial class timesheet : Form
    {
        public List<DayInYear> DaysInSelectedMonth { get; private set; }
        private UsersTypes _user;
        private MouseButtons _mouseButton;
        private MainForm _mainform;

        public timesheet(UsersTypes type, MainForm mainForm)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _user = type;
            _mainform = mainForm;
        }
        private void timesheet_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainform.Show();
        }

        private void changeUserTypeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectedYear_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void yearViewTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void month_dataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseButton = e.Button; // сохранение кнопки мыши ( для запрета на открытие контекстного меню на ЛКМ )
        }

        private void cellMarkChange_contextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem != null) ReplaceDayMark(e.ClickedItem.Text);
        }

        private void timesheet_VisibleChanged(object sender, EventArgs e) // заполнение департаментов при появлении/скрытии формы
        {
            DepartamentsLoading.LoadDepartamentsInListBox(departaments_listbox);
        }

        private void departaments_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            YearsToComboboxLoading.UpdateComboBox(selectedYear_combobox, departaments_listbox.SelectedItem.ToString());
            UpdateDataGridView();
        }

        private void timesheet_Load(object sender, EventArgs e)
        {
            DepartamentsLoading.LoadDepartamentsInListBox(departaments_listbox); // список департаментов в листбокс
            YearsToComboboxLoading.UpdateComboBox(selectedYear_combobox, departaments_listbox.SelectedItem.ToString()); // номера годов журналов работников департамента в комбобокс
            LoadMarksToContextMenu(cellMarkChange_contextMenuStrip); // добавление существующих отметок в контестное меню
        }

        private void ReplaceDayMark(string mark)
        {
            int yearNumber = DateTime.Now.Year;
            int.TryParse(selectedYear_combobox.Text, out yearNumber);
            DaysInSelectedMonth = DataGridViewChanger.GetDaysInMonthFromDataGridView(month_dataGridView, yearViewTabControl.SelectedIndex + 1, yearNumber);
            if (DataGridViewChanger.SaveDayMarkChanges( // сохранение измененной отметки дня
                DaysInSelectedMonth[month_dataGridView.SelectedCells[0].ColumnIndex - 3], this, mark))
                month_dataGridView.SelectedCells[0].Value = mark;
        }

        private void departaments_listbox_DoubleClick(object sender, EventArgs e)
        {
            if (_user == UsersTypes.DepartmentDirectoryAdministrator) // если пользователь админ справочника департаментов 
            {
                DepartamentsEditingForm editingForm = new DepartamentsEditingForm(this);
                editingForm.Show();
                this.Hide();
            }
        }

        private void markChange_contextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_mouseButton == MouseButtons.Left) // открытие контекстного меню на даблклик ПКМ
            {
                if (!Regex.IsMatch(month_dataGridView.Columns[month_dataGridView.SelectedCells[0].ColumnIndex].Name, @"day")) // проверяем, что клик был на поле дня в таблице
                    e.Cancel = true;
            }
            else e.Cancel = true;
        }

        private void month_dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (_user == UsersTypes.Timekeeper) cellMarkChange_contextMenuStrip.Show(MousePosition);// если пользователь табельщик
            if (_user == UsersTypes.EmployeeDirectoryAdministrator) // если пользователь админ справочника работников
            {
                EmployeeEditingForm employeeEditingForm = new EmployeeEditingForm(this);
                employeeEditingForm.Show();
                this.Hide();
            }
        }

        private void LoadMarksToContextMenu(ContextMenuStrip contextMenuStrip) // добавление доступных отметок в контекстное меню
        {
            using (var context = new EmployeesDbContext())
            {
                contextMenuStrip.Items.Clear();
                foreach (Mark mark in context.Mark.OrderBy(x => x.Id).ToList())
                {
                    contextMenuStrip.Items.Add(mark.MarkString);
                }
            }
        }

        private void UpdateDataGridView() // обновить данные в таблице
        {
            int departamentId;
            int numberOfYear = DateTime.Now.Year;
            using (var context = new EmployeesDbContext())
            {
                departamentId = context.Departament.Where(x => x.Name == departaments_listbox.SelectedItem.ToString()).Single().Id;
            }
            int.TryParse(selectedYear_combobox.Text, out numberOfYear);
            if (!yearViewTabControl.TabPages[yearViewTabControl.SelectedIndex].Controls.Contains(month_dataGridView))
                yearViewTabControl.TabPages[yearViewTabControl.SelectedIndex].Controls.Add(month_dataGridView);
            DataGridViewChanger.MonthFillDataGridView(month_dataGridView,
                yearViewTabControl.SelectedIndex + 1, departamentId, numberOfYear);
        }

    }
}
