Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Write("Nhập chuỗi kí tự: ");
string a = Console.ReadLine();
Console.Write("Chuỗi kí tự đã đảo ngược: ");
for(int i = a.Length - 1; i >= 0; i--)
{
    Console.Write(a[i]);
}
Console.WriteLine();