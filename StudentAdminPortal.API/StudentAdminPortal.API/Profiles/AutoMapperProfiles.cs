using AutoMapper;
using StudentAdminPortal.API.DomainModels;
using DataModels = StudentAdminPortal.API.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentAdminPortal.API.Profiles.AfterMaps;

namespace StudentAdminPortal.API.Profiles
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<DataModels.Student, Student>()
                .ReverseMap();
            CreateMap<DataModels.Gender, Gender>()
                .ReverseMap();
            CreateMap<DataModels.Address, Address>()
                .ReverseMap();
            CreateMap<UpdateStudentRequest, DataModels.Student>()
                .AfterMap<UpdarteStudentRequestAfterMap>();
            CreateMap<AddStudentRequest, DataModels.Student>()
                .AfterMap<AddStudentRequestAfterMap>();
        }
    }
}
