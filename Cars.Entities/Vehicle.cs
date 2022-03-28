using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cars.Entities
{
    [Table("Vehicles")]
    public class Vehicle
    {

        [StringLength(10)]
        public string Color { get; set; }

        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VehicleId { get; set; }

        [Required]
        public string VehicleType { get; set; }

    }
}