using AutoMapper;
using BLL.DTO.Organisation;
using Models;

namespace BLL.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TblSchool, SchoolDetailsDTO>().ReverseMap();
            CreateMap<TblCustomer, AccountDetailsDTO>().ReverseMap();
            CreateMap<TblCustomerRole, CustomerRoleDTO>().ReverseMap();
        }
    }
}