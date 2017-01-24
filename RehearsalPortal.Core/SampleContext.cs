using System.Data.Entity;
using RehearsalPortal.Domain;

namespace RehearsalPortal.Core
{
    public class UserContext : DbContext
    {
        public UserContext()
            : base("DbConnection")
        {
            Database.SetInitializer(new DBInitializer());
        }

        public DbSet<User> Users { get; set; }
    }

    public class DBInitializer : DropCreateDatabaseAlways<UserContext>
    {
        protected override void Seed(UserContext context)
        {
            base.Seed(context);
        }
    }
}
