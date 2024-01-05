// Ignore Spelling: Admins
// Ignore Spelling: Admin


using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace DecorateMyNest.Controllers
{
    [RoutePrefix("api/admins")]
    public class AdminController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            try
            {
                var Admins = AdminService.GetAdmins();
                return Ok(Admins);
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
                var Admin = AdminService.GetAdminById(id);
                return Ok(Admin);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Create(AdminDTO obj)
        {
            try
            {
                var createdAdmin = AdminService.CreateAdmin(obj);
                return Ok(createdAdmin);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("create-multiple")]
        public IHttpActionResult Create(List<AdminDTO> Admins)
        {
            try
            {
                var createdAdmins = new List<AdminDTO>();

                foreach (var Admin in Admins)
                {
                    var createdAdmin = AdminService.CreateAdmin(Admin);
                    createdAdmins.Add(createdAdmin);
                }

                return Ok(createdAdmins);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [Route("")]
        public IHttpActionResult Update(AdminDTO obj)
        {
            try
            {
                var updatedAdmin = AdminService.UpdateAdmin(obj);
                return Ok(updatedAdmin);
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
                var result = AdminService.DeleteAdmin(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
