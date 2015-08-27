using System;
using System.Collections.Generic;
using Domain.EF.Entities;

namespace Domain.EF.Repositories.Abstract
{
    public interface IUserRepository : IRepository
    {
        User Get(int id);
        IEnumerable<User> Find(Func<User, Boolean> predicate);
        IEnumerable<User> GetAll();
        void Create(User instance);
        void Update(User instance);
    }
}