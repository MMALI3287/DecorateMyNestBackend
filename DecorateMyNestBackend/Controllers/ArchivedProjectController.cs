using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace DecorateMyNest.Controllers
{
    [RoutePrefix("api/archivedProjects")]
    public class ArchivedProjectController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            try
            {
                var ArchivedProjects = ArchivedProjectService.GetArchivedProjects();
                return Ok(ArchivedProjects);
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
                var ArchivedProject = ArchivedProjectService.GetArchivedProjectById(id);
                return Ok(ArchivedProject);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Create(ArchivedProjectDTO obj)
        {
            try
            {
                var createdArchivedProject = ArchivedProjectService.CreateArchivedProject(obj);
                return Ok(createdArchivedProject);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("create-multiple")]
        public IHttpActionResult Create(List<ArchivedProjectDTO> ArchivedProjects)
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
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [Route("")]
        public IHttpActionResult Update(ArchivedProjectDTO obj)
        {
            try
            {
                var updatedArchivedProject = ArchivedProjectService.UpdateArchivedProject(obj);
                return Ok(updatedArchivedProject);
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
                var result = ArchivedProjectService.DeleteArchivedProject(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
