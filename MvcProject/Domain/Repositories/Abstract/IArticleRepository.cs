using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Repositories.Abstract
{
    public interface IArticleRepository 
    {
        Article Get(int id);
        IEnumerable<Article> Find(Func<Article, Boolean> predicate);
        IEnumerable<Article> GetAll();
        void Create(Article instance);
        void Update(Article instance);
    }
}