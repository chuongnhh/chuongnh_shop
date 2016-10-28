using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace chuongnh_shop.Models
{
    [Table("Contact")]
    public class Contact
    {
        public Contact()
        {
            this.DateTime = DateTime.Now;
        }
        [Display(Name = "Mã")]
        [Key]
        public int Id { get; set; }

        [Display(Name = "Tiêu đề")]
        [StringLength(100)]
        public string Title { get; set; }

        [Display(Name = "Họ tên")]
        [StringLength(100)]
        public string Name { get; set; }

        [Display(Name = "Địa chỉ email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Điện thoại")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Display(Name = "Nội dung")]
        [DataType(DataType.MultilineText)]
        [AllowHtml]
        public string Content { get; set; }

        [Display(Name = "Ngày tạo")]
        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }
    }
}