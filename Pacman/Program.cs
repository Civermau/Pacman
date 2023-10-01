using System;
using System.Text;

class Program
{
    static void Main()
    {
        Map map = new Map();
        Pacman pacman = new Pacman(14, 23);

        Console.CursorVisible = true;
        Console.OutputEncoding = Encoding.Unicode;

        while (!pacman.isDead)
        {
            Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine($"{"Pacman!",31}");

            map.SetInMap(pacman.x, pacman.y, '1');
            if (Console.KeyAvailable)
            {
                pacman.HandleInput();
            }   
            pacman.Move();
            map.SetInMap(pacman.x, pacman.y, '5');
            Console.WriteLine($"Pacman = ({pacman.x}, {pacman.y})");
            map.PrintMap();
            Thread.Sleep(300);
            Console.Clear();
        }
    }
}