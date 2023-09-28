using System;
using System.IO;

public class Map
{   
    readonly string mapPath = "Map.txt";
    static string[] mapInfo;

    public Map()
	{
        mapInfo = File.ReadAllLines(mapPath);

        int lines = mapInfo.Length;
        int columns = mapInfo[0].Length;

        char[,] map = new char[lines, columns];

        for (int i = 0; i < lines; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                map[i, j] = mapInfo[i][j];
            }
        }


        for (int i = 0; i < map.GetLength(0); i++)
        {
            for (int j = 0; j < map.GetLength(1); j++)
            {
                switch (map[i, j])
                {
                    case '0':
                        Console.Write("# ");
                        break;
                    case '1':
                        Console.Write("  ");
                        break;
                    case '2':
                        Console.Write(". ");
                        break;
                    case '3':
                        Console.Write("= ");
                        break;
                }
                
            }
            Console.WriteLine(); 
        }
    }
}
