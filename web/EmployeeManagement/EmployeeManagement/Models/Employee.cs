using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The name is required: Please input name.")]
        [Display(Name = "Name")]
        [MaxLength(20, ErrorMessage = "Can not exceed 20 characters.")]
        public string fullName { get; set; }
        [Required(ErrorMessage = "The email is required: Please input email")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Invallid email: Incorrect email format.")]
        [Display(Name = "Email")]
        public string email { get; set; }
        [Display(Name = "Department")]
        [Required(ErrorMessage = "Invallid department: Please choose the department.")]
        public Dept? departerment { get; set; }
        public string ava { get; set; }
        //public Employee(int id, string fullName, string email, string ava, Dept departement)
        //{
        //    this.id = id;
        //    this.fullName = fullName;
        //    this.email = email;
        //    this.ava = ava;
        //    this.departerment = departement;
        //}
    }
}
