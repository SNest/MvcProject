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
    public class EFFeedbackRepository : IFeedbackRepository
    {
        private static Logger logger;
        private readonly BlogContext context;

        public EFFeedbackRepository(BlogContext someContext)
        {
            context = someContext;
            logger = LogManager.GetCurrentClassLogger();
        }

        public Feedback Get(int id)
        {
            try
            {
                return context.Feedbacks.Find(id);
            }
            catch (Exception exception)
            {
                logger.Trace(exception.StackTrace);
                throw;
            }
        }
        public IEnumerable<Feedback> Find(Func<Feedback, bool> predicate)
        {
            try
            {
                return context.Feedbacks.Where(predicate).ToList();
            }
            catch (Exception exception)
            {
                logger.Trace(exception.StackTrace);
                throw;
            }
        }

        public IEnumerable<Feedback> GetAll()
        {
            try
            {
                return context.Feedbacks.ToList();
            }
            catch (Exception exception)
            {
                logger.Trace(exception.StackTrace);
                throw;
            }
        }
        public void Create(Feedback instance)
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

        public void Update(Feedback instance)
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
