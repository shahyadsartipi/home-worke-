using System;
internal class Program
{
    private static void Main(string[] args)
    {
       Console.Write("inter a in ax^2 + bx + c : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write($"inter b in {a}x^2 + bx + c : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write($"inter c in {a}x^2 + {b}x + c : ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"finding the root of {a}(x^2) + {b}x + {c} ....");
            string x = CalTheRoot(a, b, c).x;
            string y = CalTheRoot(a, b, c).y;
            Console.WriteLine($"the roots of {a}(x^2) + {b}x + {c} is \nfirst => {x}\nSeconde is => {y}");
    }
    private static (string x, string y) CalTheRoot(int a, int b, int c)
    {
        double delta = Math.Pow(b, 2) - (4 * a * c);
        if (delta > 0)
        {
            double x = (((-b) + Math.Sqrt(delta)) / (2 * a));
            double y = (((-b) - Math.Sqrt(delta)) / (2 * a));
            return (x.ToString(), y.ToString());
        }
        else if (delta == 0)
        {
          double x = (((-b) / (2 * a)));
            return (x.ToString(), "Undifine");
        }
        else
        {
            return ("undefined", "undefined");
        }
    }
}