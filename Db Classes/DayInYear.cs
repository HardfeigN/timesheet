
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace time_sheet.Db_Classes
{
    public class DayInYear
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }
        public int MarkId { get; private set; }
        public int YearId { get; private set; }
        public int NumberOfDay { get; private set;}

        public DayInYear(int markId, int yearId, int numberOfDay)
        {
            MarkId = markId;
            YearId = yearId;
            NumberOfDay = numberOfDay;
        }

        public void ChangeMarkId(timesheet timesheetForm, DayInYear newDay, int markId)
        {
            if (timesheetForm.DaysInSelectedMonth.Contains(newDay)) MarkId = markId;
        }
    }
}
