using System;
using System.ComponentModel.DataAnnotations;

namespace StudentInfo.Models
{
    public class Semester
    {
        [Key]
        [Required]
        public int SemesterID { get; set; }

        public string SemesterDesc { get; set; }
    }
}
