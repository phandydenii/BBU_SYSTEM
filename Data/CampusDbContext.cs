using System;
using BBU_SYSTEM.Model;
using BBU_SYSTEM.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BBU_SYSTEM.Data
{
    public class CampusDbContext : DbContext
    {
        public CampusDbContext(DbContextOptions<CampusDbContext> options)
        : base(options) { }

        public DbSet<Branch> tbl_branch { get; set; }
        public DbSet<Degree> tbl_degree { get; set; }
        public DbSet<Faculty> tbl_faculty { get; set; }
        public DbSet<Field> tbl_field { get; set; }
        public DbSet<FieldCertificate> tbl_field_certificate { get; set; }
        public DbSet<Group> tbl_group { get; set; }
        public DbSet<GroupRoom> tbl_group_room { get; set; }
        public DbSet<Promotion> tbl_promotion { get; set; }
        public DbSet<School> tbl_school { get; set; }
        public DbSet<Student> tbl_student { get; set; }
        public DbSet<Term> tbl_term { get; set; }
        public DbSet<Stage> tbl_stage { get; set; }
        public DbSet<Registry> tbl_registry { get; set; }
        public DbSet<Invoice> tbl_invoice { get; set; }
        public DbSet<InvoiceDetail> tbl_invoice_detail { get; set; }
        public DbSet<User> tbl_user { get; set; }
        public DbSet<Privilege> tbl_privilege { get; set; }
        public DbSet<UserPrivilege> tbl_user_privilege { get; set; }
        public DbSet<ContactPerson> tbl_contact_person { get; set; }
        public DbSet<Schoolarship> tbl_schoolarship { get; set; }
        public DbSet<StudentCertificate> tbl_student_certificate { get; set; }
        public DbSet<Extend> tbl_extend { get; set; }
        public DbSet<Resume> tbl_resume { get; set; }
        public DbSet<StudentJob> tbl_student_job { get; set; }
        public DbSet<HightSchool> tbl_high_school { get; set; }
        public DbSet<Disability> tbl_disability { get; set; }
        public DbSet<StudentGroup> tbl_student_group { get; set; }
        public DbSet<Nationality> tbl_nationality { get; set; }
        public DbSet<Race> tbl_race { get; set; }
        public DbSet<Province> tbl_province { get; set; }
        public DbSet<University> tbl_usersity { get; set; }
        public DbSet<StudentDiscount> tbl_student_discount { get; set; }
        public DbSet<Sponsor> tbl_sponsor { get; set; }
        public DbSet<Certificate> tbl_certificate { get; set; }
        public DbSet<study_times> tbl_study_time { get; set; }
        public DbSet<Room> tbl_room { get; set; }

        public DbSet<book_clothes> tbl_book_clothes { get; set; }
        public DbSet<Booking> tbl_booking { get; set; }
        public DbSet<booking_detail> tbl_booking_detail { get; set; }
        public DbSet<booking_item> tbl_booking_item { get; set; }
        public DbSet<booking_return> tbl_booking_return { get; set; }
        public DbSet<booking_return_detail> tbl_booking_return_detail { get; set; }


    }
}

