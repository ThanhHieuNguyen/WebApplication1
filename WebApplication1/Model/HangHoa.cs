﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace WebApplication1.Model
{
    public class HangHoaVM
    {
        public string TenHangHoa { get; set; }
        public double DonGia { get; set; }
    }
    public class HangHoa : HangHoaVM
    {
        public Guid MaHangHoa { get; set; }
    }
}
