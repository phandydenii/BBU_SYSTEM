using System;
using AutoMapper;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Models;
using BBU_SYSTEM.Model;

namespace BBU_SYSTEM.Configuration
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<Degree, DegreeDto>().ReverseMap();
            CreateMap<Branch, BranchDto>().ReverseMap();
            CreateMap<Faculty, FacultyDto>().ReverseMap();
            CreateMap<Field, FieldDto>().ReverseMap();
            CreateMap<Faculty, FacultyDto>().ReverseMap();
            CreateMap<Group, GroupDto>().ReverseMap();
            CreateMap<GroupRoom, GroupRoomDto>().ReverseMap();
            CreateMap<Promotion, PromotionDto>().ReverseMap();
            CreateMap<School, SchoolDto>().ReverseMap();
            CreateMap<Stage, StageDto>().ReverseMap();
            CreateMap<Term, TermDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Privilege, PrivilegeDto>().ReverseMap();
            CreateMap<UserPrivilege, UserPrivilegeDto>().ReverseMap();
            CreateMap<ContactPerson, ContactPersonDto>().ReverseMap();
            CreateMap<Extend, ExtendDto>().ReverseMap();
            CreateMap<Schoolarship, SchoolarshipDto>().ReverseMap();
            CreateMap<StudentCertificate, StudentCertificateDto>().ReverseMap();
            CreateMap<StudentJob, StudentJobDto>().ReverseMap();
            CreateMap<Disability, DisabilityDto>().ReverseMap();
            CreateMap<HightSchool, HighSchoolDto>().ReverseMap();
            CreateMap<Student, StudentDto>().ReverseMap();
            CreateMap<Registry, RegistryDto>().ReverseMap();

        }
    }
}

