namespace FictionDataLayer.Entity
{
    public class Chapter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public string Text { get; set; }
        public int FanficId { get; set; }
        public byte[] Image { get; set; }
    }
}