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

        //public IList<BandUser> BandsParticipant { get; set; }

        public virtual ICollection<BaseUser> BaseUsers { get; set; }

        public virtual ICollection<BandUser> BandUsers { get; set; }
    }
}
