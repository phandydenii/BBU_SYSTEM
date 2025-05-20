using System;
using BBU_SYSTEM.Model;
using BBU_SYSTEM.Models;

namespace BBU_SYSTEM.ViewModel
{
	public class StudentViewModel
	{
		public Student? Student { get; set; }
		public StudentAcademic? StudentAcademic { get; set; }
        public Registry? registry { get; set; }
        public IEnumerable<Province>? provinces { get; set; }
		public IEnumerable<Race>? races { get; set; }
		public IEnumerable<Nationality>? nationalities { get; set; }
		public IEnumerable<HightSchool>? hightSchools { get; set; }
		public IEnumerable<StudentJob>? studentJobs { get; set; }
		public IEnumerable<Disability>? disabilities { get; set; }
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

