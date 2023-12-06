namespace Lesson16.Block;

class Program
{
    static void Main()
    {
        Block block1 = new Block(1, 2, 3, 4);
        Block block2 = new Block(1, 2, 3, 4);
        Block block3 = new Block(4, 3, 2, 1);

        Console.WriteLine(block1); 
        Console.WriteLine("Block 1 equals Block 2? " + block1.Equals(block2));
        Console.WriteLine("Block 1 equals Block 3? " + block1.Equals(block3));
    }
}