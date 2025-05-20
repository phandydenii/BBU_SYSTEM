using System;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Models;

namespace BBU_SYSTEM.ViewModel
{
	public class DegreePageViewModel
	{
        public List<Degree>? Degrees { get; set; }
        public DegreeDto DegreeDto { get; set; } = new DegreeDto(); // for form binding
    }
}

