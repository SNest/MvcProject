using System;
using System.Collections;
using System.Collections.Generic;
using Domain.EF.Entities;

namespace Domain.EF.Repositories.Abstract
{
    public interface IArticleRepository : IRepository
    {
        Article Get(int id);
        IEnumerable<Article> Find(Func<Article, Boolean> predicate);
        IEnumerable<Article> GetAll();
        void Create(Article instance);
        void Update(Article instance);
    }
}