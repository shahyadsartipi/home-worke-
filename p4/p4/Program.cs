using System;
class test
{
    public static void Main(string[] args)
    {
        GetAccounting();
    }

    private static void GetAccounting()
    {
        Console.Write("inter ur bank Account balance : ");
        double mojodi = Convert.ToDouble(Console.ReadLine());
        Console.Write("inter the yearly bounes persent : ");
        int sodeSalshomar = Convert.ToInt32(Console.ReadLine());
        Console.Write("inter the wanted balance to see how many years u need till u reach that : ");
        int mojodiJadid = Convert.ToInt32(Console.ReadLine());
        int i = 0;
        while (mojodiJadid >= mojodi)
        {
            mojodi = ((mojodi * sodeSalshomar / 100)) + mojodi;
            i++;
        }
        Console.WriteLine("=>u must waite {0} years to diposit ur curency",i);
        Console.ReadKey();
        
    }
   
}  