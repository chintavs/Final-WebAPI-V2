using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_WebAPI_V2.Models
{
    [Table("Animals")]
    public class Animal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AnimalId { get; set; }

        public string Phylum { get; set; }

        public string Class { get; set; }

        public string Genus { get; set; }

        public string Species { get; set; }
    }
}
