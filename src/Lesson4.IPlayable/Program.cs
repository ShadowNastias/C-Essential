namespace Lesson4.IPlayable;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player();
        
        player.Play();
        player.Pause();
        player.Stop();

        Console.WriteLine("-----");
        
        player.Record();
        player.Pause();
        player.Stop();
    }
}