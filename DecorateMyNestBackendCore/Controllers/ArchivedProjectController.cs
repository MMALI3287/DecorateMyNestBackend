using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace DecorateMyNest.Controllers
{
    [ApiController]
    [Route("api/archivedProjects")]
    public class ArchivedProjectController : ControllerBase
    {
        [HttpGet]
        [Route("~/api/archivedProjects/")]
        public IActionResult Get()
        {
            try
            {
                var ArchivedProjects = ArchivedProjectService.GetArchivedProjects();
                return Ok(ArchivedProjects);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("~/api/archivedProjects/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var ArchivedProject = ArchivedProjectService.GetArchivedProjectById(id);
                return Ok(ArchivedProject);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/archivedProjects/")]
        public IActionResult Create(ArchivedProjectDTO obj)
        {
            try
            {
                var createdArchivedProject = ArchivedProjectService.CreateArchivedProject(obj);
                return Ok(createdArchivedProject);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/archivedProjects/create-multiple")]
        public IActionResult Create(List<ArchivedProjectDTO> ArchivedProjects)
        {
            try
            {
                var createdArchivedProjects = new List<ArchivedProjectDTO>();

                foreach (var ArchivedProject in ArchivedProjects)
                {
                    var createdArchivedProject = ArchivedProjectService.CreateArchivedProject(ArchivedProject);
                    createdArchivedProjects.Add(createdArchivedProject);
                }

                return Ok(createdArchivedProjects);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPut]
        [Route("~/api/archivedProjects/")]
        public IActionResult Update(ArchivedProjectDTO obj)
        {
            try
            {
                var updatedArchivedProject = ArchivedProjectService.UpdateArchivedProject(obj);
                return Ok(updatedArchivedProject);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpDelete]
        [Route("~/api/archivedProjects/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = ArchivedProjectService.DeleteArchivedProject(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }
    }
}
