using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Entities
{
    [Table("Cars")]
    public class Car:Vehicle
    {
        public int CarId { get; set; }
        
        public bool IHWheels { get; set; }

        public bool IHHeadlights { get; set; }

        public bool IHeadlightsOn { get; set; }

       
    }
}
