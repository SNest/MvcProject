using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Repositories.Abstract
{
    public interface IUserRepository
    {
        User Get(int id);
        IEnumerable<User> Find(Func<User, Boolean> predicate);
        IEnumerable<User> GetAll();
        void Create(User instance);
        void Update(User instance);
    }
}