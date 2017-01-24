using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RehearsalPortal.Domain
{
    class BaseUser
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<string>[] Phones { get; set; }

        //public string Pic { get; set; }
    }
}
