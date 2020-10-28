namespace FictionDataLayer.Entity
{
    public class Medal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public byte[] Image { get; set; }
    }
}