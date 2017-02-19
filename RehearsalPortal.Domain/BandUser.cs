using System;
using System.Collections.Generic;

namespace RehearsalPortal.Domain
{
    public class BandUser : BaseEntity
    {
        public Guid RegisteredUserId { get; set; }

        public string Name { get; set; }

        public ICollection<User> Participants { get; set;}
    }
}
