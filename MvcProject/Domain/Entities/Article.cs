using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Article : Entity
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public virtual ICollection<Mark> Marks { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
