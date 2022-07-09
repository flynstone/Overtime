namespace Api.DataTransferObjects
{
    public class EmployeeToReturnDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Crew { get; set; }
        public string JobTitle { get; set; }
        public string RuleType { get; set; }
    }
}
