using System.Globalization;
using time_sheet.Db_Classes;
using time_sheet.Db_Contexts;

namespace time_sheet.Other_Classes
{
    public class DefaultDatabaseFill
    {
        public static void DaysCreation_NoFillWeekdays(EmployeesDbContext context, Year year)
        {
            DaysCreation(context, year, false, false, true);
        }

        public static void DaysCreation_RandomWeekdays(EmployeesDbContext context, Year year)
        {
            DaysCreation(context, year, false, true, false);
        }

        public static void DaysCreation_AllWeekdaysWorked(EmployeesDbContext context, Year year)
        {
            DaysCreation(context, year, true, false, false);
        }

        private static DayOfWeek GetNextDayOfWeek(DayOfWeek currentDay) // смена для недели для выставления отметки В по выходным
        {
            if (currentDay == DayOfWeek.Monday) return DayOfWeek.Tuesday;
            else if (currentDay == DayOfWeek.Tuesday) return DayOfWeek.Wednesday;
            else if (currentDay == DayOfWeek.Wednesday) return DayOfWeek.Thursday;
            else if (currentDay == DayOfWeek.Thursday) return DayOfWeek.Friday;
            else if (currentDay == DayOfWeek.Friday) return DayOfWeek.Saturday;
            else if (currentDay == DayOfWeek.Saturday) return DayOfWeek.Sunday;
            else return DayOfWeek.Monday;
        }

        private static void DaysCreation(EmployeesDbContext context, Year year, bool isPirfectEmployee, bool setRandomTurnoutToWork, bool noFillWeekdays)
        { // создание дней для года журнала работника
            GregorianCalendar gregorianCalendar = new GregorianCalendar();
            DayOfWeek currentDay = gregorianCalendar.GetDayOfWeek(new DateTime(year.YearNumber, 1, 1));
            for (int i = 1; i <= gregorianCalendar.GetDaysInYear(year.YearNumber, 0); i++)
            {
                if (currentDay == DayOfWeek.Sunday || currentDay == DayOfWeek.Saturday)
                    context.Add(new DayInYear(context.Mark.Where(x => x.MarkString == Mark.V.MarkString).Single().Id, year.Id, i));
                else
                {
                    int markId;
                    if (isPirfectEmployee) markId = context.Mark.Where(x => x.MarkString == Mark.Ya.MarkString).Single().Id; // отметка "явка" для всех будней
                    else if (setRandomTurnoutToWork) // рандомные отметки на все будни
                    {
                        Random rand = new Random(year.Id * year.YearNumber * i);
                        markId = context.Mark.ToArray<Mark>()[rand.Next(0, context.Mark.Count<Mark>())].Id;
                    }
                    else if (noFillWeekdays) markId = context.Mark.Where(x => x.MarkString == Mark.None.MarkString).Single().Id; // прочерк во всех буднях
                    else markId = context.Mark.Where(x => x.MarkString == Mark.N.MarkString).Single().Id; // иначе Н-ки
                    context.Add(new DayInYear(markId, year.Id, i));
                }
                currentDay = GetNextDayOfWeek(currentDay);
            }
        }

        public static void FillDatabase() // дефолтное заполнение базы данных (для демонстрации работы)
        {
            using (var context = new EmployeesDbContext())
            {
                if (context.Mark.Count() < 1)
                {
                    context.Add(Mark.Ya); // добавление отметок
                    context.Add(Mark.N);
                    context.Add(Mark.V);
                    context.Add(Mark.Rv);
                    context.Add(Mark.B);
                    context.Add(Mark.K);
                    context.Add(Mark.OT);
                    context.Add(Mark.Do);
                    context.Add(Mark.Hd);
                    context.Add(Mark.U);
                    context.Add(Mark.Oj);
                    context.Add(Mark.None);
                }
                if (context.Departament.Count() < 1)
                {
                    context.Add(new Departament("Автоматизация антипригарных стульев")); // добавление департаментов
                    context.Add(new Departament("Разработка цветочных фреймворков"));
                    context.Add(new Departament("PR станков и горшков"));
                    context.SaveChanges();
                }
                if (context.Employee.Count() < 1)
                {
                    ICollection<Year> yearsForEmployee1 = new List<Year>(); // создание годов для работников
                    ICollection<Year> yearsForEmployee2 = new List<Year>();
                    ICollection<Year> yearsForEmployee3 = new List<Year>();
                    ICollection<Year> yearsForEmployee4 = new List<Year>();
                    ICollection<Year> yearsForEmployee5 = new List<Year>();
                    yearsForEmployee1.Add(new Year()); // заполнение годов разными данными
                    yearsForEmployee2.Add(new Year(DateTime.Now.Year - 1));
                    yearsForEmployee2.Add(new Year(DateTime.Now.Year));
                    yearsForEmployee3.Add(new Year(DateTime.Now.Year));
                    yearsForEmployee4.Add(new Year(DateTime.Now.Year));
                    yearsForEmployee5.Add(new Year(DateTime.Now.Year - 1));
                    yearsForEmployee5.Add(new Year(DateTime.Now.Year));
                    // создание работников
                    context.Add(new Employee("Василий", "Жесть", "Альбибаевич", new DateTime(1998, 1, 2), "Уборщик",
                        "Барнаул, Песчаная 192, 30", context.Departament.Single(e => e.Id == 1), yearsForEmployee1));
                    context.Add(new Employee("Петр", "Остапьенко", "Семенович", new DateTime(2002, 5, 23), "Оператор ЭВМ",
                        "Барнаул, Выдуманная 67, 1764", context.Departament.Single(e => e.Id == 2), yearsForEmployee2));
                    context.Add(new Employee("Руслан", "Рустев", "Васильевич", new DateTime(2007, 7, 28), "Начальник отдела",
                        "СПБ, Куйбышева 32б, 123", context.Departament.Single(e => e.Id == 3), yearsForEmployee3));
                    context.Add(new Employee("Александр", "Шевченко", "Иринов", new DateTime(1986, 11, 7), "Эксель программист",
                        "Новосибирск, Рабочая 183, 15/2", context.Departament.Single(e => e.Id == 1), yearsForEmployee4));
                    context.Add(new Employee("Владислав", "Картофель", "Семенович", new DateTime(2001, 9, 13), "Рекламщик",
                        "Барнаул, Красноармейский 64, 87", context.Departament.Single(e => e.Id == 3), yearsForEmployee5));
                    context.SaveChanges();
                    // заполнение отметок в дни работников
                    ICollection<Year> years = context.Year.OrderBy(x => x.Id).ToList();
                    DaysCreation_AllWeekdaysWorked(context, years.ElementAt(0));
                    DaysCreation_RandomWeekdays(context, years.ElementAt(1));
                    DaysCreation_RandomWeekdays(context, years.ElementAt(2));
                    DaysCreation_AllWeekdaysWorked(context, years.ElementAt(3));
                    DaysCreation_NoFillWeekdays(context, years.ElementAt(4));
                    DaysCreation_AllWeekdaysWorked(context, years.ElementAt(5));
                    DaysCreation_RandomWeekdays(context, years.ElementAt(6));
                    context.SaveChanges();
                }
            }
        }
    }
}
