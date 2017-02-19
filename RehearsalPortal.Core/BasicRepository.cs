using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using RehearsalPortal.Domain;
using System.Data.Entity.Validation;

namespace RehearsalPortal.Core
{
    public class BasicRepository<T> : IBasicRepository<T> where T: BaseEntity
    {
        protected readonly RPContext context;
        protected IDbSet<T> entities;
        public BasicRepository()
        {
            context = new RPContext();
        }

        public Guid Create(T entity)
        {
            var newId = Guid.NewGuid();
            entity.Id = newId;

            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                this.Entities.Add(entity);
                return newId;
            }
            catch (DbEntityValidationException dbEx)
            {
                var errorMessage = "";
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        errorMessage += string.Format("Property: {0} Error: {1}",
                        validationError.PropertyName, validationError.ErrorMessage) + Environment.NewLine;
                    }
                }
                throw new Exception(errorMessage, dbEx);
            }
        }

        public void Delete(T entity)
        {
            this.Entities.Remove(entity);
        }

        public void DeleteById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            return this.Entities;
        }

        public T GetById(Guid id)
        {
            return this.Entities.Find(id);
        }

        public void Update(T entity)
        {
            var oldEntity = this.Entities.Find(entity.Id);
            context.Entry(oldEntity).CurrentValues.SetValues(entity);
        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }

        private IDbSet<T> Entities
        {
            get
            {
                if (entities == null)
                {
                    entities = context.Set<T>();
                }
                return entities;
            }
        }
    }
}
