using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace chuongnh_shop.Models
{
    public class chuongnh : DbContext
    {
        public chuongnh():base("name = chuongnh_shop")
        {

        }
        public DbSet<Footer> Footers { get; set; }
    }
}