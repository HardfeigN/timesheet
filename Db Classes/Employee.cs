using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using time_sheet.Forms.Employee_Editing;

namespace time_sheet.Db_Classes
{
    public class Employee
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string SecondName { get; private set; }
        public string SurName { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string Position { get; private set; }
        public string ResidenceAddress { get; private set; }
        [Required]
        public int DepartamentId { get; private set; }
        [Required]
        public ICollection<Year> Years { get; private set; }

        public Employee()
        {
            DepartamentId = new Departament().Id;
            Years = new List<Year>();
            Name = "Новый";
            SecondName = "Неназванный";
            SurName = "Работник";
            DateOfBirth = new DateTime(2001, 12, 31);
            Position = "рабочее место";
            ResidenceAddress = "Барнаул, Некрасова 41";
        }

        public Employee(string name, string secondName, string surName, DateTime dateOfBirth, string position, string residenceAddress, Departament departament, ICollection<Year> years)
        {
            Name = name;
            SecondName = secondName;
            SurName = surName;
            DateOfBirth = dateOfBirth;
            Position = position;
            ResidenceAddress = residenceAddress;
            DepartamentId = departament.Id;
            Years = years;
        }

        public void EmployeeDetailsChange(string name, string secondName, string surName, DateTime dateOfBirth, string position, string residenceAddress, Departament departament, EmployeeDetailsForm employeeDetailsForm)
        {
            if(employeeDetailsForm.EmployeeId == Id)
            {
                Name = name;
                SecondName = secondName;
                SurName = surName;
                DateOfBirth = dateOfBirth;
                Position = position;
                ResidenceAddress = residenceAddress;
                DepartamentId = departament.Id;
            }
        }
    }
}
