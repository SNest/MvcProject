using System;

namespace Domain.Entities 
{
    public class Feedback : Entity
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public virtual int UserId { get; set; }
        public virtual User User { get; set; }
        public int ArticleId { get; set; }
        public virtual Article Article { get; set; }
    }
}
