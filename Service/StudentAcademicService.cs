using System;
using AutoMapper;
using BBU_SYSTEM.Model;
using BBU_SYSTEM.Respository;

namespace BBU_SYSTEM.Service
{
	public class StudentAcademicService : IStudentAcademic
	{
        private readonly ICampusDbContext _campusDbContext;
        private readonly IMapper _mapper;
        public StudentAcademicService(ICampusDbContext campusDbContext, IMapper mapper)
        {
            this._campusDbContext = campusDbContext;
            this._mapper = mapper;
        }
        public object get(string campus, string student_id)
        {
            var db = _campusDbContext.DbContext(campus);  
            var student = db.tbl_student!.Where(s => s.student_id == student_id).FirstOrDefault();
            var studentgroup = db.tbl_student_group!.OrderByDescending(t => t.student_group_id).Where(g => g.student_id == student_id).FirstOrDefault();
            var group = db.tbl_group!.Where(i => i.group_id == studentgroup!.group_id).FirstOrDefault();
            var group_room = db.tbl_group_room.Where(i => i.group_id == group!.group_id).FirstOrDefault();
            var stage = db.tbl_stage!.Where(g => g.stage_id == group!.stage_id).FirstOrDefault();
            var promotion = db.tbl_promotion!.Where(p => p.promotion_id == stage!.promotion_id).FirstOrDefault();
            var term = db.tbl_term!.Where(t => t.stage_id == stage!.stage_id && t.term_id == studentgroup!.term_no).FirstOrDefault();
            var school = db.tbl_school!.Where(s => s.school_id == promotion!.school_id).FirstOrDefault();
            var degree = db.tbl_degree!.Where(d => d.degree_id == promotion!.degree_id).FirstOrDefault();
            var field = db.tbl_field!.Where(f => f.field_id == student!.field_id).FirstOrDefault();

            var data = new
            {
                student!.student_id,
                student!.student_name,
                student!.student_name_in_khmer,
                degree!.degree_id,
                degree!.degree,
                degree!.degree_in_khmer, 
                school!.school_id,
                school!.school_name,
                school!.school_name_in_khmer,
                field!.field_id,
                field!.field_name,
                field!.field_name_in_khmer,
                promotion!.promotion_id,
                promotion.promotion_no,
                stage!.stage_id,
                term!.term_id,
                term!.term_no,
                group!.group_id,
                group.group_name,
                group_room!.room_name,
                group_room.start_payment
            };
            return data!;
        }
    }
}

