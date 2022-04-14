using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap
{
    class SinhVienFPOLY
    {
        private int masv;
        private string hoTen;
        private int chuyenNganh; //1 UDPM 2 WEB

        public SinhVienFPOLY()
        {

        }

        public SinhVienFPOLY(int masv, string hoTen, int chuyenNganh)
        {
            this.masv = masv;
            this.hoTen = hoTen;
            this.chuyenNganh = chuyenNganh;
        }

        public int Masv { get => masv; set => masv = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public int ChuyenNganh { get => chuyenNganh; set => chuyenNganh = value; }
     
        public virtual void inThongTin()
        {
            Console.WriteLine($"{Masv},{HoTen},{ChuyenNganh}");
        }
    }
}
