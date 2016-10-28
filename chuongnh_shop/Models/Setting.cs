using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace chuongnh_shop.Models
{
    [Table("Setting")]
    public class Setting
    {
        [Display(Name = "Mã")]
        [Key]
        public int Id { get; set; }

        [Display(Name = "Tên")]
        public string Name { get; set; }

    }
}