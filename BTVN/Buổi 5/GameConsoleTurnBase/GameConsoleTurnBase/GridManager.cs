using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleTurnBase
{
    internal class GridManager
    {
        public int Width {  get; private set; }
        public int Height {  get; private set; }
        public Tile[,] Grid {  get; private set; }
        public GridManager(int w,int h)
        {
            Width = w;
            Height = h;
            Grid = new Tile[w,h];
            SpawnTile();
        }

        public void SpawnTile()
        {
            for(int x =  0; x < Width; x++)
            {
                for(int y = 0; y < Height; y++)
                {
                    Grid[x,y] = new Tile(x,y);
                }
            }
        }

        public void UpdateGrid(Player p,List<Enemy> e)
        {
            foreach(var tile in Grid)
            {
                tile.Occupant = null;
            }
            Grid[p.PosX, p.PosY].Occupant = p;

            foreach(var enemy in e) { if(enemy.Hp > 0) { Grid[enemy.PosX, enemy.PosY].Occupant = enemy; } }
                
        }

        public void DrawGrid()
        {
            /*Console.SetCursorPosition(0, 0);*/
            for (var y = 0; y < Height;y++)
            {
                for(var  x = 0; x < Width;x++)
                {
                    if (Grid[x, y].Occupant is Player p)
                    {
                        Console.Write("P ");
                    }
                    else if (Grid[x, y].Occupant is Enemy e)
                    {
                        Console.Write("e ");
                    }
                    else 
                    {
                        Console.Write(". "); 
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
