﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CS4790A1.Models
{
    public class BasicSchool
    {
    }

    [Table("Course")]
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string courseNumber { get; set; }
        public string courseName { get; set; }
        public int creditHours { get; set; }
        public int? maxEnrollment { get; set; }

    }

    [Table("Section")]
    public class Section
    {
        [Key]
        public int Id { get; set; }
        public int sectionID { get; set; }
        public int sectionNumber { get; set; }
        public string courseNumber { get; set; }
        public string sectionDays { get; set; }
        public DateTime sectionTIme { get; set; }
    }

    public class BasicSchoolDbContext : DbContext
    {
        public DbSet<Course> courses { get; set; }
        public DbSet<Section> sections { get; set; }
    }
}