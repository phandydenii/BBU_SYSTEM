using System;
using BBU_SYSTEM.DTO;

namespace BBU_SYSTEM.Models.Req
{
    public class RegistryReq
    {
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

