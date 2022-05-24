using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CakeHTShop.Models
{
    public class Cake
    {
        public int Id { get; set; }
        [Display(Name = "Tên sản phẩm")]
        public string Title { get; set; }
        [Display(Name = "Ngày sản xuất")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Loại bánh")]
        public string Genre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Giá")]
        public decimal Price { get; set; }
    }
}
