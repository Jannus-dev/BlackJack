namespace BlackJack;

public class Berichten
{
    public void Welkom()
    {
        Console.BackgroundColor
            = ConsoleColor.DarkGreen;
        Console.ForegroundColor
            = ConsoleColor.DarkGreen;
        for (int b = 0; b < 13; b++)
        {
            Console.WriteLine();
            Thread.Sleep(10);
            for (int i = 0; i < 240; i++)
            {
                Console.Write("■");
            }
        }

        Console.WriteLine();
        Thread.Sleep(10);
        for (int i = 0; i < 110; i++)
        {
            Console.Write("■");
        }

        //text in het midden van het scherm
        Console.ForegroundColor
            = ConsoleColor.Black;

        string text = "Welkom bij BlackJack";
        foreach (char c in text)
        {
            Console.Write(c);
        }


        Console.ForegroundColor
            = ConsoleColor.DarkGreen;
        for (int i = 0; i < 110; i++)
        {
            Console.Write("■");
        }

        for (int b = 0; b < 13; b++)
        {
            Console.WriteLine();
            Thread.Sleep(10);
            for (int i = 0; i < 240; i++)
            {
                Console.Write("■");
            }
        }
    }
}