using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace chuongnh_shop.Models
{
    [Table("Product")]
    public class Product
    {
        public Product()
        {
            this.DateTime = DateTime.Now;
        }
        [Key]
        public int Id { get; set; }

        [Display(Name ="Tên sản phẩm")]
        [StringLength(100)]
        public string Name { get; set; }

        [Display(Name ="Hình ảnh")]
        [StringLength(200)]
        public string Image { get; set; }

        [Display(Name ="Mô tả")]
        [DataType(DataType.MultilineText)]
        [AllowHtml]
        public string Description { get; set; }

        [Display(Name = "Ngày tạo")]
        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }

        [Display(Name = "Người tạo")]
        [StringLength(100)]
        public string Author { get; set; }

        [Display(Name="Mã loại")]
        [ForeignKey("Category")]
        public int ProductId { get; set; }

        public virtual Category Category { get; set; }
    }
}