using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace chuongnh_shop.Models
{
    [Table("Blog")]
    public class Blog
    {
        public Blog()
        {
            Posts = new List<Post>();
            this.DateTime = DateTime.Now;
        }
        [Display(Name ="Mã")]
        [Key]
        public int Id { get; set; }

        [Display(Name ="Tiêu đề")]
        [StringLength(250)]
        public string Name { get; set; }

        [Display(Name = "Hình ảnh")]
        [StringLength(200)]
        public string Image { get; set; }

        [Display(Name ="Ngày tạo")]
        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }

        [Display(Name ="Người tạo")]
        [StringLength(100)]
        public string Author { get; set; }

        public virtual List<Post> Posts { get; set; }
    }
}