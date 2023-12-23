using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class VendorService
    {
        public static List<VendorDTO> GetVendors()
        {
            var data = DataAccessFactory.VendorData().Read();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Vendor, VendorDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<VendorDTO>>(data);
            return mapped;
        }

        public static VendorDTO GetVendorById(int id)
        {
            var data = DataAccessFactory.VendorData().Read(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Vendor, VendorDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<VendorDTO>(data);
            return mapped;
        }

        public static VendorDTO CreateVendor(VendorDTO Vendor)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Vendor, VendorDTO>();
                c.CreateMap<VendorDTO, Vendor>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Vendor>(Vendor);
            var data = DataAccessFactory.VendorData().Create(mapped);
            var mapped2 = mapper.Map<VendorDTO>(data);
            return mapped2;
        }

        public static bool DeleteVendor(int id)
        {
            return DataAccessFactory.VendorData().Delete(id);
        }

        public static VendorDTO UpdateVendor(VendorDTO Vendor)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Vendor, VendorDTO>();
                c.CreateMap<VendorDTO, Vendor>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Vendor>(Vendor);
            var data = DataAccessFactory.VendorData().Update(mapped);
            var mapped2 = mapper.Map<VendorDTO>(data);
            return mapped2;
        }
    }
}
