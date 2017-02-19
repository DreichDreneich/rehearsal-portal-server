using System;
using RehearsalPortal.Domain;
using System.Linq;

namespace RehearsalPortal.Core
{
    public class BaseUserRepository : BasicRepository<BaseUser>, IBaseUserRepository
    {
        public BaseUser GetBaseUserByUserId(Guid userId)
        {
            return this.context.BaseUsers.FirstOrDefault(x => x.UserId.Equals(userId));
        }
    }
}
