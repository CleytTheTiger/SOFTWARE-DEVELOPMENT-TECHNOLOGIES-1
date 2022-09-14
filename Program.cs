using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            double a = 0;
            double b = 0;
            double res = 0;
            str = Console.ReadLine();
            if (str.Contains("+"))
            {
                a = Convert.ToDouble(str.Split("+")[0]);
                b = Convert.ToDouble(str.Split("+")[1]);
                res = a + b;
            }
            else if (str.Contains("-"))
            {
                a = Convert.ToDouble(str.Split("-")[0]);
                b = Convert.ToDouble(str.Split("-")[1]);
                res = a - b;
            }
            else if (str.Contains("*"))
            {
                a = Convert.ToDouble(str.Split("*")[0]);
                b = Convert.ToDouble(str.Split("*")[1]);
                res = a * b;
            }
            else if (str.Contains("/"))
            {
                a = Convert.ToDouble(str.Split("/")[0]);
                b = Convert.ToDouble(str.Split("/")[1]);
                res = a / b;
            }
            Console.WriteLine(res);
        }
    }
}
