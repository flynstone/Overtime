using Core.Models;

namespace Core.Specifications
{
    public class EmployeesWithSpecifications : BaseSpecification<Employee>
    {
        public EmployeesWithSpecifications(EmployeeSpecParams employeeParams) : base(x => 
            (string.IsNullOrEmpty(employeeParams.Search) || x.FirstName.ToLower().Contains(employeeParams.Search)) && 
            (!employeeParams.CrewId.HasValue || x.CrewId == employeeParams.CrewId) &&
            (!employeeParams.JobTitleId.HasValue || x.JobTitleId == employeeParams.JobTitleId) &&
            (!employeeParams.RuleTypeId.HasValue || x.RuleTypeId == employeeParams.RuleTypeId))
        {
            AddInclude(x => x.Crew);
            AddInclude(x => x.JobTitle);
            AddInclude(x => x.RuleType);
            AddOrderBy(x => x.FirstName);
            ApplyPaging(employeeParams.PageSize * (employeeParams.PageIndex - 1), employeeParams.PageSize);

            // Add sorting to list.
            if (!string.IsNullOrEmpty(employeeParams.Sort))
            {
                switch(employeeParams.Sort)
                {
                    case "idAsc":
                        AddOrderBy(p => p.Id);
                        break;
                    case "idDesc":
                        AddOrderByDescending(p => p.Id);
                        break;
                    case "crew":
                        AddOrderBy(e => e.Crew);
                        break;
                    case "jobTitle":
                        AddOrderBy(e => e.JobTitle.Name);
                        break;
                    case "ruleType":
                        AddOrderBy(e => e.RuleType.Name);
                        break;
                    default:
                        AddOrderBy(n => n.FirstName);
                        break;
                }
            }
        }

        public EmployeesWithSpecifications(int id) : base(x => x.Id == id)
        {
            AddInclude(x => x.Crew);
            AddInclude(x => x.JobTitle);
            AddInclude(x => x.RuleType);
        }
    }
}
