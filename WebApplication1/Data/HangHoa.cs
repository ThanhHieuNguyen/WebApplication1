using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Data
{
    public class HangHoa
    {
        [Key]
        public Guid Mahh { get; set; }
        [Required]
        [MaxLength(100)]
        public string Tenh { get; set; }
        public string Mota { get; set; }
        [Range(0, double.MaxValue)]
        public double Dongia { get; set; }
        public byte Giamgia { get; set; }

        public int? MaLoai { get; set; }
        [ForeignKey("MaLoai")]
        public Loai Loai { get; set; }
    }
}
