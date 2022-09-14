using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            int a = 0;
            int b = 0;
            int res = 0;
            str = Console.ReadLine();
            if (str.Contains("+"))
            {
                try
                {
                    a = Convert.ToInt32(str.Split("+")[0]);
                    b = Convert.ToInt32(str.Split("+")[1]);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Что-то не так с числами...");
                }
                res = a + b;
            }
            else if (str.Contains("-"))
            {
                try
                {
                    a = Convert.ToInt32(str.Split("-")[0]);
                    b = Convert.ToInt32(str.Split("-")[1]);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Что-то не так с числами...");
                }
                res = a - b;
            }
            else if (str.Contains("*"))
            {
                try
                {
                    a = Convert.ToInt32(str.Split("*")[0]);
                    b = Convert.ToInt32(str.Split("*")[1]);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Что-то не так с числами...");
                }
                res = a * b;
            }
            else if (str.Contains("/"))
            {
                try
                {
                    a = Convert.ToInt32(str.Split("/")[0]);
                    b = Convert.ToInt32(str.Split("/")[1]);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Что-то не так с числами...");
                }
                try
                {
                    res = a / b;
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("А на ноль делить нельзя!");
                }
            }
            Console.WriteLine(res);
        }
    }
}
