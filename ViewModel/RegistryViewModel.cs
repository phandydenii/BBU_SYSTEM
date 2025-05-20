using System;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Model;
using BBU_SYSTEM.Models;

namespace BBU_SYSTEM.ViewModel
{
    public class RegistryViewModel
    {
        public IEnumerable<Degree>? degrees { get; set; }
        public IEnumerable<School>? schools { get; set; }
        public IEnumerable<Field>? fields { get; set; }
        public IEnumerable<Promotion>? promotions { get; set; }
        public IEnumerable<Stage>? stages { get; set; }
        public IEnumerable<Term>? terms { get; set; }
        public IEnumerable<Group>? groups { get; set; }
        public IEnumerable<GroupRoom>? groupRooms { get; set; }
        public IEnumerable<study_times>? studyTimes { get; set; }

        public IEnumerable<Province>? provinces { get; set; }
        public IEnumerable<Nationality>? nationalities { get; set; }
        public IEnumerable<Race>? races { get; set; }
        public IEnumerable<Disability>? disabilities { get; set; }
        public IEnumerable<StudentJob>? studentJobs { get; set; }
        public IEnumerable<HightSchool>? hightSchools { get; set; }
        public IEnumerable<Sponsor>? sponsors { get; set; }
        public IEnumerable<Certificate>? certificates { get; set; }
        public IEnumerable<Room>? rooms { get; set; }

        public StudentDto? student { get; set; }
        public RegistryDto? registry { get; set; }
        public ContactPersonDto? contactPerson { get; set; }
        public List<SchoolarshipDto>? schoolarships { get; set; }
        public List<StudentCertificateDto>? studentCertificates { get; set; }
        public ExtendDto? extend { get; set; }
        public ResumeDto? resume { get; set; }
        public bool ass_to_bach { get; set; }
        public bool bach_to_mas { get; set; }
    }
}

