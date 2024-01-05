using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace DecorateMyNest.Controllers
{
    [RoutePrefix("api/employeeRosters")]
    public class EmployeeRosterController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            try
            {
                var EmployeeRosters = EmployeeRosterService.GetEmployeeRosters();
                return Ok(EmployeeRosters);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult GetById(int id)
        {
            try
            {
                var EmployeeRoster = EmployeeRosterService.GetEmployeeRosterById(id);
                return Ok(EmployeeRoster);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Create(EmployeeRosterDTO obj)
        {
            try
            {
                var createdEmployeeRoster = EmployeeRosterService.CreateEmployeeRoster(obj);
                return Ok(createdEmployeeRoster);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("create-multiple")]
        public IHttpActionResult Create(List<EmployeeRosterDTO> EmployeeRosters)
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
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [Route("")]
        public IHttpActionResult Update(EmployeeRosterDTO obj)
        {
            try
            {
                var updatedEmployeeRoster = EmployeeRosterService.UpdateEmployeeRoster(obj);
                return Ok(updatedEmployeeRoster);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                var result = EmployeeRosterService.DeleteEmployeeRoster(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
