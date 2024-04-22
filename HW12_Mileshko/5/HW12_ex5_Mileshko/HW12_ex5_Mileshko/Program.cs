using System;

public class MobileNetwork
{
    public string Name { get; set; }
}

public class MobilePhone<T> where T : MobileNetwork
{
    public T Network { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("HW12_ex5_Mileshko");
        MobileNetwork network = new MobileNetwork { Name = "MyNetwork" };
        MobilePhone<MobileNetwork> phone1 = new MobilePhone<MobileNetwork> { Network = network };

        Console.WriteLine($"Phone1 Network: {phone1.Network.Name}");

        MobileNetwork childNetwork = new MobileNetwork { Name = "ChildNetwork" };
        MobilePhone<MobileNetwork> phone2 = new MobilePhone<MobileNetwork> { Network = childNetwork };

        Console.WriteLine($"Phone2 Network: {phone2.Network.Name}");
        Console.WriteLine($"Phone3 Network: {phone2.Network.Name}");
        Console.WriteLine($"Phone4 Network: {phone2.Network.Name}");
        Console.ReadKey();
    }
}