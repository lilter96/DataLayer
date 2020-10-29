using System.Collections.Generic;

namespace FictionDataLayer.Entity
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Fanfic> Fanfics { get; set; }
        public Genre()
        {
            Fanfics = new List<Fanfic>();
        }
    }
}
