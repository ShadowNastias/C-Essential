namespace Lesson10.MagicBag;

class Program
{
    static void Main(string[] args)
    {
        var magicBag = new MagicBag<ICreature>();

        var elf = new Creature("Elf");
        var dwarf = new Creature("Dwarf");

        magicBag.GetGift(elf); // Elf отримує подарунок
        magicBag.GetGift(dwarf); // Dwarf отримує подарунок
        magicBag.GetGift(elf); // Elf вже отримав подарунок сьогодні

        magicBag.ResetGifts(); // Скидання подарунків

        magicBag.GetGift(elf); // Elf знову може отримати подарунок
    }
}

public class Creature : ICreature
{
    public string CreatureType { get; }

    public Creature(string creatureType)
    {
        CreatureType = creatureType;
    }
}