public class Breathing : Activity
{
    public Breathing() : base(
        "Breathing",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartMessage();

        DateTime end = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < end)
        {
            Console.Write("\nBreathe in... ");
            ShowCountDown(4);
            Console.Write("\nBreathe out... ");
            ShowCountDown(6);
        }

        DisplayEndMessage();
    }
}
