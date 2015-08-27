using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.EF.Entities
{
    public class Article : Entity
    {
        public Article()
        {
            Marks = new HashSet<Mark>();
        }
        [Key]
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        [NotMapped]
        public virtual int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Mark> Marks { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }

    }
}
