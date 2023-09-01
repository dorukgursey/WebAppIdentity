using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class MainAbout
    {
        [Key]
        public int AboutID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string FirstImage { get; set; }
        public string SecondTitle { get; set; }
        public string SecondDescription { get; set; }
        public bool Status { get; set; }

    }
}
