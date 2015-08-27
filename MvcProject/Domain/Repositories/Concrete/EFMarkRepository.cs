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
    public class EFMarkRepository : IMarkRepository
    {
        private static Logger logger;
        private readonly BlogContext context;

        public EFMarkRepository()
        {
            logger = LogManager.GetCurrentClassLogger();
            context = new BlogContext();
        }

        public Mark Get(int id)
        {
            try
            {
                return context.Marks.Find(id);
            }
            catch (Exception exception)
            {
                logger.Trace(exception.StackTrace);
                throw;
            }
        }
        public IEnumerable<Mark> Find(Func<Mark, bool> predicate)
        {
            try
            {
                return context.Marks.Where(predicate).ToList();
            }
            catch (Exception exception)
            {
                logger.Trace(exception.StackTrace);
                throw;
            }
        }

        public IEnumerable<Mark> GetAll()
        {
            try
            {
                return context.Marks.ToList();
            }
            catch (Exception exception)
            {
                logger.Trace(exception.StackTrace);
                throw;
            }
        }
        public void Create(Mark instance)
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

        public void Update(Mark instance)
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
