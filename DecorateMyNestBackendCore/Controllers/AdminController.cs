using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace DecorateMyNest.Controllers
{
    [ApiController]
    [Route("api/admins")]
    public class AdminController : ControllerBase
    {
        [HttpGet]
        [Route("~/api/admins/")]
        public IActionResult Get()
        {
            try
            {
                var Admins = AdminService.GetAdmins();
                return Ok(Admins);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("~/api/admins/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var Admin = AdminService.GetAdminById(id);
                return Ok(Admin);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/admins/")]
        public IActionResult Create(AdminDTO obj)
        {
            try
            {
                var createdAdmin = AdminService.CreateAdmin(obj);
                return Ok(createdAdmin);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/admins/create-multiple")]
        public IActionResult Create(List<AdminDTO> Admins)
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
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPut]
        [Route("~/api/admins/")]
        public IActionResult Update(AdminDTO obj)
        {
            try
            {
                var updatedAdmin = AdminService.UpdateAdmin(obj);
                return Ok(updatedAdmin);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpDelete]
        [Route("~/api/admins/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = AdminService.DeleteAdmin(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }
    }
}
