namespace Lesson3.ClassRoom;

public class Program
{
    public static void Main(string[] args)
    {
        ClassRoom classRoom = new ClassRoom(new ExcelentPupil(), new GoodPupil(), new BadPupil());
        classRoom.DisplayActivities();
    }
}