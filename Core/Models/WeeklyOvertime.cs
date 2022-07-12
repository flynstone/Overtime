

using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models
{
    public class WeeklyOvertime
    {
        public int Id { get; set; }
        
        public DateTime WeekEnding { get; set; }


        [Column(TypeName = "decimal(5,2)")]
        public decimal WorkedOvertime { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal RefusedOvertime { get; set; }

        private decimal _workedOvertime { get; set; }

        [NotMapped]
        [Column(TypeName = "decimal(6,2)")]
        public decimal TotalOvertime
        {
            get
            {
                return WorkedOvertime + RefusedOvertime;
            }
            set
            {
                _workedOvertime = value;
            }
        }
    }
}
