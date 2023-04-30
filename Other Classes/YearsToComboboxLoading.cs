using time_sheet.Db_Classes;
using time_sheet.Db_Contexts;

namespace time_sheet.Other_Classes
{
    public class YearsToComboboxLoading
    {
        public static void UpdateComboBox(ComboBox comboBox, string departamentName)
        {
            using (var context = new EmployeesDbContext())
            {
                comboBox.Items.Clear();
                comboBox.Text = "";
                foreach (Employee employee in context.Employee.Where(e => e.DepartamentId == context.Departament.
                    Where(x => x.Name == departamentName).Single().Id).ToList())
                {
                    foreach (Year year in context.Year.Where(y => y.EmployeeId == employee.Id))
                    {
                        if (!comboBox.Items.Contains(year.YearNumber))
                        {
                            comboBox.Items.Add(year.YearNumber);
                        }
                    }
                }
                if (comboBox.Items.Count > 0)
                {
                    if (comboBox.Items.Contains(DateTime.Now.Year)) comboBox.SelectedIndex = 
                            comboBox.Items.IndexOf(DateTime.Now.Year);
                    else comboBox.SelectedIndex = 0;
                }
            }
        }
    }
}
