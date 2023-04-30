using System.Globalization;
using time_sheet.Db_Classes;
using time_sheet.Db_Contexts;

namespace time_sheet.Time_Sheet_Window
{
    public class DataGridViewChanger
    {
        public static bool SaveDayMarkChanges(DayInYear day, timesheet timesheetForm, string newMark) // сохранение изменения отметки дня
        {
            try
            {
                using (var context = new EmployeesDbContext())
                {
                    context.Day.Where(x => x.Id == day.Id).Single().ChangeMarkId(
                        timesheetForm, day, context.Mark.Where(x => x.MarkString == newMark).Single().Id);
                    context.SaveChanges();
                }
                return true;
            } catch (Exception ex)
            {
                return false;
            }
        }

        public static List<DayInYear> GetDaysInMonthFromDataGridView(DataGridView dataGridView, int month, int yearNumber) // получение месяца, дни которого нужно изменить
        {
            List<DayInYear> days = new List<DayInYear>();
            using (var context = new EmployeesDbContext())
            {
                GregorianCalendar gregorianCalendar = new GregorianCalendar();
                int employeeId = Convert.ToInt32(dataGridView.Rows[dataGridView.SelectedCells[0].RowIndex].
                    Cells["EmployeeId"].Value.ToString());
                int yearId = context.Year.Where(x => x.EmployeeId == employeeId && x.YearNumber == yearNumber).Single().Id;

                int firstDayOfMonth = gregorianCalendar.GetDayOfYear(new DateTime(yearNumber, month, 1));
                int DaysInMonth = gregorianCalendar.GetDaysInMonth(yearNumber, month, 0);

                foreach (DayInYear day in context.Day.Where(x => x.YearId == yearId
                && (x.NumberOfDay >= firstDayOfMonth && x.NumberOfDay < firstDayOfMonth + DaysInMonth)).ToList())
                {
                    days.Add(day);
                }
            }
            return days;
        }

        public static void MonthFillDataGridView(DataGridView dataGridView, int month, int departamentId, int yearNumber) // заполнение месяца в таблицу
        {
            using (var context = new EmployeesDbContext())
            {
                dataGridView.Rows.Clear();
                GregorianCalendar gregorianCalendar = new GregorianCalendar();
                foreach (Employee employee in context.Employee.Where(x => x.DepartamentId == departamentId).ToList())
                {
                    foreach (Year year in context.Year.Where(x => x.EmployeeId == employee.Id && x.YearNumber == yearNumber).ToList())
                    {
                        int currentRow = dataGridView.Rows.Add();
                        if (currentRow % 2 != 0) dataGridView.Rows[currentRow].DefaultCellStyle.BackColor = Color.LightSlateGray;
                        else dataGridView.Rows[currentRow].DefaultCellStyle.BackColor = Color.LightGray;
                        dataGridView.Rows[currentRow].DefaultCellStyle.ForeColor = Color.Black;
                        dataGridView.Rows[currentRow].DefaultCellStyle.SelectionForeColor = Color.Black;
                        dataGridView.Rows[currentRow].DefaultCellStyle.SelectionBackColor = Color.DimGray;

                        int[] countOfMarks = new int[context.Mark.Count()];
                        int firstDayOfMonth = gregorianCalendar.GetDayOfYear(new DateTime(year.YearNumber, month, 1));
                        int DaysInMonth = gregorianCalendar.GetDaysInMonth(year.YearNumber, month, 0);

                        foreach (DayInYear day in context.Day.Where(x => x.YearId == year.Id
                        && (x.NumberOfDay >= firstDayOfMonth && x.NumberOfDay < firstDayOfMonth + DaysInMonth)).ToList())
                        {
                            dataGridView.Rows[currentRow].Cells["day" + (day.NumberOfDay - firstDayOfMonth + 1)].Value =
                                context.Mark.Where(x => x.Id == day.MarkId).Single().MarkString;
                            countOfMarks[day.MarkId - 1]++;
                        }
                        for (int numberOfDayInMonth = 0; numberOfDayInMonth < 31; numberOfDayInMonth++)
                        {
                            dataGridView.Columns["day" + (numberOfDayInMonth + 1)].Visible = (numberOfDayInMonth < 31 - (31 - DaysInMonth));
                        }
                        string total = "";
                        for (int i = 0; i < countOfMarks.Length; i++)
                        {
                            if (countOfMarks[i] > 0) total += $"{context.Mark.Where(x => x.Id == i + 1).Single().MarkString}({countOfMarks[i]}); ";
                        }

                        dataGridView.Rows[currentRow].Cells["FIO"].Value = employee.Name + " " + employee.SurName;
                        dataGridView.Rows[currentRow].Cells["Position"].Value = employee.Position;
                        dataGridView.Rows[currentRow].Cells["EmployeeId"].Value = employee.Id;
                        dataGridView.Rows[currentRow].Cells["Total"].Value = total;
                    }
                }
            }
        }
    }
}
