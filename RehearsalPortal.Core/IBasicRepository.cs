using System;
using System.Linq;
using RehearsalPortal.Domain;

namespace RehearsalPortal.Core
{
    public interface IBasicRepository<T> where T: BaseEntity
    {
        IQueryable<T> GetAll();
        void DeleteById(Guid id);
        T GetById(Guid id);
        void Delete(T entity);
        Guid Create(T entity);
        void Update(T entity);
        void SaveChanges();
    }
}
