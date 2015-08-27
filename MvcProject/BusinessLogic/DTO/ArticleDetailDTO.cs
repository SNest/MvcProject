using System;
using System.Collections.Generic;

namespace BusinessLogic.DTO
{
    public class ArticleDetailDTO
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public virtual IEnumerable<MarkDTO> Marks { get; set; }
        public virtual IEnumerable<FeedbackDTO> Feedbacks { get; set; }
    }
}
