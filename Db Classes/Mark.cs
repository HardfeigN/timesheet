using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using time_sheet.Db_Classes;

namespace time_sheet.Other_Classes
{
    public class Mark
    {
        public static Mark Ya = new Mark("Я");
        public static Mark N = new Mark("Н");
        public static Mark V = new Mark("В");
        public static Mark Rv = new Mark("Рв");
        public static Mark B = new Mark("Б");
        public static Mark K = new Mark("К");
        public static Mark OT = new Mark("ОТ");
        public static Mark Do = new Mark("До");
        public static Mark Hd = new Mark("Хд");
        public static Mark U = new Mark("У");
        public static Mark Oj = new Mark("Ож");
        public static Mark None = new Mark("-");
        public static Mark[] GetDefaultMarks()
        {
            return new Mark[] { Mark.Ya, Mark.N, Mark.V, 
                                Mark.Rv, Mark.B, Mark.K, 
                                Mark.OT, Mark.Do, Mark.Hd, 
                                Mark.U, Mark.Oj, Mark.None};
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }
        public string MarkString {  get; private  set; }
        [Required]
        public ICollection<DayInYear> Days { get; private set; }

        public Mark()
        {
            MarkString = None.MarkString;
        }

        private Mark(string mark)
        {
            MarkString = mark;
        }
    }
}
