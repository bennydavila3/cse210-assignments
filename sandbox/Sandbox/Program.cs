using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Welcome to my Cash Register!");

        Bin myBin = new("quarters", 40, (float).25);
        myBin.ModifyAmount(6);
        Console.WriteLine(myBin.TotalValue());
    }
}