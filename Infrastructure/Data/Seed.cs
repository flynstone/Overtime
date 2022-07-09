using Core.Models;

namespace Infrastructure.Data
{
    public class Seed
    {
        public static async Task SeedData(AppDbContext context)
        {
            // Make sure database is empty before attempting to insert the data.
            if (!context.Crews.Any() && !context.JobTitles.Any() && !context.RuleTypes.Any())
            {
                // Create default crews.
                var crews = new List<Crew>
                {
                    new Crew
                    {
                        Id = 1,
                        Name = "A"
                    },
                    new Crew
                    {
                        Id = 2,
                        Name = "B"
                    },
                    new Crew
                    {
                        Id = 3,
                        Name = "C"
                    },
                    new Crew
                    {
                        Id = 4,
                        Name = "D"
                    },
                    new Crew
                    {
                        Id = 5,
                        Name = "Days"
                    },
                };
                // Create default job titles.
                var jobTitles = new List<JobTitle>
                {
                    new JobTitle
                    {
                        Id = 1,
                        Name = "Lead Hand"
                    },
                    new JobTitle
                    {
                        Id = 2,
                        Name = "Spell Hand"
                    },
                    new JobTitle
                    {
                        Id = 3,
                        Name = "First Helper"
                    },

                    new JobTitle
                    {
                        Id = 4,
                        Name = "Second Helper"
                    },
                    new JobTitle
                    {
                        Id = 5,
                        Name = "Operator"
                    },
                };

                // Create default rule types.
                var ruleTypes = new List<RuleType>
                {
                    new RuleType
                    {
                        Id = 1,
                        Name = "Available"
                    },
                    new RuleType
                    {
                        Id = 2,
                        Name = "Vacation"
                    },
                    new RuleType
                    {
                        Id = 3,
                        Name = "Training"
                    },
                    new RuleType
                    {
                        Id = 4,
                        Name = "WI"
                    },
                    new RuleType
                    {
                        Id = 5,
                        Name = "Modified Work"
                    },
                    new RuleType
                    {
                        Id = 6,
                        Name = "Parental"
                    },
                    new RuleType
                    {
                        Id = 7,
                        Name = "Other"
                    },
                };

                await context.Crews.AddRangeAsync(crews);
                await context.JobTitles.AddRangeAsync(jobTitles);
                await context.RuleTypes.AddRangeAsync(ruleTypes);
                await context.SaveChangesAsync();

                // Create default employees, make sure no data is in the database first..
                if (!context.Employees.Any())
                {
                    var employees = new List<Employee>
                    {
                        new Employee
                        {
                            EmployeeId = 970,
                            FirstName = "John",
                            LastName = "Doe",
                            PhoneNumber = "641-672-1004",
                            CrewId = 1,
                            JobTitleId = 1,
                            RuleTypeId = 1
                        },
                        new Employee
                        {
                            EmployeeId = 982,
                            FirstName = "Bob",
                            LastName = "Elias",
                            PhoneNumber = "239-472-4321",
                            CrewId = 2,
                            JobTitleId = 3,
                            RuleTypeId = 1
                        },
                        new Employee
                        {
                            EmployeeId = 1014,
                            FirstName = "Jamie",
                            LastName = "Laurence",
                            PhoneNumber = "412-958-8612",
                            CrewId = 3,
                            JobTitleId = 2,
                            RuleTypeId = 2
                        },
                        new Employee
                        {
                            EmployeeId = 1071,
                            FirstName = "Darius",
                            LastName = "Jameson",
                            PhoneNumber = "262-938-7044",
                            CrewId = 4,
                            JobTitleId = 1,
                            RuleTypeId = 1
                        },
                        new Employee
                        {
                            EmployeeId = 1128,
                            FirstName = "Ronald",
                            LastName = "Alan",
                            PhoneNumber = "304-532-9035",
                            CrewId = 1,
                            JobTitleId = 4,
                            RuleTypeId = 1
                        },
                        new Employee
                        {
                            EmployeeId = 1177,
                            FirstName = "Dominic",
                            LastName = "Barnaby",
                            PhoneNumber = "518-241-4132",
                            CrewId = 2,
                            JobTitleId = 5,
                            RuleTypeId = 1
                        },
                        new Employee
                        {
                            EmployeeId = 1203,
                            FirstName = "Brad",
                            LastName = "Shelly",
                            PhoneNumber = "786-359-1095",
                            CrewId = 3,
                            JobTitleId = 3,
                            RuleTypeId = 1
                        },
                    };

                    await context.Employees.AddRangeAsync(employees);
                    await context.SaveChangesAsync();
                }
            }
        }
    }
}
