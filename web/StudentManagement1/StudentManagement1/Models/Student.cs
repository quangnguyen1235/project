using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement1.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required]
        [Display(Name ="Student name")]
        public string StudentName { get; set; }
        [Required]
        [Display(Name = "Date of birth")]
        public DateTime StudentDob { get; set; }
        [Required]
        [Display(Name = "Gender")]
        public bool StudentGender { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string StudentEmail { get; set; }
        [Required]
        public int GradeId { get; set; }
        public Grade Grade { get; set; }
    }
}
