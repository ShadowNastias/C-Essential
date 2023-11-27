namespace Lesson3.ClassRoom;

public class ClassRoom
{
    private List<Pupil> pupils = new List<Pupil>();

    public ClassRoom(Pupil p1, Pupil p2, Pupil p3 = null, Pupil p4 = null)
    {
        pupils.Add(p1);
        pupils.Add(p2);
        if (p3 != null) pupils.Add(p3);
        if (p4 != null) pupils.Add(p4);
    }

    public void DisplayActivities()
    {
        foreach (var pupil in pupils)
        {
            pupil.Study();
            pupil.Read();
            pupil.Write();
            pupil.Relax();
            Console.WriteLine();
        }
    }
}



