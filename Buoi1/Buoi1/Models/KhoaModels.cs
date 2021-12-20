using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Buoi1.Models
{
    public class KhoaModels
    {
        public String TenKhoa { set; get; }
        public int NamThanhLap { set; get; }
        public String Message { get; set; }
        public KhoaModels()
        {
            TenKhoa = "Khoa cong nghe thong tin";
            NamThanhLap = 2003;
            Message = "Chao mung cac ban den voi FIT-HUFI";
        }
    }
}