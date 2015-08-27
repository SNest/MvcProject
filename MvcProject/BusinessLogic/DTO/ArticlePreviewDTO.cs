using System;

namespace BusinessLogic.DTO
{
    public class ArticlePreviewDTO
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; } 
        public DateTime Date { get; set; }
    }
}
