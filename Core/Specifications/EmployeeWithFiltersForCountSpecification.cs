using Core.Models;

namespace Core.Specifications
{
    public class EmployeeWithFiltersForCountSpecification : BaseSpecification<Employee>
    {
        public EmployeeWithFiltersForCountSpecification(EmployeeSpecParams employeeParams) : base(x =>
            (!employeeParams.CrewId.HasValue || x.CrewId == employeeParams.CrewId) &&
            (!employeeParams.JobTitleId.HasValue || x.JobTitleId == employeeParams.JobTitleId) &&
            (!employeeParams.RuleTypeId.HasValue || x.RuleTypeId == employeeParams.RuleTypeId))
        {
        }
    }
}
