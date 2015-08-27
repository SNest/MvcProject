using System;

namespace Domain.Repositories.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IArticleRepository Articles { get; }
        IFeedbackRepository Feedbacks { get; }
        IMarkRepository Marks { get; }
        IUserRepository Users { get; }
        void Save();
    }
}