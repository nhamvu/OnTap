using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap
{
    class QLSV
    {
        private string _input;
        private SinhVienFPOLY _svFPT;
        private List<SinhVienFPOLY> _lstSVFPT;

        public QLSV()
        {
            _lstSVFPT = new List<SinhVienFPOLY>();
            _svFPT = new SinhVienFPOLY(1, "H", 1);
        }

        public string getInputValue(string mess)
        {
            Console.WriteLine($"Nhập {mess}");
            return Console.ReadLine();
        }
        public string getInputValue(int mess)
        {
            Console.WriteLine($"Nhập {mess}");
            return Console.ReadLine();
        }
        public void inThongTin()
        {
            foreach (var item in _lstSVFPT)
            {
                item.inThongTin();
            }
        }

        //Thêm thông tin
        public void themThongTin()
        {
            _input = getInputValue("Bạn muốn nhập bao nhiêu sinh viên?");
            for (int i = 0; i < Convert.ToInt32(_input); i++)
            {
                _svFPT = new SinhVienFPOLY();
                _svFPT.Masv = i + 1;
                _svFPT.HoTen = getInputValue("Nhập tên SV:");
                Console.WriteLine("Nhập Chuyên ngành(1 UDPM 2 WEB):");
                _lstSVFPT.Add(_svFPT);
                string luachon = getInputValue("Bạn có muốn nhập tiếp hay không?(Yes/No)");
                if (luachon == "No")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
        }

        //Tìm Theo khoảng max SV
        public void TimSV()
        {
            Console.WriteLine("Bạn Muốn bắt đầu từ mã bao nhiêu?");
            int khoangBD = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bạn Muốn kết thức ở mã bao nhiêu?");
            int khoangKT = Convert.ToInt32(Console.ReadLine());
            for (int i = khoangBD; i <= khoangKT; i++)
            {
                _lstSVFPT[i].inThongTin();
            }
        }

        public int getIndex()
        {
            Console.WriteLine("Nhập mã Sinh Viên");
            int masv = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < _lstSVFPT.Count; i++)
            {
                if (_lstSVFPT[i].Masv.ToString().Contains(masv.ToString()))
                {
                    return i;
                }
            }
            return -1;
        }

        public void TimSV_Cach2()
        {
            _lstSVFPT[getIndex()].inThongTin();
        }
        public void TimSV_Cach3()
        {
            Console.WriteLine("Nhập mã Sinh Viên");
            int masv = Convert.ToInt32(Console.ReadLine());
            _lstSVFPT[_lstSVFPT.FindIndex(c => c.Masv == masv)].inThongTin();
        }

        //Xóa sinh viên
        public void RemoveByLinq()
        {
            Console.WriteLine("Bạn Muốn Xóa mã nào?");
            int masv = Convert.ToInt32(Console.ReadLine());
            var value = (from x in _lstSVFPT.ToList() where x.Masv == masv select x).FirstOrDefault();
            var values = _lstSVFPT.Where(c => c.Masv == masv).Select(c => c).FirstOrDefault();
            if (value != null)
            {
                _lstSVFPT.Remove(value);
                Console.WriteLine("Xóa thành công");
            }
            else
            {
                Console.WriteLine("Xóa không thành công");
            }
        }

        public void XapXEp()
        {
            _lstSVFPT.Sort((a, b) => a.Masv.CompareTo(b.Masv));// Asc
            _lstSVFPT.Sort((a, b) => b.Masv.CompareTo(a.Masv));// Desc

            var o = (from x in _lstSVFPT.ToList() orderby x.Masv ascending select x).ToList();//LinQ dạng thuần
            var lstSudent = _lstSVFPT.OrderByDescending(c => c.Masv).ToList();//LInq dạng LamBda
            _lstSVFPT = new List<SinhVienFPOLY>();
            _lstSVFPT = lstSudent;
        }
    }
}
