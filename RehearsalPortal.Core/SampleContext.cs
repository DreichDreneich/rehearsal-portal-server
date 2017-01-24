using System.Data.Entity;
using RehearsalPortal.Domain;

namespace RehearsalPortal.Core
{
    public class UserContext : DbContext
    {
        public UserContext()
            : base("DbConnection")
        { }

        public DbSet<User> Users { get; set; }
    }
}
