using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nearest_Pharmacy.Models
{
    public class Image
    {
        public int ID { get; set; }
        public string ProductID { get; set; }
        public string ImageURL { get; set; }
        public string Price { get; set; }
    }
}
