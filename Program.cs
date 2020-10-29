using System;
using System.Collections.Generic;
using System.Text;

namespace FictionDataLayer
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
            }
        }
    }
}
