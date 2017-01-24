using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RehearsalPortal.Domain
{
    class Room
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Area { get; set; }
        //public string CoverPic { get; set; }
        //public string Pics { get; set; }
    }
}
