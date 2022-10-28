using System;
using System.ComponentModel.DataAnnotations;

namespace StudentInfo.Models
{
    public class Citizenship
    {
        [Key]
        [Required]
        public int CitizenshipID { get; set; }

        public string ProgramDesc { get; set; }

    }
}
