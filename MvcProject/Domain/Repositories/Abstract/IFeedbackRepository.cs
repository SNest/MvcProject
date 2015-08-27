using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Repositories.Abstract
{
    public interface IFeedbackRepository
    {
        Feedback Get(int id);
        IEnumerable<Feedback> Find(Func<Feedback, Boolean> predicate);
        IEnumerable<Feedback> GetAll();
        void Create(Feedback instance);
        void Update(Feedback instance);
    }
}