namespace Lesson7.Train;

public struct Train
{
    public string Destination;
    public int TrainNumber;
    public DateTime DepartureTime;

    public Train(string destination, int trainNumber, DateTime departureTime)
    {
        Destination = destination;
        TrainNumber = trainNumber;
        DepartureTime = departureTime;
    }
}