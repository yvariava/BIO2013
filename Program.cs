namespace BIO_2013;
class Program
{
    static void Main(string[] args)
    {
        Problem1();
    }

    static void Problem1()
    {
        int[] inputTimes = Console.ReadLine().Split(' ').Select(x => int.Parse(x)+60).ToArray();
        TimeSpan currentTime0 = TimeSpan.FromMinutes(inputTimes[0]);
        TimeSpan currentTime1 = TimeSpan.FromMinutes(inputTimes[1]);
        while (currentTime0.Hours != currentTime1.Hours || currentTime0.Minutes != currentTime1.Minutes)
        {
            currentTime0 += TimeSpan.FromMinutes(inputTimes[0]);
            currentTime1 += TimeSpan.FromMinutes(inputTimes[1]);
        }
        Console.WriteLine(currentTime0.ToString("hh':'mm"));
    }
}
