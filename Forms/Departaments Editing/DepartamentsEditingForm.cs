using time_sheet.Other_Classes;

namespace time_sheet.Departaments_Editing
{
    public partial class DepartamentsEditingForm : Form
    {
        private timesheet _timesheetForm;

        public DepartamentsEditingForm(timesheet timesheetForm)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _timesheetForm = timesheetForm;
        }

        private void AddDepartamentButton_Click(object sender, EventArgs e)
        {
            OpenSubmitDepartamentChangeForm(DepartamentChangeType.add); // переход в другую форму для добавления департамента
        }

        private void EditDepartamentButton_Click(object sender, EventArgs e)
        {
            OpenSubmitDepartamentChangeForm(DepartamentChangeType.edit); // переход в другую форму для редактирования департамента
        }

        private void DeleteDepartamentButton_Click(object sender, EventArgs e)
        {
            OpenSubmitDepartamentChangeForm(DepartamentChangeType.delete); // переход в другую форму для удаления департамента
        }

        private void DepartamentsEditingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _timesheetForm.Show();
        }

        private void DepartamentsEditingForm_Load(object sender, EventArgs e)
        {
            DepartamentsLoading.LoadDepartamentsInListBox(departaments_listbox);
            departaments_listbox.SelectedIndex = 0;
        }

        private void OpenSubmitDepartamentChangeForm(DepartamentChangeType type)
        {
            SubmitDepartamentChange submitForm = new SubmitDepartamentChange(type, departaments_listbox);
            submitForm.ShowDialog();
        }
    }
}
