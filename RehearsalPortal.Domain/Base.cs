using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RehearsalPortal.Domain
{
    public class Base : BaseEntity
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public Guid Id { get; set; }

        public Guid BaseUserId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public IEnumerable<string> Phones { get; set; }

        public string City { get; set; }

        public ICollection<Room> Rooms { get; set; }

        //public string Pic { get; set; }
    }
}
