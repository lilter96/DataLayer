using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;


namespace FictionDataLayer.Entity
{
    public class Author : IdentityUser
    {
        public List<Medal> Medals { get; set; }
        public List<Fanfic> Fanfics { get; set; }

        public Boolean IsBlocked { get; set; }

        public UserRole Role {get;set;}

        public Author()
        {
            this.Medals = new List<Medal>();
            this.Fanfics = new List<Fanfic>();
        }
    }
}
