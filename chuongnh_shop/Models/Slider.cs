using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace chuongnh_shop.Models
{
    [Table("Slider")]
    public class Slider
    {
        public Slider()
        {
            this.DateTime = DateTime.Now;
        }
        [Key]
        [Display(Name = "Mã")]
        public int Id { get; set; }

        [Display(Name="Tiêu đề")]
        [StringLength(50)]
        public string Title { get; set; }

        [Display(Name = "Chú thích")]
        [StringLength(100)]
        public string Caption { get; set; }

        [Display(Name = "Hình ảnh")]
        [StringLength(200)]
        public string Image { get; set; }

        [Display(Name = "Liên kết")]
        [StringLength(200)]
        public string Link { get; set; }

        [Display(Name = "Ngày tạo")]
        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }

        [Display(Name = "Người tạo")]
        [StringLength(100)]
        public string Author { get; set; }
    }
}