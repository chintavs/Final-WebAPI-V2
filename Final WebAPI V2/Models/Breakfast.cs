using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_WebAPI_V2.Models
{
    [Table("Breakfast")]
    public class Breakfast
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonID { get; set; }

        public string PersonName { get; set; }

        public string BreakfastItem { get; set; }

        public int TimesPerWeek { get; set; }
    }
}
