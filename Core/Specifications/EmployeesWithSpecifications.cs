using Core.Models;

namespace Core.Specifications
{
    public class EmployeesWithSpecifications : BaseSpecification<Employee>
    {
        public EmployeesWithSpecifications()
        {
            AddInclude(x => x.Crew);
            AddInclude(x => x.JobTitle);
            AddInclude(x => x.RuleType);
        }

        public EmployeesWithSpecifications(int id) : base(x => x.Id == id)
        {
            AddInclude(x => x.Crew);
            AddInclude(x => x.JobTitle);
            AddInclude(x => x.RuleType);
        }
    }
}
