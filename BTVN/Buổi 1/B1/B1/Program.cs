using System;
using System.Text;
namespace B1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Console.Write("Nhập cạnh thứ nhất: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh thứ hai: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh thứ ba: ");
            int c = int.Parse(Console.ReadLine());
            int canhhuyen, canh1, canh2;
            if (a > b && a > c) 
            {
                canhhuyen = a;
                canh1 = b;
                canh2 = c;
            }
            else
            {
                if (b > c)
                {
                    canhhuyen = b;
                    canh1 = c;
                    canh2 = a;
                }
                canhhuyen = c;
                canh1 = a;
                canh2 = b;
            }
            if(canhhuyen >= canh1+canh2)
            {
                Console.WriteLine("Ba thanh gõ này không thể ghép thành hình tam giác!");
                
            }
            else
            {
                if(canh1 == canh2)
                {
                    if(canh1 == canhhuyen)
                    {
                        Console.WriteLine("Đây là tam giác đều");
                    }
                    else
                    {
                        Console.WriteLine("Dây là tam giác cân");
                    }
                }
                else
                {
                    Console.WriteLine("Đây là tam giác thường");
                }
            }
            
        }
    }
}