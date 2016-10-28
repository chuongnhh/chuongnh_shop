using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace chuongnh_shop.Models
{
    [Table("Account")]
    public class Account
    {
        public Account()
        {
            this.DateTime = DateTime.Now;
        }
        [Display(Name = "Tên tài khoản")]
        [Key]
        [StringLength(50)]
        public string Username { get; set; }

        [Display(Name = "Mật khẩu")]
        [StringLength(50)]
        public string Password { get; set; }

        [Display(Name = "Họ tên")]
        [StringLength(100)]
        public string Name { get; set; }

        [Display(Name = "Hình ảnh")]
        [StringLength(200)]
        public string Image { get; set; }

        [Display(Name = "Giới tính")]
        [StringLength(10)]
        public string Gender { get; set; }

        [Display(Name = "Địa chỉ email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Số điện thoại")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Display(Name = "Ngày tạo")]
        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }
    }
}