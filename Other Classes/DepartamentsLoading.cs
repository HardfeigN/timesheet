using time_sheet.Db_Classes;
using time_sheet.Db_Contexts;

namespace time_sheet.Other_Classes
{
    public class DepartamentsLoading
    {
        public static void LoadDepartamentsInListBox(ListBox listbox)
        {
            using (var context = new EmployeesDbContext())
            {
                listbox.Items.Clear();
                foreach (Departament departament in context.Departament.OrderBy(x => x.Id).ToList())
                {
                    listbox.Items.Add(departament.Name);
                }
            }
            if (listbox.Items.Count > 0) listbox.SelectedIndex = 0;
        }
    }
}
