using System;

using System.Text;

namespace B4
{
    class Program
    {
        static float AvgScore(int[] score,int n)
        {
            int scoreSum = 0;
            for (int i = 0; i < n; i++)
            {
                scoreSum += score[i];
            }
            return (float)scoreSum/n;
        }
        static int Max(int[] score, int n)
        {
            int max = score[0];
            for (int i = 0; i < n; i++)
            {
                if (score[i] > max) 
                { max = score[i]; }
            }
            return max;
        }
        static int Min(int[] score, int n)
        {
            int min = score[0];
            for (int i = 0; i < n; i++)
            {
                if (score[i] < min) { min = score[i]; }
            }
            return min;
        }
        static float Percent(int[] score,int n)
        {
            float approve = 0;
            for (int i = 0; i < n; i++)
            {
                if (score[i] >= 5) { approve++; }
            }
            return (approve*100) / (float)n;
        }
        static int Filter(int[] score,int n,double LowRow,double HighRow)
        {
            int count = 0;
            for(int i=0;i<n;i++)
            {
                if ((double)score[i] >= LowRow && (double)score[i] <= HighRow) { count++; }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số lượng học sinh: ");
            int n = int.Parse(Console.ReadLine());
            int[] score = new int[n];
            for(int i = 0;i<n;i++)
            {
                Console.Write($"Điểm {i+1}: ");
                score[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Điểm trung bình lớp: "+ AvgScore(score,n));
            Console.WriteLine("Điểm cao nhất: " + Max(score, n));
            Console.WriteLine("Điểm thấp nhất: " + Min(score, n));
            Console.WriteLine($"Tỉ lệ đạt:      {Percent(score,n)}%");
            Console.WriteLine("Phân loại: ");
            Console.WriteLine($"-Hs giỏi:       {Filter(score, n, 8, 10)} học sinh ");
            Console.WriteLine($"-Hs khá:        {Filter(score, n, 6.5, 7.9)} học sinh ");
            Console.WriteLine($"-Hs trung bình: {Filter(score, n, 5, 6.4)} học sinh ");
            Console.WriteLine($"-Hs yếu:        {Filter(score, n, 0, 4.9)} học sinh ");

        }
    }
}