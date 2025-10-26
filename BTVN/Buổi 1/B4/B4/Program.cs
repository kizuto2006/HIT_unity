using System;
using System.Text;
namespace B4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập 3 chuỗi: ");
            Console.Write("-Chuỗi ban đầu: ");
            string a = Console.ReadLine();
            Console.Write("-Chuỗi cần tìm: ");
            string b = Console.ReadLine();
            Console.Write("-Chuỗi cần chèn: ");
            string c = Console.ReadLine();
            int answer = a.IndexOf(b);
            if(answer == -1)
            {
                Console.WriteLine("Không thể ghép từ - đoạn không tồn tại!");
            }
            else
            {
                for (int i = 0; i < answer; i++)
                {
                    Console.Write(a[i]);
                }
                Console.Write(c);
                Console.Write(" ");
                for (int i = answer; i < a.Length; i++)
                {
                    Console.Write(a[i]);
                }
            }
                
        }
    }
}