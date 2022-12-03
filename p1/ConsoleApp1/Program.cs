using System;
class test
{
    public static void Main(string[] args)
    {

        string a = Console.ReadLine();
        int x = Convert.ToInt32(a);

        Console.WriteLine(tavan_2(x));
        Console.WriteLine(tavan_3(x));
    }
    private static double tavan_2(int x)
    {


        double y = Math.Pow(x, 2);
        double z = Math.Pow(x, 3);
        return (y);
    }
    private static double tavan_3(int x)
    {
        double y = Math.Pow(x, 3);
        return (y);
    }
}
