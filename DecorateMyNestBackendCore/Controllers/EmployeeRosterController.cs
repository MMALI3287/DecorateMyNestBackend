using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace DecorateMyNest.Controllers
{
    [ApiController]
    [Route("api/employeeRosters")]
    public class EmployeeRosterController : ControllerBase
    {
        [HttpGet]
        [Route("~/api/employeeRosters/")]
        public IActionResult Get()
        {
            try
            {
                var EmployeeRosters = EmployeeRosterService.GetEmployeeRosters();
                return Ok(EmployeeRosters);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("~/api/employeeRosters/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var EmployeeRoster = EmployeeRosterService.GetEmployeeRosterById(id);
                return Ok(EmployeeRoster);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/employeeRosters/")]
        public IActionResult Create(EmployeeRosterDTO obj)
        {
            try
            {
                var createdEmployeeRoster = EmployeeRosterService.CreateEmployeeRoster(obj);
                return Ok(createdEmployeeRoster);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/employeeRosters/create-multiple")]
        public IActionResult Create(List<EmployeeRosterDTO> EmployeeRosters)
        {
            try
            {
                var createdEmployeeRosters = new List<EmployeeRosterDTO>();

                foreach (var EmployeeRoster in EmployeeRosters)
                {
                    var createdEmployeeRoster = EmployeeRosterService.CreateEmployeeRoster(EmployeeRoster);
                    createdEmployeeRosters.Add(createdEmployeeRoster);
                }

                return Ok(createdEmployeeRosters);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPut]
        [Route("~/api/employeeRosters/")]
        public IActionResult Update(EmployeeRosterDTO obj)
        {
            try
            {
                var updatedEmployeeRoster = EmployeeRosterService.UpdateEmployeeRoster(obj);
                return Ok(updatedEmployeeRoster);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpDelete]
        [Route("~/api/employeeRosters/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = EmployeeRosterService.DeleteEmployeeRoster(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }
    }
}
