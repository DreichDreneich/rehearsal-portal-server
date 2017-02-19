using System;
using System.Linq;
using RehearsalPortal.Domain;

namespace RehearsalPortal.Core
{
    public class BaseRepository : BasicRepository<Base>, IBaseRepository
    {
        public Base GetBaseByBaseUserId(Guid baseUserId)
        {
            return this.context.Bases.FirstOrDefault(b => b.BaseUserId.Equals(baseUserId));
        }
    }
}
