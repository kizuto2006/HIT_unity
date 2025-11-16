using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<CongNhan> danhSach = new List<CongNhan>();

            while (true)
            {
                Console.WriteLine("MENU ");
                Console.WriteLine("1. Thêm công nhân");
                Console.WriteLine("2. Hiển thị danh sách");
                Console.WriteLine("3. Sắp xếp theo họ tên và lương");
                Console.WriteLine("4. Tìm công nhân theo mã");
                Console.WriteLine("5. Thoát");
                Console.Write("Chọn chức năng (1-5): ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ThemCongNhan(danhSach);
                        break;
                    case 2:
                        HienThiDanhSach(danhSach);
                        break;
                    case 3:
                        SapXepDanhSach(danhSach);
                        break;
                    case 4:
                        TimCongNhanTheoMa(danhSach);
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            }
        }

        static void ThemCongNhan(List<CongNhan> ds)
        {
            Console.Write("Nhập mã công nhân: ");
            string ma = Console.ReadLine();

            if (ds.Any(c => c.MaCongNhan == ma))
            {
                Console.WriteLine("Mã công nhân đã tồn tại!");
                return;
            }

            Console.Write("Họ tên: ");
            string hoTen = Console.ReadLine();
            int tuoi;
            do
            {
                Console.Write("Tuổi (>0): ");
                if (!int.Parse(Console.ReadLine()) <= 0)
                    Console.WriteLine("Tuổi không hợp lệ! Vui lòng nhập lại.");
            } while (tuoi <= 0);

            Console.Write("Địa chỉ: ");
            string diaChi = Console.ReadLine();

            Console.WriteLine("Chọn chức vụ:");
            Console.WriteLine("0. Trưởng nhóm");
            Console.WriteLine("1. Phó nhóm");
            Console.WriteLine("2. Công nhân bậc 3");
            Console.WriteLine("3. Công nhân bậc 2");
            Console.WriteLine("4. Công nhân bậc 1");
            Console.WriteLine("5. Khác");
            Console.Write("Nhập số tương ứng: ");
            int chucVuInt = int.Parse(Console.ReadLine());
            if (chucVuInt < 0 || chucVuInt > 5) chucVuInt = 5;

            ChucVu cv = (ChucVu)chucVuInt;

            CongNhan cn = new CongNhan(ma, hoTen, tuoi, diaChi, cv);
            ds.Add(cn);

            Console.WriteLine("Đã thêm công nhân thành công!");
        }

        static void HienThiDanhSach(List<CongNhan> ds)
        {
            if (ds.Count == 0)
            {
                Console.WriteLine("Danh sách trống!");
                return;
            }

            Console.WriteLine("\n--- DANH SÁCH CÔNG NHÂN ---");
            Console.WriteLine($"{"Mã",-10} {"Họ tên",-20} {"Tuổi",5} {"Địa chỉ",-15} {"Chức vụ",-18} {"Lương",15}");
            Console.WriteLine(new string('-', 80));

            foreach (var cn in ds)
            {
                Console.WriteLine($"{cn.MaCongNhan,-10} {cn.HoTen,-20} {cn.Tuoi,5} {cn.DiaChi,-15} {cn.ChucVu,-18} {cn.TinhLuong(),15:N0}");
            }
        }
        static void SapXepDanhSach(List<CongNhan> ds)
        {
            if (ds.Count == 0)
            {
                Console.WriteLine("Danh sách trống!");
                return;
            }

            var ketQua = ds.OrderBy(c => c.HoTen)
                           .ThenBy(c => c.TinhLuong())
                           .ToList();

            Console.WriteLine("Danh sách sau khi sắp xếp:");
            HienThiDanhSach(ketQua);
        }
        static void TimCongNhanTheoMa(List<CongNhan> ds)
        {
            Console.Write("Nhập mã công nhân cần tìm: ");
            string ma = Console.ReadLine();

            var cn = ds.FirstOrDefault(c => c.MaCongNhan == ma);
            if (cn != null)
            {
                Console.WriteLine($"Tìm thấy: {cn.MaCongNhan} - {cn.HoTen}, {cn.ChucVu}, Lương: {cn.TinhLuong():N0}");
            }
            else
            {
                Console.WriteLine("❌ Không tìm thấy công nhân!");
            }
        }
    }


}
