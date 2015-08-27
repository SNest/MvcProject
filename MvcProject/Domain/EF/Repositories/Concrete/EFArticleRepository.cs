using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Domain.EF.Context;
using Domain.EF.Entities;
using Domain.EF.Repositories.Abstract;
using NLog;

namespace Domain.EF.Repositories.Concrete
{
    public class EFArticleRepository : IArticleRepository
    {
        private static Logger logger;
        private readonly BlogContext context;

        public EFArticleRepository()
        {
            logger = LogManager.GetCurrentClassLogger();
            context = new BlogContext();
        }

        public Article Get(int id)
        {
            try
            {
                return context.Articles.Find(id);
            }
            catch (Exception exception)
            {
                logger.Trace(exception.StackTrace);
                throw;
            }
        }
        public IEnumerable<Article> Find(Func<Article, bool> predicate)
        {
            try
            {
                return context.Articles.Where(predicate).ToList();
            }
            catch (Exception exception)
            {
                logger.Trace(exception.StackTrace);
                throw;
            }
        }

        public IEnumerable<Article> GetAll()
        {
            try
            {
                return context.Articles.ToList();
            }
            catch (Exception exception)
            {
                logger.Trace(exception.StackTrace);
                throw;
            }
        }
        public void Create(Article instance)
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

        public void Update(Article instance)
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
