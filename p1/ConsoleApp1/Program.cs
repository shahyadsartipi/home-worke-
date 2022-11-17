using System;
class test
{
public static void Main(string[] args)
    {
       
        int  a = Convert.ToInt32(Console.ReadLine());
        double x = Math.Pow(a, 2);
        double y = Math.Pow(x, 3);
        Console.WriteLine(y);
        Console.WriteLine(x);
    }

}