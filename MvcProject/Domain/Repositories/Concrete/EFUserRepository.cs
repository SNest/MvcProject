using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Domain.Context;
using Domain.Entities;
using Domain.Repositories.Abstract;
using NLog;

namespace Domain.Repositories.Concrete
{
    public class EFUserRepository : IUserRepository
    {
        private static Logger logger;
        private readonly BlogContext context;

        public EFUserRepository(BlogContext someContext)
        {
            context = someContext;
            logger = LogManager.GetCurrentClassLogger();
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
            }
            catch (Exception exception)
            {
                logger.Trace(exception.StackTrace);
                throw;
            }
        }
    }
}
