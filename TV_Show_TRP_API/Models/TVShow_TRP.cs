using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TV_Show_TRP_API.Models
{
    public class TVShow_TRP
    {
        public int Id { get; set; }
        public string Show_Name { get; set; }
        public string Channel_Name { get; set; }
        public string Producer_Name { get; set; }
        public decimal Show_TRP { get; set; }
    }
}
