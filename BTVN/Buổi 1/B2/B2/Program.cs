using System;
using System.Text;

namespace B2
{
    class Program
    {
        static void HT()
        {
            Console.Write("Nhập bán kính hình tròn ");
            float r = float.Parse(Console.ReadLine());
            Console.WriteLine("Diện tích hình tròn = " + (r * r * 3.14));
        }
        static void HCN()
        {
            Console.Write("Nhập chiều dài: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập chiều rộng: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Diện tích hình chữ nhật = " + (a*b));
        }
        static void HTG()
        {
            Console.Write("Nhập chiều cao: ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh đáy: ");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Diện tích hình tam giác = " + (h*day/2));
        }
        static void Choice()
        {
            Console.WriteLine("1 : Hình tròn");
            Console.WriteLine("2 : Hình chữ nhật");
            Console.WriteLine("3 : Hình tam giác");
            Console.WriteLine("Nhập loại hình để tính diện tích: ");
            int choice = int.Parse(Console.ReadLine());
            if (choice % 3 == 1)
            {
                Console.Write("Bạn chọn 1 đúng không(Y/n): ");
                string n = Console.ReadLine();
                if (n == "y" || n == "")
                {
                    HT();
                }
                else
                {
                    Choice();
                }
            }
            if (choice % 3 == 2)
            {
                Console.Write("Bạn chọn 2 đúng không(Y/n): ");
                string n = Console.ReadLine();
                if (n == "y" || n == "")
                {
                    HCN();
                }
                else
                {
                    Choice();
                }
            }
            if (choice % 3 == 0)
            {
                Console.Write("Bạn chọn 3 đúng không(Y/n): ");
                string n = Console.ReadLine();
                if (n == "y" || n == "")
                {
                    HTG();
                }
                else
                {
                    Choice();
                }
            }

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Choice();

        }
    }
}
