using FictionDataLayer.Entity;
using System.Collections.Generic;

namespace FictionDataLayer.Entity
{
    public class Fanfic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public List<FanficTags> FanficTags { get; set; }
        public List<Chapter> Chapters { get; set; }
        public List<Comment> Comments { get; set; }
        public Fanfic()
        {
            FanficTags = new List<FanficTags>();
            Chapters = new List<Chapter>();
            Comments = new List<Comment>();
        }
    }
}