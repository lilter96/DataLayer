namespace FictionDataLayer.Entity
{
    public class Rating
    {
        public int Id { get; set; }
        public int ChapterId { get; set; }
        public int AuthorId { get; set; }
        public int Value { get; set; }
    }
}
