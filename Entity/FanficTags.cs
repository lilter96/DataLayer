using FictionDataLayer.Entity;

namespace FictionDataLayer.Entity
{
    public class FanficTags
    {
        public int FanficId { get; set; }
        public Fanfic Fanfic { get; set; }

        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}