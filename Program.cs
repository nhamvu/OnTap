using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            QLSV ql = new QLSV();
            SinhVienUDPM sv = new SinhVienUDPM();

            int selection;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Nhập 1 danh sách đối tượng (1đ) Khi nhập có hỏi tiếp hay ko ? (0, 5đ)\n" +
                    "2.Xuất danh sách đối tượng(1đ)\n" +
                    "3.Tìm SV theo khoảng mã sinh viên(1đ)\n" +
                    "4.Xóa sinh viên theo mã nhập và thông báo không tìm thấy(1đ)\n" +
                    "0.Thoát");
                Console.WriteLine("Nhập lựa chọn của bạn:");
                selection = Convert.ToInt32(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("1.Nhập 1 danh sách đối tượng");
                        ql.themThongTin();
                        break;
                    case 2:
                        Console.WriteLine("2.Xuất danh sách đối tượng");
                        ql.inThongTin();
                        break;
                    case 3:
                        Console.WriteLine("3.Tìm SV theo khoảng mã sinh viên");
                        ql.TimSV();
                        break;
                    case 4:
                        Console.WriteLine("4.Xóa sinh viên theo mã nhập và thông báo không tìm thấy");
                        ql.RemoveByLinq();
                        break;
                    case 5:
                        Console.WriteLine("5.Kiểm tra chuyên ngành hẹp");
                        Console.WriteLine("Mời nhập mã chuyên ngành bạn muốn kiểm tra");
                        Console.WriteLine($"{sv.SinhVienFPOLY(Convert.ToInt32(Console.ReadLine()))}");
                        break;
                    case 0:
                        Console.WriteLine("0.Thoát");
                        break;
                    default:
                        break;
                }
            } while (selection <= 5);
        }
    }
}
