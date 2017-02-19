using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RehearsalPortal.Domain
{
    public class User
    {
        public Guid Id { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Login { get; set; }

        public DateTime RegistrationDate { get; set; }

        public DateTime LastLoginDate { get; set; }

        //////////////////////////////////////////////////////

        public ICollection<Guid> BandsParticipant { get; set; }

        public ICollection<Guid> BaseUsers { get; set; }

        public ICollection<Guid> BandUsers { get; set; }
    }
}
