using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace chuongnh_shop.Models
{
    [Table("About")]
    public class About
    {
        public About()
        {
            this.DateTime = DateTime.Now;
        }
        [Display(Name ="Mã")]
        [Key]
        public int Id { get; set; }

        [Display(Name ="Tên công ty")]
        [StringLength(200)]
        public string Company { get; set; }

        [Display(Name = "Hình ảnh")]
        [StringLength(200)]
        public string Image { get; set; }

        [Display(Name ="Địa chỉ")]
        [StringLength(200)]
        public string Address { get; set; }

        [Display(Name ="Địa chỉ email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name ="Điện thoại")]   
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Display(Name ="Giờ làm việc")]
        [StringLength(200)]
        public string Time { get; set; }

        [Display(Name ="Giới thiệu công ty")]
        [DataType(DataType.MultilineText)]
        [AllowHtml]
        public string Description { get; set; }

        [Display(Name = "Ngày tạo")]
        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }

        [Display(Name = "Người tạo")]
        [StringLength(100)]
        public string Author { get; set; }
    }
}