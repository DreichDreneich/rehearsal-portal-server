using System.Data.Entity;
using RehearsalPortal.Domain;


namespace RehearsalPortal.Core
{
    public class RPContext : DbContext
    {
        public RPContext()
            : base("DbConnection")
        {
            Database.SetInitializer(new RPContextInitializer());
        }

        public DbSet<Base> Bases { get; set; }
        public DbSet<BaseUser> BaseUsers { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
