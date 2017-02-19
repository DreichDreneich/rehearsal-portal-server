using RehearsalPortal.Domain;

namespace RehearsalPortal.Core
{
    public interface IBaseRepository : IBasicRepository<Base>
    {
        Base GetBaseByBaseUserId(System.Guid baseUserId);
    }
}
