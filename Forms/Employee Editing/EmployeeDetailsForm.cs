using System.Data;
using time_sheet.Db_Classes;
using time_sheet.Db_Contexts;
using time_sheet.Other_Classes;

namespace time_sheet.Forms.Employee_Editing
{
    public partial class EmployeeDetailsForm : Form
    {
        public int EmployeeId { get; private set; }
        private EmployeeEditingType _employeeEditingType;
        private EmployeeEditingForm _employeeEditingForm;

        public EmployeeDetailsForm(int employeeId, EmployeeEditingForm employeeEditingForm, EmployeeEditingType employeeEditingType)
        {
            InitializeComponent();
            EmployeeId = employeeId;
            _employeeEditingForm = employeeEditingForm;
            StartPosition = FormStartPosition.CenterScreen;
            _employeeEditingType = employeeEditingType;
            if (_employeeEditingType == EmployeeEditingType.delete) //изменение текста интерфейса под удаление
            {
                saveEmployeeButton.Text = "Удалить";
                employeeDetails_lable.Text = "При удалении работника будет удален его журнал!";
            }
            else                                                    //изменение текста интерфейса под добавление и сохранение
            {
                saveEmployeeButton.Text = "Сохранить";
                employeeDetails_lable.Text = "Внесите данные";
            }
            if(_employeeEditingType == EmployeeEditingType.add) createEmployee_groupbox.Visible = true; //показать радиокнопки заполнения журнала
            else createEmployee_groupbox.Visible = false;
        }

        private void EmployeeDetailsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _employeeEditingForm.Show(); // переход на форму внесения изменений
        }

        private void EmployeeDetailsForm_Load(object sender, EventArgs e)
        {
            FillEmployeeDetails();
            allWeekdaysWorked_radioButton.Checked = true;
        }

        private void FillEmployeeDetails()
        {
            using (var context = new EmployeesDbContext()) //получение данных из БД
            {
                Employee employee = context.Employee.Where(x => x.Id == EmployeeId).Single();//получение и вставка данных о работнике |
                nameEmployee_textbox.Text = employee.Name;                                   //                                       |
                secondnameEmployee_textbox.Text = employee.SecondName;                       //                                       |
                surnameEmployee_textbox.Text = employee.SurName;                             //                                       |
                positionEmployee_textbox.Text = employee.Position;                           //                                       |
                residenceAddressEmployee_textbox.Text = employee.ResidenceAddress;           //                                       |
                dateOfBirth_monthCalendar.SetDate(employee.DateOfBirth);                     //                                       |
                                                                                             //                                       |
                departamentEmployee_comboBox.Items.Clear();                                  //                                       |
                int indexOfCurrentDepartament = 0;                                           //                                       |
                foreach (Departament departament in context.Departament.ToList())            //                                       |
                {                                                                            //                                       |
                    departamentEmployee_comboBox.Items.Add(departament.Name);                //                                       |
                    if (employee.DepartamentId == departament.Id) indexOfCurrentDepartament = departamentEmployee_comboBox.Items.Count;
                }                                                                            //                                       |
                departamentEmployee_comboBox.SelectedIndex = indexOfCurrentDepartament - 1;  //                                       |
            }
        }

        private void saveEmployeeButton_Click(object sender, EventArgs e)
        {
            if (_employeeEditingType == EmployeeEditingType.edit) // если пользователь хочет внести изменения, то вносим их в выбранного работника
            {
                using (var context = new EmployeesDbContext())
                {
                    context.Employee.Where(x => x.Id == EmployeeId).Single().EmployeeDetailsChange(
                        nameEmployee_textbox.Text, secondnameEmployee_textbox.Text, surnameEmployee_textbox.Text,
                        dateOfBirth_monthCalendar.SelectionRange.Start, positionEmployee_textbox.Text,
                        residenceAddressEmployee_textbox.Text, context.Departament.Where(
                            x => x.Name == departamentEmployee_comboBox.SelectedItem.ToString()).Single(), this);
                    context.SaveChanges();
                }
            }
            if (_employeeEditingType == EmployeeEditingType.add) // если пользователь хочет добавить работника - создаем нового с заданными значениями (уникален только ID работника)
            {
                using (var context = new EmployeesDbContext())
                {
                    ICollection<Year> years = new List<Year>();
                    years.Add(new Year());
                    context.Employee.Add(new Employee(nameEmployee_textbox.Text, secondnameEmployee_textbox.Text, surnameEmployee_textbox.Text,
                        dateOfBirth_monthCalendar.SelectionRange.Start, positionEmployee_textbox.Text,
                        residenceAddressEmployee_textbox.Text, context.Departament.Where(
                            x => x.Name == departamentEmployee_comboBox.SelectedItem.ToString()).Single(), years));
                    context.SaveChanges();
                    if (allWeekdaysWorked_radioButton.Checked) DefaultDatabaseFill.DaysCreation_AllWeekdaysWorked(context, years.ElementAt(0));  // вызов заполнения журнала на год по выбранному варианту
                    if (setRandomTurnoutToWork_radioButton.Checked) DefaultDatabaseFill.DaysCreation_RandomWeekdays(context, years.ElementAt(0));// вызов заполнения журнала на год по выбранному варианту
                    if (noFillWeekdays_radiobutton.Checked) DefaultDatabaseFill.DaysCreation_NoFillWeekdays(context, years.ElementAt(0));        // вызов заполнения журнала на год по выбранному варианту
                    context.SaveChanges();
                }
            }
            if (_employeeEditingType == EmployeeEditingType.delete) // если пользователь хочет удалить - работник удаляется ( вместе с журналами его посещаемости)
            {
                using (var context = new EmployeesDbContext())
                {
                    context.Employee.Remove(context.Employee.Where(x => x.Id == EmployeeId).Single());
                    context.SaveChanges();
                }
            }
            this.Close();
        }
    }
}
