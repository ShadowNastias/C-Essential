namespace Lesson3.ClassRoom;

public class BadPupil : Pupil
{
    public override void Study() => Console.WriteLine("Bad Studying");
    public override void Read() => Console.WriteLine("Bad Reading");
    public override void Write() => Console.WriteLine("Bad Writing");
    public override void Relax() => Console.WriteLine("Always Relaxing");
}