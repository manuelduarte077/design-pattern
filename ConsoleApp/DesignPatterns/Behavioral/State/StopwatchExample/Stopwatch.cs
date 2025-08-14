namespace ConsoleApp.DesignPatterns.Behavioral.State.StopwatchExample;

public class Stopwatch
{
    private bool IsRunning { get; set; }

    public void click()
    {
        if (IsRunning)
        {
            IsRunning = false;
            Console.WriteLine("Stopped");
        }
        else
        {
            IsRunning = true;
            Console.WriteLine("Running");
        }
    }
}