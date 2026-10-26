using System;
using System.Collections.Generic;
using System.Text;

namespace Labyrinthe
{
    public class Labyrinth
    {
        public int Width { get; }
        public int Height { get; }
        public Tile[,] Map { get; }

        public Labyrinth(string s)
        {
            string[] lines = s.Split('\n');

            Height = lines.Length;
            Width = lines.Length > 0 ? lines[0].Length : 0;

            Map = new Tile[Height, Width];
        }

    }
}
