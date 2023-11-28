public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter Karims amount:");
        double KarimX = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Rahims amount:");
        double RahimY = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter price of dew:");
        Double Dew = Convert.ToDouble(Console.ReadLine());
        double PriceofDew = KarimX + RahimY;
        if (PriceofDew >= Dew)
        {
            Console.WriteLine("yes");

        }
        else
        {
            Console.WriteLine("no");
        }
    }

}