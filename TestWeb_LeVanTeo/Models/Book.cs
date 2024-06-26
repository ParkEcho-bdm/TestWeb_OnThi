using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestWeb_LeVanTeo.Models
{
    public class Book
    {
        public int Id { get; set; }
        [StringLength(250)]
        [Required(ErrorMessage ="Chưa nhập tiêu đề")]
        public string Title { get; set; }
        [StringLength(50)]
        [Required]
        public string Author { get; set; }
        [Range(0,double.MaxValue, ErrorMessage ="Giá không hợp lệ")]
        public double Price { get; set; }
        [Range(1, 1000, ErrorMessage ="Số lượng không hợp lệ")]
        public int Quantity { get; set; }
    }
}
