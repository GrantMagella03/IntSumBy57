internal class Program
{
    private static void Main(string[] args)
    {
        float sum = 0;
        for (int idx = 0; idx <= 50; idx++)
        {
            if (idx % 5 == 0||idx % 7 == 0)
            {
                sum += idx;
            }
        }
        Console.WriteLine($"Sum:" + sum);
        float avg = sum / 50;
        Console.WriteLine($"Average: " + avg);
    }
}