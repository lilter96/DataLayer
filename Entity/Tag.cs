using System.Collections.Generic;

namespace FictionDataLayer.Entity
{
    class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<FanficTags> FanficTags { get; set; }
        public Tag()
        {
            FanficTags = new List<FanficTags>();
        }
    }
}
