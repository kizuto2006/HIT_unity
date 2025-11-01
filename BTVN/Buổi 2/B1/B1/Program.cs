using System;
using System.Collections;
using System.Text;
using System.Xml;
class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Hãy nhập một chuỗi dấu ngoặc ma thuật: ");
        string str = Console.ReadLine();
        if (IsValid(str)) { Console.WriteLine("Yes"); }
        else { Console.WriteLine("No"); }
        
    }
    static bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        foreach (char c in s)
        {
            if (c == '(' || c == '[' || c == '{')
                stack.Push(c);
            else
            {
                if (stack.Count == 0)
                    return false;
                char top = stack.Pop();
                if ((c == ')' && top != '(') ||
                    (c == ']' && top != '[') ||
                    (c == '}' && top != '{'))
                    return false;
            }
        }
        return stack.Count == 0;
    }
}