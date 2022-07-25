using System;
using System.ComponentModel.DataAnnotations;

namespace School.API.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Grade { get; set; }
        public DateTime DOB { get; set; }
    }
}
