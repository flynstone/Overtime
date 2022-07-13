using Api.DataTransferObjects;
using Api.Errors;
using AutoMapper;
using Core.Interfaces;
using Core.Models;
using Core.Specifications;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class WeeklyOvertimesController : BaseApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public WeeklyOvertimesController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<EmployeeToReturnDto>> GetEmployee(int id)
        {
            // Get list specifications with a parameter.
            var spec = new EmployeesWithSpecifications(id);

            var employee = await _unitOfWork.Repository<Employee>().GetEntityWithSpec(spec);

            if (employee == null) return NotFound(new ApiResponse(400));

            return _mapper.Map<Employee, EmployeeToReturnDto>(employee);
        }

        [HttpPost]

    }
}
