using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.EF.Context;
using Domain.EF.Entities;
using Domain.EF.Repositories.Abstract;
using NLog;

namespace Domain.EF.Repositories.Concrete
{
    public class EFUserRepository : IUserRepository
    {
        private static Logger logger;
        private readonly BlogContext context;

        public EFUserRepository()
        {
            logger = LogManager.GetCurrentClassLogger();
            context = new BlogContext();
        }

        public User Get(int id)
        {
            try
            {
                return context.Users.Find(id);
            }
            catch (Exception exception)
            {
                logger.Trace(exception.StackTrace);
                throw;
            }
        }
        public IEnumerable<User> Find(Func<User, bool> predicate)
        {
            try
            {
                return context.Users.Where(predicate).ToList();
            }
            catch (Exception exception)
            {
                logger.Trace(exception.StackTrace);
                throw;
            }
        }

        public IEnumerable<User> GetAll()
        {
            try
            {
                return context.Users.ToList();
            }
            catch (Exception exception)
            {
                logger.Trace(exception.StackTrace);
                throw;
            }
        }
        public void Create(User instance)
        {
            try
            {
                context.Entry(instance).State = EntityState.Added;
                Save();
            }
            catch (Exception exception)
            {
                logger.Trace(exception.StackTrace);
                throw;
            }
        }

        public void Update(User instance)
        {
            try
            {
                context.Entry(instance).State = EntityState.Modified;
                Save();
            }
            catch (Exception exception)
            {
                logger.Trace(exception.StackTrace);
                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                context.Entry(Get(id)).State = EntityState.Deleted;
                Save();
            }
            catch (Exception exception)
            {
                logger.Trace(exception.StackTrace);
                throw;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
