using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace DecorateMyNest.Controllers
{
    [RoutePrefix("api/inProgressProjects")]
    public class InProgressProjectController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            try
            {
                var InProgressProjects = InProgressProjectService.GetInProgressProjects();
                return Ok(InProgressProjects);
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
                var InProgressProject = InProgressProjectService.GetInProgressProjectById(id);
                return Ok(InProgressProject);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Create(InProgressProjectDTO obj)
        {
            try
            {
                var createdInProgressProject = InProgressProjectService.CreateInProgressProject(obj);
                return Ok(createdInProgressProject);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("create-multiple")]
        public IHttpActionResult Create(List<InProgressProjectDTO> InProgressProjects)
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
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [Route("")]
        public IHttpActionResult Update(InProgressProjectDTO obj)
        {
            try
            {
                var updatedInProgressProject = InProgressProjectService.UpdateInProgressProject(obj);
                return Ok(updatedInProgressProject);
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
                var result = InProgressProjectService.DeleteInProgressProject(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
