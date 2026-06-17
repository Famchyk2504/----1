using System.Collections.Generic;
using System;
using System.Drawing;

namespace SeaBattle.Game
{
    public class GameBoard
    {
        public const int Size = 10;

        public CellState[,] Cells { get; private set; }

        private Random random = new Random();

        public List<Ship> Ships { get; private set; }

        public GameBoard()
        {
            Cells = new CellState[Size, Size];
            Ships = new List<Ship>();
        }

        public void PlaceShipsRandomly()
        {
            Ships.Clear();

            Cells = new CellState[Size, Size];

            PlaceShip(4);

            PlaceShip(3);
            PlaceShip(3);

            PlaceShip(2);
            PlaceShip(2);
            PlaceShip(2);

            PlaceShip(1);
            PlaceShip(1);
            PlaceShip(1);
            PlaceShip(1);
        }

        private void PlaceShip(int length)
        {
            bool placed = false;

            while (!placed)
            {
                bool horizontal = random.Next(2) == 0;

                int row = random.Next(Size);
                int col = random.Next(Size);

                if (CanPlaceShip(row, col, length, horizontal))
                {
                    Ship ship = new Ship();

                    for (int i = 0; i < length; i++)
                    {
                        int r = row;
                        int c = col;

                        if (horizontal)
                            c += i;
                        else
                            r += i;

                        Cells[r, c] = CellState.Ship;

                        ship.Cells.Add(new Point(r, c));
                    }

                    Ships.Add(ship);

                    placed = true;
                }
            }
        }

        private bool CanPlaceShip(
    int row,
    int col,
    int length,
    bool horizontal)
        {
            for (int i = 0; i < length; i++)
            {
                int r = row;
                int c = col;

                if (horizontal)
                    c += i;
                else
                    r += i;

                if (r >= Size || c >= Size)
                    return false;

                if (Cells[r, c] != CellState.Empty)
                    return false;

                for (int rr = r - 1; rr <= r + 1; rr++)
                {
                    for (int cc = c - 1; cc <= c + 1; cc++)
                    {
                        if (rr >= 0 &&
                            rr < Size &&
                            cc >= 0 &&
                            cc < Size)
                        {
                            if (Cells[rr, cc] == CellState.Ship)
                                return false;
                        }
                    }
                }
            }

            return true;
        }

        public bool Shoot(int row, int col)
        {
            if (Cells[row, col] == CellState.Hit ||
                Cells[row, col] == CellState.Miss)
            {
                return false;
            }

            if (Cells[row, col] == CellState.Ship)
            {
                Cells[row, col] = CellState.Hit;
                return true;
            }

            Cells[row, col] = CellState.Miss;

            return false;
        }

        public bool AllShipsDestroyed()
        {
            foreach (Ship ship in Ships)
            {
                if (!ship.IsSunk(Cells))
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsShipSunk(int row, int col)
        {
            foreach (Ship ship in Ships)
            {
                foreach (Point point in ship.Cells)
                {
                    if (point.X == row && point.Y == col)
                    {
                        return ship.IsSunk(Cells);
                    }
                }
            }

            return false;
        }

        public Ship GetShipAt(int row, int col)
        {
            foreach (Ship ship in Ships)
            {
                foreach (Point point in ship.Cells)
                {
                    if (point.X == row &&
                        point.Y == col)
                    {
                        return ship;
                    }
                }
            }

            return null;
        }

    }

}