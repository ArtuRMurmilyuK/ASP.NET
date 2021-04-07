namespace ClubSite.Data.Models
{
    public class Person
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Surname { set; get; }
        public string Gender { set; get; }
        public int Age { set; get; }
        public string City { set; get; }
        public string Description { set; get; }
        public string AboutMyself { set; get; }
        public bool IsFavorite { set; get; }
        public string Img { set; get; }
        public int CategoryId { set; get; }
        public virtual Category Category { set; get; }
    }
}