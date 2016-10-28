using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace chuongnh_shop.Models
{
    [Table("Category")]
    public class Category
    {
        public Category()
        {
            Products = new List<Product>();
            this.DateTime = DateTime.Now;
        }
        [Key]
        [Display(Name = "Mã")]
        public int Id { get; set; }

        [Display(Name = "Tên loại")]
        [StringLength(100)]
        public string Name { get; set; }

        [Display(Name = "Hình ảnh")]
        [StringLength(200)]
        public string Iamge { get; set; }

        [Display(Name = "Mô tả")]
        [DataType(DataType.MultilineText)]
        [AllowHtml]
        public string Description { get; set; }

        [Display(Name = "Ngày tạo")]
        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }

        [Display(Name="Người tạo")]
        [StringLength(100)]
        public string Author { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}