using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;
            DrawScreen();
        }
        static void DrawScreen()
        {
        Line();
        Column();
        Line();

        }
        static void Line()
        {
             Console.Write("+");
            for (int i = 0; i <= 30; i++ )
                Console.Write("-");
            Console.Write("+");
            Console.Write("\n");
        }
        static void Column()
        {
            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++ )
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }
        }
    }
}	