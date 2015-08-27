using System.Collections.Generic;

namespace Domain.EF.Entities
{
    public class User : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NicName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
        public virtual ICollection<Mark> Marks { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
