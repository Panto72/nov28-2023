public class Program
{
     static void Main()
    {
        string[] fruits = { "Apple", "mango", "berry", "orange", "dragon fruite" };
        foreach(var data in fruits)
        {
            Console.WriteLine(data);
        }
        ArrrayLenght(fruits);
        serching(fruits);
        //ArrrayLenght(fruits);

        Console.ReadLine();
      

    }
    static void ArrrayLenght(string[] fruits)
    {
        Console.WriteLine($"number of fruits{fruits.Length}");
        //for(int i=0; i <= fruits.Length; i++)
        //{
        //    Console.WriteLine($"{fruits[i]}:{fruits[i].Length}");
        //}
        foreach (var a in fruits)
        {
            Console.WriteLine($"{a}:{a.Length}");
        }
    }
    static void serching(string[] fruits)
    {
        Console.Write("Enter the name of fruits:");
        string name = Console.ReadLine();
        bool fb = Array.Exists(fruits, c => c.Equals(name, StringComparison.OrdinalIgnoreCase));
        Console.WriteLine($"{name} is exist {(fb ? "is present" : "not present")} is th array.\n");
    }
}