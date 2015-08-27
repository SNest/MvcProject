using System.Data.Entity;
using Domain.Entities;

namespace Domain.Context
{
    public class BlogContext: DbContext
    {
        public BlogContext() : base("blogConnection")
        {
            Database.SetInitializer(new ContextInitializer());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Mark> Marks { get; set; }

    }
}
