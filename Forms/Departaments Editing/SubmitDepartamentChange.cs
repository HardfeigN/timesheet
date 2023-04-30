using time_sheet.Db_Contexts;
using time_sheet.Db_Classes;

namespace time_sheet.Departaments_Editing
{
    public partial class SubmitDepartamentChange : Form
    {
        public DepartamentChangeType ChangeType { get; private set; }
        private ListBox DepartamentxListBox;

        public SubmitDepartamentChange(DepartamentChangeType type, ListBox departamentxListBox)
        {
            this.ChangeType = type;
            this.DepartamentxListBox = departamentxListBox;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            submitchanges_TextBox.Visible = type != DepartamentChangeType.delete; // показать/скрыть поле для ввода названия департамента
            submitchanges_Lable.Text = type != DepartamentChangeType.delete ? "Введите название" : "При удалении департамента также удалятся его работники!";
        }

        private void SubmitDepartamentChange_Load(object sender, EventArgs e)
        {
            submitchanges_TextBox.Text = DepartamentxListBox.SelectedItem.ToString(); // название выбранного департамента в текстбокс
        }

        private void SubmitDepartamentChangeButton_Click(object sender, EventArgs e)
        {
            if (ChangeType == DepartamentChangeType.edit) // если пользователь хочет редактировать название
            {
                using (var context = new EmployeesDbContext())
                {
                    if (context.Departament.Where(x => x.Name == submitchanges_TextBox.Text).Count() > 0) // проверка на существование такаго департамента
                    {
                        MessageBox.Show("Такой департамент уже существует");
                    }
                    else
                    {
                        context.Departament.Where(x => x.Name == DepartamentxListBox.SelectedItem.ToString()).Single().
                            ChangeName(submitchanges_TextBox.Text, this);
                        context.SaveChanges();
                        int index = DepartamentxListBox.SelectedIndex;
                        DepartamentxListBox.Items.RemoveAt(index);
                        DepartamentxListBox.Items.Insert(index, submitchanges_TextBox.Text);
                        DepartamentxListBox.SelectedIndex = index;
                    }
                }
            }
            if (ChangeType == DepartamentChangeType.add) // если пользователь хочет добавить департамент
            {
                using (var context = new EmployeesDbContext())
                {
                    if (context.Departament.Where(x => x.Name == submitchanges_TextBox.Text).Count() > 0)
                    {
                        MessageBox.Show("Такой департамент уже существует");
                    }
                    else
                    {
                        context.Departament.Add(new Departament(submitchanges_TextBox.Text));
                        context.SaveChanges();
                        DepartamentxListBox.Items.Add(submitchanges_TextBox.Text);
                    }
                }
            }
            if (ChangeType == DepartamentChangeType.delete) // если пользователь хочет удалить департамент
            {
                using (var context = new EmployeesDbContext())
                {
                    int index = DepartamentxListBox.SelectedIndex;
                    int departamentId = context.Departament.Where(
                        x => x.Name == DepartamentxListBox.SelectedItem.ToString()).Single().Id;
                    context.Employee.RemoveRange(context.Employee.Where(x => x.DepartamentId == departamentId));
                    context.Departament.Remove(context.Departament.Where(
                        x => x.Id == departamentId).Single());
                    context.SaveChanges();
                    DepartamentxListBox.Items.RemoveAt(index);
                    if(DepartamentxListBox.Items.Count > 0) DepartamentxListBox.SelectedIndex = 0;
                }
            }
            Close();
        }
    }
}
