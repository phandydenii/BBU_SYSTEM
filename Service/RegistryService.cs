using System;
using AutoMapper;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Respository;
using BBU_SYSTEM.ViewModel;

namespace BBU_SYSTEM.Service
{
	public class RegistryService : IRegistry
	{
        private readonly ICampusDbContext _campusDbContext;
        private readonly IMapper _mapper;
        public RegistryService(ICampusDbContext campusDbContext, IMapper mapper)
        {
            this._campusDbContext = campusDbContext;
            this._mapper = mapper;
        }
        public IEnumerable<object> get(string campus)
        {
            return null!;
        }

        public IEnumerable<object> get(string campus, DateTime from, DateTime todate)
        {
            var db = _campusDbContext.DbContext(campus);
            var fromdate = Convert.ToDateTime(from.ToString("yyyy-MM-dd"));
            var to_date = Convert.ToDateTime(todate.ToString("yyyy-MM-dd"));
            //var data = db.tbl_registry.Where(x => x.registration_date >= fromdate && x.registration_date <= to_date).ToList();
            var data = (from re in db.tbl_registry
                       join s in db.tbl_student on re.student_id equals s.student_id
                       join d in db.tbl_degree on re.degree_id equals d.degree_id
                       join sc in db.tbl_school on re.school_id equals sc.school_id
                       where re.registration_date >= fromdate && re.registration_date <= todate
                       select new
                       {
                           s.student_id,
                           s.student_name,
                           s.student_name_in_khmer,
                           s.sex,
                           s.date_of_birth,
                           s.phone,
                           d.degree_id,
                           d.degree,
                           d.degree_in_khmer,
                           sc.school_id,
                           sc.school_name,
                           sc.school_name_in_khmer,
                           re.promotion_no,
                           re.stage_no,
                           re.term_no,
                           re.study_time,
                           re.registration_date,
                           re.high_school_result,
                           re.high_school_table_no
                       }).ToList();
            return data;
        }
        public IEnumerable<object> get(string campus, FilterModel filter)
        {
            var db = _campusDbContext.DbContext(campus);
            var data = (from re in db.tbl_registry
                        join s in db.tbl_student on re.student_id equals s.student_id
                        join d in db.tbl_degree on re.degree_id equals d.degree_id
                        join sc in db.tbl_school on re.school_id equals sc.school_id
                        //where re.degree_id ==degree_id && re.school_id ==school_id && re.promotion_no==promotion_no
                        select new
                        {
                            s.student_id,
                            s.student_name,
                            s.student_name_in_khmer,
                            s.sex,
                            s.date_of_birth,
                            s.phone,
                            d.degree_id,
                            d.degree,
                            d.degree_in_khmer,
                            sc.school_id,
                            sc.school_name,
                            sc.school_name_in_khmer,
                            re.promotion_no,
                            re.stage_no,
                            re.term_no,
                            re.study_time,
                            re.registration_date,
                            re.high_school_result,
                            re.high_school_table_no
                        }).ToList();
            if(filter.degree_id != 0)
            {
                data = data.Where(x => x.degree_id == filter.degree_id).ToList();
            }
            if (filter.school_id != 0)
            {
                data = data.Where(x => x.school_id == filter.school_id).ToList();
            }
            if (filter.promotion_no != 0)
            {
                data = data.Where(x => x.promotion_no == filter.promotion_no).ToList();
            }
            if (filter.stage_no != 0)
            {
                data = data.Where(x => x.stage_no == filter.stage_no).ToList();
            }
            if (filter.term_no != 0)
            {
                data = data.Where(x => x.term_no == filter.term_no).ToList();
            }
            
            return data;
        }
        public object get(string campus, string id)
        {
            return null!;
        }
        public object add(string campus, RegistryDto req)
        {
            return null!;
        }
    }
}

