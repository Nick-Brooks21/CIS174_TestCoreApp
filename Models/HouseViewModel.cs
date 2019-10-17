using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models
{
    public class HouseViewModel
    {
        public int id { get; set;  }
        public int bedrooms { get; set; }
        public int squareFT { get; set; }
        public DateTime date { get; set; }
        public string flooring { get; set; }
    }
}
