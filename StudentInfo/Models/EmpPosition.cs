using System;
using System.ComponentModel.DataAnnotations;

namespace StudentInfo.Models
{
    public class EmpPosition
    {
        [Key]
        [Required]
        public int PositionID { get; set; }
        public string PositionDesc { get; set; }
    }
}
