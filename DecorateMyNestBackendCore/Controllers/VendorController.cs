using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace DecorateMyNest.Controllers
{
    [ApiController]
    [Route("api/vendors")]
    public class VendorController : ControllerBase
    {
        [HttpGet]
        [Route("~/api/vendors/")]
        public IActionResult Get()
        {
            try
            {
                var Vendors = VendorService.GetVendors();
                return Ok(Vendors);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("~/api/vendors/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var Vendor = VendorService.GetVendorById(id);
                return Ok(Vendor);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/vendors/")]
        public IActionResult Create(VendorDTO obj)
        {
            try
            {
                var createdVendor = VendorService.CreateVendor(obj);
                return Ok(createdVendor);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/vendors/create-multiple")]
        public IActionResult Create(List<VendorDTO> Vendors)
        {
            try
            {
                var createdVendors = new List<VendorDTO>();

                foreach (var Vendor in Vendors)
                {
                    var createdVendor = VendorService.CreateVendor(Vendor);
                    createdVendors.Add(createdVendor);
                }

                return Ok(createdVendors);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPut]
        [Route("~/api/vendors/")]
        public IActionResult Update(VendorDTO obj)
        {
            try
            {
                var updatedVendor = VendorService.UpdateVendor(obj);
                return Ok(updatedVendor);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpDelete]
        [Route("~/api/vendors/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = VendorService.DeleteVendor(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }
    }
}
