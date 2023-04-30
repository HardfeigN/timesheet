using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using time_sheet.Departaments_Editing;

namespace time_sheet.Db_Classes
{
    public class Departament
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }
        public string Name { get; private set; }
        [Required]
        public ICollection<Employee> Employees { get; private set; }
        public Departament()
        {
            Name = "Новый департамент";
        }

        public Departament(string name)
        {
            Name = name;
        }

        public void ChangeName(string name, SubmitDepartamentChange submitForm)
        {
            if(submitForm.ChangeType == DepartamentChangeType.edit) Name = name;
        }
    }
}
