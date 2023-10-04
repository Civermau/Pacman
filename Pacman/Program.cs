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
            if (Console.ForegroundColor != ConsoleColor.White)
                Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{"Pacman!",31}");

            map.SetInMap(pacman.position.x, pacman.position.y, '1');
            if (Console.KeyAvailable)
            {
                pacman.HandleInput();
            }
            pacman.TryMoveWithCollisionAndQueuedDir(map, '0');
            map.SetInMap(pacman.position.x, pacman.position.y, '5');
            //Console.WriteLine($"Pacman = ({pacman.position.x}, {pacman.position.y}), dir = {pacman.direction}, queuedDir = {pacman.queuedDir}");
            map.PrintMap();
            Thread.Sleep(300);
            Console.Clear();
        }
    }
}