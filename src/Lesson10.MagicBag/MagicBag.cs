namespace Lesson10.MagicBag;

public class MagicBag<T> where T : ICreature
{
    private readonly Dictionary<string, bool> _giftsGivenToday = new Dictionary<string, bool>();

    public void GetGift(T creature)
    {
        if (!_giftsGivenToday.ContainsKey(creature.CreatureType))
        {
            _giftsGivenToday[creature.CreatureType] = true;
            Console.WriteLine($"Creature of type {creature.CreatureType} receives a gift!");
        }
        else
        {
            Console.WriteLine($"Creature of type {creature.CreatureType} has already received a gift today.");
        }
    }

    public void ResetGifts()
    {
        _giftsGivenToday.Clear();
        Console.WriteLine("Gifts have been reset!");
    }
}