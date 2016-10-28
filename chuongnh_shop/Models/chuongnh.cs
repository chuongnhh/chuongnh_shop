using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace chuongnh_shop.Models
{
    public class chuongnh : DbContext
    {
        public chuongnh():base("name = chuongnh")
        {

        }

        public virtual DbSet<About> Abouts { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Blog> Blog { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Footer> Footers { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<Slider> Sliders { get; set; }
    }
}