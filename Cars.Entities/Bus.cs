using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Entities
{
    [Table("Buses")]
    public class Bus:Vehicle
    {
        public int BusId { get; set; }

    }
}
