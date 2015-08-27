using System;
using System.Collections.Generic;
using BusinessLogic.DTO;

namespace MvcProject.Models
{
    public class ArticleDetailViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public virtual ICollection<MarkDTO> Marks { get; set; }
        public virtual ICollection<FeedbackDTO> Feedbacks { get; set; }
    }
}