namespace Lesson13.Chain;

class Program
{
    static void Main()
    {
        int width = Console.WindowWidth;
        int height = Console.WindowHeight;
        Console.CursorVisible = false;
        Random random = new Random();
        List<Chain>[] columns = new List<Chain>[width];

        // Ініціалізація стовпців з різними початковими позиціями
        for (int i = 0; i < width; i++)
        {
            columns[i] = new List<Chain>()
            {
                new Chain { Position = random.Next(-height, 0), Length = random.Next(3, height / 2) }
            };
        }

        while (true)
        {
            for (int x = 0; x < width; x++)
            {
                // Додавання нових ланцюжків з контрольованою затримкою
                if (columns[x].Count < 2 && random.NextDouble() < 0.02) // 2% шанс додати ланцюжок
                {
                    columns[x].Add(new Chain { Position = -random.Next(20), Length = random.Next(3, height / 2) });
                }

                UpdateColumn(columns[x], x, random, height);
            }

            Thread.Sleep(150);
        }
    }

    static void UpdateColumn(List<Chain> column, int x, Random random, int height)
    {
        for (int i = column.Count - 1; i >= 0; i--)
        {
            Chain currentChain = column[i];
            int position = currentChain.Position;
            if (position >= 0)
            {
                if (position < height)
                {
                    Console.SetCursorPosition(x, position);
                    Console.ForegroundColor = (i == 0 && position == 0) ? ConsoleColor.White :
                                              (i == 0 && position == 1) ? ConsoleColor.Green :
                                                                           ConsoleColor.DarkGreen;
                    Console.Write(GetRandomChar(random));
                }
                if (position - currentChain.Length >= 0)
                {
                    Console.SetCursorPosition(x, position - currentChain.Length);
                    Console.Write(' ');
                }
            }

            currentChain.Position++;
            if (currentChain.Position - currentChain.Length > height)
            {
                column.RemoveAt(i);
            }
        }
    }

    static char GetRandomChar(Random random)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return chars[random.Next(chars.Length)];
    }

    class Chain
    {
        public int Position;
        public int Length;
    }
}