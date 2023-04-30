using Microsoft.EntityFrameworkCore.Infrastructure;
using MySqlConnector;
using time_sheet.Db_Contexts;
using time_sheet.Forms.Main_Form__Change_User_Type_;
using time_sheet.Other_Classes;

namespace time_sheet.Forms.Change_User_Type
{
    public partial class MainForm : Form
    {
        private UsersTypes _userType;
        public MainForm()
        {
            InitializeComponent();
            _userType = UsersTypes.Timekeeper;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void changeDataSourceString_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            dataSourceString_textbox.Enabled = changeDataSourceString_checkbox.Checked;
        }

        private void timekeeper_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            _userType = UsersTypes.Timekeeper;
        }

        private void departmentDirectoryAdministrator_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            _userType = UsersTypes.DepartmentDirectoryAdministrator;
        }

        private void employeeDirectoryAdministrator_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            _userType = UsersTypes.EmployeeDirectoryAdministrator;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timekeeper_radioButton.Checked = true;
            dataSourceString_textbox.Text = DataSource.DataSourceString;
            changeDataSourceString_checkbox.Checked = false;
        }

        private bool CheckConnectionString(string connectionString)
        {
            string connectionStringForMysql;
            string stringForCreateDatabase = connectionString.Substring(connectionString.IndexOf("Database="));
            connectionStringForMysql = connectionString.Substring(0, connectionString.IndexOf("Database=")) 
                + stringForCreateDatabase.Substring(stringForCreateDatabase.IndexOf(";") + 1);
            MySqlConnection conn = new MySqlConnection(connectionStringForMysql); // проверка строки подключения
            try
            {
                conn.Open();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void openTimesheetButton_Click(object sender, EventArgs e)
        {
            string connectionString = changeDataSourceString_checkbox.Checked ? // если строка подключения не изменялась, используем дефольтную (из файла)
                dataSourceString_textbox.Text : DataSource.DataSourceString;
            if (CheckConnectionString(connectionString)) // проверка строки подключения
            {
                WaitForm waitForm = new WaitForm();
                waitForm.Show();
                this.Hide();
                DataSource.WriteDataSourceStringToFile(connectionString);
                DatabaseFacade databaseFacade = new DatabaseFacade(new EmployeesDbContext());
                databaseFacade.EnsureCreated(); 
                DefaultDatabaseFill.FillDatabase(); // дефолтное заполнение базы данных
                new timesheet(_userType, this).Show(); // открытие формы журнала
                waitForm.Close();
            }
            else
            {
                MessageBox.Show("Проверьте строку подключения");
            }
        }
    }
}
