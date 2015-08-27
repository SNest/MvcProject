
using System;
using System.Collections.Generic;
using Domain.EF.Entities;

namespace Domain.EF.Repositories.Abstract
{
    public interface IFeedbackRepository : IRepository
    {
        Feedback Get(int id);
        IEnumerable<Feedback> Find(Func<Feedback, Boolean> predicate);
        IEnumerable<Feedback> GetAll();
        void Create(Feedback instance);
        void Update(Feedback instance);
    }
}