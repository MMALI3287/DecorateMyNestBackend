using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace DecorateMyNest.Controllers
{
    [RoutePrefix("api/vendors")]
    public class VendorController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            try
            {
                var Vendors = VendorService.GetVendors();
                return Ok(Vendors);
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
                var Vendor = VendorService.GetVendorById(id);
                return Ok(Vendor);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Create(VendorDTO obj)
        {
            try
            {
                var createdVendor = VendorService.CreateVendor(obj);
                return Ok(createdVendor);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("create-multiple")]
        public IHttpActionResult Create(List<VendorDTO> Vendors)
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
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [Route("")]
        public IHttpActionResult Update(VendorDTO obj)
        {
            try
            {
                var updatedVendor = VendorService.UpdateVendor(obj);
                return Ok(updatedVendor);
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
                var result = VendorService.DeleteVendor(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
