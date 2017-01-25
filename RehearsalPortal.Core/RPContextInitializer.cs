using System.Data.Entity;
using RehearsalPortal.Domain;

namespace RehearsalPortal.Core
{
    public class RPContextInitializer : DropCreateDatabaseAlways<RPContext>
    {
        protected override void Seed(RPContext context)
        {
            base.Seed(context);
        }
    }
}
