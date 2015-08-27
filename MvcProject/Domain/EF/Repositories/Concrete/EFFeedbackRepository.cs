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
    public class EFFeedbackRepository : IFeedbackRepository
    {
        private static Logger logger;
        private readonly BlogContext context;

        public EFFeedbackRepository()
        {
            logger = LogManager.GetCurrentClassLogger();
            context = new BlogContext();
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
                Save();
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
