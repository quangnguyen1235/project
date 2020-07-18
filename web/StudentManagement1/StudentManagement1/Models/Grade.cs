using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement1.Models
{
    public class Grade
    {
        public int GradeId { get; set; }
        [Required]
        public string GradeName { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
