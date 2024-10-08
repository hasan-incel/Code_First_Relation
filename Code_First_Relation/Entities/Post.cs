namespace Code_First_Relation.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; } 
        public string Content { get; set; } 
        public int UserId { get; set; } 

        public User User { get; set; } // İlişkilendirilen kullanıcı
    }
}

