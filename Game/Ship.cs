using System.Collections.Generic;
using System.Drawing;

namespace SeaBattle.Game
{
    public class Ship
    {
        public List<Point> Cells { get; set; }

        public Ship()
        {
            Cells = new List<Point>();
        }

        public bool IsSunk(CellState[,] board)
        {
            foreach (var cell in Cells)
            {
                if (board[cell.X, cell.Y] != CellState.Hit)
                    return false;
            }

            return true;
        }
    }
}