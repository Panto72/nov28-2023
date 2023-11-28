public class Program
{
    public static void Main()
    {
        int[][] multidymentionArray = {
            new int[] { 1,2,3,4},
            new int[] { 1,0,6},
            new int[] { 1,2,3,4}
        };
        Console.WriteLine(multidymentionArray[1][2]);
        for(int i = 0; i < multidymentionArray.Length; i++)
        {
            for(int j = 0;j< multidymentionArray[i].Length; j++)
            {
                Console.Write(multidymentionArray[i][j]);
            }
            Console.Write("\n");
        }
    }
}