using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_WebAPI_V2.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentID { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public int Num_Classes { get; set; }

        public float GPA { get; set; }
    }
}
