using System;

namespace les4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Room room1 = new Room(2, 2);
        }
    }

    class Tiles
    {
    }
    class Room
    {
        Tiles[][] tileMap;

        public Room(int width, int height)
        {
            tileMap = new Tiles[height][];
            for (int i = 0; i < tileMap.Length; i++)
            {
                tileMap[i] = new Tiles[width];
                for (int K = 0; K < tileMap[i].Length; K++)
                {
                    tileMap[i][K] = new Tiles();
                }
            }
        }
    }
}