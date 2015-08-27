using System;
using System.Collections.Generic;
using Domain.EF.Entities;

namespace Domain.EF.Repositories.Abstract
{
    public interface IMarkRepository : IRepository
    {
        Mark Get(int id);
        IEnumerable<Mark> Find(Func<Mark, Boolean> predicate);
        IEnumerable<Mark> GetAll();
        void Create(Mark instance);
        void Update(Mark instance);
    }
}