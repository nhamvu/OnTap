using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap
{
    class SinhVienUDPM:SinhVienFPOLY
    {
        private int chuyenNganhHep;// 1 Java 2 C#

        public SinhVienUDPM()
        {

        }
        public SinhVienUDPM(int masv, string hoTen, int chuyenNganh,int chuyenNganhHep) : base(masv, hoTen, chuyenNganh)
        {
            this.chuyenNganhHep = chuyenNganhHep;
        }

        public int ChuyenNganhHep { get => chuyenNganhHep; set => chuyenNganhHep = value; }

        public override void inThongTin()
        {
            base.inThongTin();
        }

        public string SinhVienFPOLY(int ChuyenNganhHep)
        {
            if (ChuyenNganhHep == 1)
            {
                return "Chuyên ngành Java";
            }
            else
            {
                return "Chuyên ngành C#";
            }
        }
    }
}
