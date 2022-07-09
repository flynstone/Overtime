using Api.DataTransferObjects;
using Api.Errors;
using AutoMapper;
using Core.Interfaces;
using Core.Models;
using Core.Specifications;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class EmployeesController : BaseApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public EmployeesController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<EmployeeToReturnDto>>> GetEmployees()
        {
            // Get list specifications.
            var spec = new EmployeesWithSpecifications();

            var employees = await _unitOfWork.Repository<Employee>().ListAsync(spec);

            return Ok(_mapper.Map<IReadOnlyList<Employee>, IReadOnlyList<EmployeeToReturnDto>>(employees));
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<EmployeeToReturnDto>> GetEmployee(int id)
        {
            // Get list specifications with a parameter.
            var spec = new EmployeesWithSpecifications(id);

            var employee = await _unitOfWork.Repository<Employee>().GetEntityWithSpec(spec);

            if (employee == null) return NotFound(new ApiResponse(400));

            return _mapper.Map<Employee, EmployeeToReturnDto>(employee);
        }

        [HttpGet("crews")]
        public async Task<ActionResult<IReadOnlyList<Crew>>> GetCrews()
        {
            return Ok(await _unitOfWork.Repository<Crew>().ListAllAsync());
        }

        [HttpGet("jobtitles")]
        public async Task<ActionResult<IReadOnlyList<JobTitle>>> GetJobTitles()
        {
            return Ok(await _unitOfWork.Repository<JobTitle>().ListAllAsync());
        }

        [HttpGet("ruletypes")]
        public async Task<ActionResult<IReadOnlyList<RuleType>>> GetRuleTypes()
        {
            return Ok(await _unitOfWork.Repository<RuleType>().ListAllAsync());
        }
    }
}
