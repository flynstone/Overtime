

using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models
{
    public class WeeklyOvertime
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public string Crew { get; set; }
        public string JobTitle { get; set; }
        public string RuleType { get; set; }

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
