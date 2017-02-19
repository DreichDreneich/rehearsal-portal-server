using RehearsalPortal.Domain;

namespace RehearsalPortal.Core
{
    public interface IBaseUserRepository : IBasicRepository<BaseUser>
    {
        BaseUser GetBaseUserByUserId(System.Guid userId);
    }
}
