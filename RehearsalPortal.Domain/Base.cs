using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RehearsalPortal.Domain
{
    class Base
    {
        string Id { get; set; }

        string Name { get; set; }

        public string Email { get; set; }

        public IEnumerable<string> Phones { get; set; }

        public string City { get; set; }

        //public string Pic { get; set; }
    }
}
