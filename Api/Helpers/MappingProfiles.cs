using Api.DataTransferObjects;
using AutoMapper;
using Core.Models;

namespace Api.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Employee, EmployeeToReturnDto>()
                .ForMember(dest => dest.Crew, opt => opt.MapFrom(src => src.Crew.Name))
                .ForMember(dest => dest.JobTitle, opt => opt.MapFrom(src => src.JobTitle.Name))
                .ForMember(dest => dest.RuleType, opt => opt.MapFrom(src => src.RuleType.Name));
        }
    }
}
