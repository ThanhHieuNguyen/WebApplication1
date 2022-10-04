using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model
{
    public class LoaiModel
    {
        [Required]
        [MaxLength(100)]
        public string TenLoai { get; set; }
    }
}
