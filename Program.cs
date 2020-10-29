using FictionDataLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace FictionDataLayer
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                // -----OK------
                Author ter = new Author { UserName = "Ter", Role = UserRole.Admin };
                Author vor = new Author { UserName = "Vor", Role = UserRole.Admin };
                db.Authors.Add(ter);
                db.Authors.Add(vor);
                db.SaveChanges();

                foreach (var a in db.Authors.ToList())
                {
                    Console.WriteLine(a.UserName);
                }

                // -----OK------
                Tag tag1 = new Tag { Name = "tag1" };
                Tag tag2 = new Tag { Name = "tag2" };
                Tag tag3 = new Tag { Name = "tag3" };

                db.Tags.AddRange(tag1, tag2, tag3);
                db.SaveChanges();

                foreach (var t in db.Tags.ToList())
                {
                    Console.WriteLine(t.Name);
                }

                // -----OK------
                Genre g1 = new Genre { Name = "Action" };
                Genre g2 = new Genre { Name = "Romance" };
                Genre g3 = new Genre { Name = "Horror" };

                db.Genres.AddRange(g1, g2, g3);
                db.SaveChanges();

                foreach (var g in db.Genres.ToList())
                {
                    Console.WriteLine(g.Name);
                }

                Fanfic tom = new Fanfic { Name = "Tom", AuthorId = 1, GenreId = g1.Id };
                tom.FanficTags.Add(new FanficTags { FanficId = tom.Id, TagId = tag1.Id });
                tom.FanficTags.Add(new FanficTags { FanficId = tom.Id, TagId = tag2.Id });
                Fanfic nasya = new Fanfic { Name = "Nasya", AuthorId = 2, GenreId = g2.Id };
                tom.FanficTags.Add(new FanficTags { FanficId = nasya.Id, TagId = tag2.Id });
                tom.FanficTags.Add(new FanficTags { FanficId = nasya.Id, TagId = tag3.Id });
                Fanfic bob = new Fanfic { Name = "Bob", AuthorId = 2, GenreId = g1.Id };

                db.Fanfics.AddRange(tom, bob, nasya);
                db.SaveChanges();
                /*
                Chapter ch1 = new Chapter { Name = "Test1", Text = "TEST1" };
                Chapter ch2 = new Chapter { Name = "Test2", Text = "TEST2" };
                Chapter ch3 = new Chapter { Name = "Test3", Text = "TEST3" };

                db.Chapters.AddRange(ch1, ch2, ch3);
                db.SaveChanges();

                foreach (var c in db.Chapters.ToList())
                {
                    Console.WriteLine(c.Name);
                }
                
                Chapters = { ch1, ch2, ch3 }


                // вывод пользователей
                foreach (User user in db.Users.ToList())
                {
                    Console.WriteLine($" {user.UserName}");
                    foreach (Fanfic f in user.Fanfics)
                    {
                        Console.WriteLine(f.Name + " " + f.Genre);
                        foreach (Chapter ch in f.Chapters)
                        {
                            Console.WriteLine(ch.ChapterName + "" + ch.ChapterText);
                        }
                        foreach (FanficTag t in f.Tags)
                        {
                            Console.WriteLine("TAG" + f.Name + " " + t.Tag);
                        }
                    }

                }

                */

            }
        }
    }
}
/*Chapter chapterOne = new Chapter { Name = "ch1", Text = "sample text" };
                Chapter chapterTwo = new Chapter { Name = "ch2", Text = "sample text" };

                db.Chapters.AddRange(chapterOne, chapterTwo);
                db.SaveChanges();

                Fanfic fanf = new Fanfic { Name = "Test", Description = "Test fanfic", Chapters = { chapterOne, chapterTwo } };
                Author a = new Author { UserName = "Vor", Role = UserRole.Admin, Fanfics = { fanf } };
                db.Authors.Add(a);
                db.SaveChanges();
                db.Fanfics.Add(fanf);
                db.SaveChanges();
                */