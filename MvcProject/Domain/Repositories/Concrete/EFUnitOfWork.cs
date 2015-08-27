using System;
using Domain.Context;
using Domain.Repositories.Abstract;

namespace Domain.Repositories.Concrete
{
    internal class EFUnitOfWork : IUnitOfWork
    {
        private EFArticleRepository articleRepository;
        private EFFeedbackRepository feedbackRepository;
        private EFMarkRepository markRepository;
        private EFUserRepository userRepository;

        private bool disposed;
        private readonly BlogContext context;

        public EFUnitOfWork(string connectionString)
        {
            context = new BlogContext(connectionString);
        }

        public IArticleRepository Articles
        {
            get { return articleRepository ?? (articleRepository = new EFArticleRepository(context)); }
        }

        public IFeedbackRepository Feedbacks
        {
            get { return feedbackRepository ?? (feedbackRepository = new EFFeedbackRepository(context)); }
        }

        public IMarkRepository Marks
        {
            get { return markRepository ?? (markRepository = new EFMarkRepository(context)); }
        }

        public IUserRepository Users
        {
            get { return userRepository ?? (userRepository = new EFUserRepository(context)); }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }
    }
}