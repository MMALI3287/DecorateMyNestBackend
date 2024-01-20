using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace DecorateMyNest.Controllers
{
    [ApiController]
    [Route("api/inProgressProjects")]
    public class InProgressProjectController : ControllerBase
    {
        [HttpGet]
        [Route("~/api/inProgressProjects/")]
        public IActionResult Get()
        {
            try
            {
                var InProgressProjects = InProgressProjectService.GetInProgressProjects();
                return Ok(InProgressProjects);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("~/api/inProgressProjects/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var InProgressProject = InProgressProjectService.GetInProgressProjectById(id);
                return Ok(InProgressProject);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/inProgressProjects/")]
        public IActionResult Create(InProgressProjectDTO obj)
        {
            try
            {
                var createdInProgressProject = InProgressProjectService.CreateInProgressProject(obj);
                return Ok(createdInProgressProject);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/inProgressProjects/create-multiple")]
        public IActionResult Create(List<InProgressProjectDTO> InProgressProjects)
        {
            try
            {
                var createdInProgressProjects = new List<InProgressProjectDTO>();

                foreach (var InProgressProject in InProgressProjects)
                {
                    var createdInProgressProject = InProgressProjectService.CreateInProgressProject(InProgressProject);
                    createdInProgressProjects.Add(createdInProgressProject);
                }

                return Ok(createdInProgressProjects);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPut]
        [Route("~/api/inProgressProjects/")]
        public IActionResult Update(InProgressProjectDTO obj)
        {
            try
            {
                var updatedInProgressProject = InProgressProjectService.UpdateInProgressProject(obj);
                return Ok(updatedInProgressProject);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpDelete]
        [Route("~/api/inProgressProjects/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = InProgressProjectService.DeleteInProgressProject(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }
    }
}
