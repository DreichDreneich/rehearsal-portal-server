using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RehearsalPortal.Domain
{
    public class UserViewModel
    {
        public Guid Id { get; set; }

        public string Email { get; set; }

        public string Login { get; set; }

        //////////////////////////////////////////////////////

        public IEnumerable<Guid> BandsParticipant { get; set; }

        public IEnumerable<BaseUser> BaseUsers { get; set; }

        public IEnumerable<BandUser> BandUsers { get; set; }
    }
}
