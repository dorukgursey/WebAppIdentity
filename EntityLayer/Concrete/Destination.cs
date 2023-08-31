using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Destination
    {
        public int DestinationID { get; set; }
        public string City { get; set; } = string.Empty;
        public string DayNight { get; set; } = string.Empty;
        public double Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public bool Status { get; set; }
    }
}
