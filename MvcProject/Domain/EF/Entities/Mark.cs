namespace Domain.EF.Entities
{
    public class Mark : Entity
    {
        public int Value { get; set; }
        public virtual int UserId { get; set; }
        public virtual User User { get; set; }
        public int ArticleId { get; set; }
        public virtual Article Article { get; set; }
    }
}
