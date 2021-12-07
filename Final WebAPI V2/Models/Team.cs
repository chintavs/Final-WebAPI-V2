using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_WebAPI_V2.Models
{

    [Table("Team_Mem")]
    public class Team
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MemberId { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public string College_Program { get; set; }

        public string Year { get; set; }

    }
}
