using System;
using System.Data;
using System.Text;

namespace B3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine());
            if(n<= 0)
            {
                Console.WriteLine("Vui lòng thử lại");
            }
            else
            {
                for(int i = 1; i <= n; i++)
                {
                    for(int j = 1; j <= n-i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write(k);
                    }
                    for (int l = i-1; l >= 1; l--)
                    {
                        Console.Write(l);
                    }
                    Console.WriteLine("");
                }
            }
        }
    }
}