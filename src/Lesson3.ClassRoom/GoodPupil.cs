namespace Lesson3.ClassRoom;

public class GoodPupil : Pupil
{
    public override void Study() => Console.WriteLine("Good Studying");
    public override void Read() => Console.WriteLine("Good Reading");
    public override void Write() => Console.WriteLine("Good Writing");
    public override void Relax() => Console.WriteLine("Often Relaxing");
}