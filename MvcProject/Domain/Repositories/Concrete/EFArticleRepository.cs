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
    public class EFArticleRepository : IArticleRepository
    {
        private static Logger logger;
        private readonly BlogContext context;

        public EFArticleRepository(BlogContext someContext)
        {
            context = someContext;
            logger = LogManager.GetCurrentClassLogger();
        }

        public Article Get(int id)
        {
            try
            {
                logger.Error("TEEEEEEEEST!!!!!1");
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