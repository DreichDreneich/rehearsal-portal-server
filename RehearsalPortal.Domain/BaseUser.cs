using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RehearsalPortal.Domain
{
    public class BaseUser : BaseEntity
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public Guid Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<string> Phones { get; set; }

        public ICollection<Base> Bases { get; set; }

        //public string Pic { get; set; }
    }
}
