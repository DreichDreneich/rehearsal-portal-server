using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RehearsalPortal.Domain
{
    public class Room : BaseEntity
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public Guid Id { get; set; }

        public Guid BaseId { get; set; }

        public string Name { get; set; }

        public int Area { get; set; }

        //public string CoverPic { get; set; }

        //public string Pics { get; set; }
    }
}
