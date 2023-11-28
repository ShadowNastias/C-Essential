namespace Lesson4.IPlayable;

public class Player : IPlayable, IRecodable
{
    public void Play()
    {
        Console.WriteLine("Playing...");
    }

    public void Pause()
    {
        Console.WriteLine("Paused.");
    }

    public void Stop()
    {
        Console.WriteLine("Stopped.");
    }

    public void Record()
    {
        Console.WriteLine("Recording...");
    }
}