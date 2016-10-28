using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace chuongnh_shop.Models
{
    [Table("Footer")]
    public class Footer
    {
        public Footer()
        {
            this.DateTime = DateTime.Now;
        }
        [Key]
        [Display(Name ="Mã")]
        public int Id { get; set; }

        [Display(Name ="Công ty")]
        [StringLength(100)]
        public string Company { get; set; }

        [Display(Name = "Ngày tạo")]
        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }

        [Display(Name = "Người tạo")]
        [StringLength(100)]
        public string Author { get; set; }
    }
}