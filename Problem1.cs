namespace BIO_2013;

public class Problem1
{
    private static string ProblemSimulation(int[] inputTimes)
    {
        TimeSpan currentTime0 = TimeSpan.FromMinutes(inputTimes[0]);
        TimeSpan currentTime1 = TimeSpan.FromMinutes(inputTimes[1]);
        while (currentTime0.Hours != currentTime1.Hours || currentTime0.Minutes != currentTime1.Minutes)
        {
            currentTime0 += TimeSpan.FromMinutes(inputTimes[0]);
            currentTime1 += TimeSpan.FromMinutes(inputTimes[1]);
        }
        return currentTime0.ToString("hh':'mm");
    }

    public static void SolveProblem1A()
    {
        int[] inputTimes = Console.ReadLine()!.Split(' ').Select(x => int.Parse(x)+60).ToArray();
        Console.WriteLine(ProblemSimulation(inputTimes));
    }
    
    public static void SolveProblem1B()
    {
        for (int i = 0; i < 20; i++)
        {
            if (ProblemSimulation([60, 60+i]) != "00:00")
            {
                Console.WriteLine(i);
            }
        }
    }
}
