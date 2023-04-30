using time_sheet.Db_Classes;
using time_sheet.Db_Contexts;

namespace time_sheet.Forms.Employee_Editing
{
    public partial class EmployeeEditingForm : Form
    {
        private timesheet _timesheetForm;

        public EmployeeEditingForm(timesheet timesheetForm)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _timesheetForm = timesheetForm;
        }

        private void EmployeeEditingForm_Load(object sender, EventArgs e)
        {

        }

        private void EmployeeEditingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _timesheetForm.Show();
        }

        private void EmployeeEditingForm_VisibleChanged(object sender, EventArgs e)
        {
            FillEmployeeEditDataGrid(Employee_DataGrinView); // заполнение таблицы данными работников
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeDetailsFormOpen(EmployeeEditingType.add); // переход в другую форму для добавления работника
        }

        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeDetailsFormOpen(EmployeeEditingType.delete); // переход в другую форму для удаления работника
        }

        private void EditEmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeDetailsFormOpen(EmployeeEditingType.edit); // переход в другую форму для редактирования работника
        }

        private void EmployeeDetailsFormOpen(EmployeeEditingType type)
        {
            EmployeeDetailsForm employeeDetailsForm = new EmployeeDetailsForm(
                (int)Employee_DataGrinView.SelectedRows[0].Cells["employeeid"].Value, this, type); // передача необходимых данных в другую форму
            employeeDetailsForm.Show();
            this.Hide();
        }
        private void FillEmployeeEditDataGrid(DataGridView dataGridView)
        {
            using (var context = new EmployeesDbContext())
            {
                dataGridView.Rows.Clear();
                foreach (Employee employee in context.Employee.ToList())
                {
                    int currentRow = dataGridView.Rows.Add();
                    if (currentRow % 2 != 0) dataGridView.Rows[currentRow].DefaultCellStyle.BackColor = Color.LightSlateGray;
                    else dataGridView.Rows[currentRow].DefaultCellStyle.BackColor = Color.LightGray;
                    dataGridView.Rows[currentRow].DefaultCellStyle.ForeColor = Color.Black;
                    dataGridView.Rows[currentRow].DefaultCellStyle.SelectionForeColor = Color.Black;
                    dataGridView.Rows[currentRow].DefaultCellStyle.SelectionBackColor = Color.DimGray;

                    dataGridView.Rows[currentRow].Cells["EmployeeName"].Value = employee.Name;
                    dataGridView.Rows[currentRow].Cells["SecondName"].Value = employee.SecondName;
                    dataGridView.Rows[currentRow].Cells["SurName"].Value = employee.SurName;
                    dataGridView.Rows[currentRow].Cells["Position"].Value = employee.Position;
                    dataGridView.Rows[currentRow].Cells["DateOfBirth"].Value = employee.DateOfBirth;
                    dataGridView.Rows[currentRow].Cells["ResidenceAddress"].Value = employee.ResidenceAddress;
                    dataGridView.Rows[currentRow].Cells["Departament"].Value = context.Departament.Where(x => x.Id == employee.DepartamentId).Single().Name;
                    dataGridView.Rows[currentRow].Cells["employeeid"].Value = employee.Id;
                }
            }
        }
    }
}
