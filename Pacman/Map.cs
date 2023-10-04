public class Map
{   
    readonly string mapPath = "Map.txt";
    static string[]? mapInfo;

    int lines;
    int columns;

    public char[,] map;
    /// <summary>
    /// Instantiates map, read the map file and generates the array
    /// </summary>
    public Map()
	{
        mapInfo = File.ReadAllLines(mapPath);
        lines = mapInfo.Length;
        columns = mapInfo[0].Length;

        map = new char[lines, columns];

        for (int i = 0; i < lines; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                map[i, j] = mapInfo[i][j];
            }
        }
        //Console.WriteLine($"{lines}, {columns}");
        //Thread.Sleep(5000);
    }

    /// <summary>
    /// Prints the map in console
    /// </summary>
    public void PrintMap()
    {
        Console.WriteLine(map);
        for (int i = 0; i < map.GetLength(0); i++)
        {
            for (int j = 0; j < map.GetLength(1); j++)
            {
                switch (map[i, j])
                {
                    case '0':
                        if(Console.ForegroundColor != ConsoleColor.DarkBlue)
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("# ");
                        break;
                    case '1':
                        Console.Write("  ");
                        break;
                    case '2':
                        if(Console.ForegroundColor != ConsoleColor.White)
                            Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(". ");
                        break;
                    case '3':
                        if (Console.ForegroundColor != ConsoleColor.White)
                            Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("• ");
                        break;
                    case '4':
                        if (Console.ForegroundColor != ConsoleColor.White)
                            Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("| ");
                        break;
                    case '5':
                        if(Console.ForegroundColor != ConsoleColor.Yellow)
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("0 ");
                        break;
                }
            }
            //Thread.Sleep(30);
            if (Console.ForegroundColor != ConsoleColor.White)
                Console.ForegroundColor = ConsoleColor.White;
            Console.Write(i.ToString());
            Console.WriteLine();
        }
    }

    /// <summary>
    /// Modifyes a value in the map array to the desired one
    /// 0: Wall
    /// 1: White space (if pacman had eaten the dot)
    /// 2: Dot
    /// 3: Power Pellet
    /// 4: Warp
    /// 5: Pacman (Should only be one)
    /// </summary>
    public void SetInMap(int x, int y, char value)
    {
        map[y, x] = value;
    }
    public char ReturnIndex(int x, int y)
    {
        return map[y, x];
    }
    public char characterAtIndex(int x, int y, char character)
    {
        return map[y, x];
    }

}
