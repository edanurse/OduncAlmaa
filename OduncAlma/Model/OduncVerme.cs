
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OduncAlma.Model
{
    public class OduncVerme
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateGive { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DateTake { get; set; }
       
    }
}
