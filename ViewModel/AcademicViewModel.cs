using System;
using BBU_SYSTEM.Model;
using BBU_SYSTEM.Models;

namespace BBU_SYSTEM.ViewModel
{
    public class AcademicViewModel
    {
        public IEnumerable<Degree>? degrees { get; set; }
        public IEnumerable<School>? schools { get; set; }
        public IEnumerable<Field>? fields { get; set; }
        public IEnumerable<Promotion>? promotions { get; set; }
        public IEnumerable<Stage>? stages { get; set; }
        public IEnumerable<Term>? terms { get; set; }
        public IEnumerable<Group>? groups { get; set; }
        public IEnumerable<GroupRoom>? groupRooms { get; set; }
    }
}

