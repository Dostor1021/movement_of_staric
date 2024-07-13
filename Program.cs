using System;

class Program
{
    static void Main()
    {
        int x = 0, y = 0; 

        Console.CursorVisible = false; 

        
        steric(x, y);

        while (true)
        {
            ConsoleKey key = Console.ReadKey(true).Key;


            removeAsteric(x, y);


            if (key == ConsoleKey.NumPad6)
            {
                x++;
            }
            else if (key == ConsoleKey.NumPad4)
            {
                x--;
            }
            else if (key == ConsoleKey.NumPad2)
            {
                y++;
            }
            else if (key == ConsoleKey.NumPad8)
            {
                y--;
            }


            steric(x, y);
        }
    }

    static void steric(int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Console.Write("*");
    }

    static void removeAsteric(int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(" ");
    }
}
