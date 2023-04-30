using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace time_sheet.Db_Classes
{
    public class Year
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }
        public int YearNumber { get; private set; }
        public int EmployeeId { get; private set; }
        [Required]
        public ICollection<DayInYear> Days { get; private set; }

        public Year()
        {
            YearNumber = DateTime.Now.Year;
        }

        public Year(int year)
        {
           YearNumber = year;
        }
    }
}
