using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeaBattle.Game;


namespace SeaBattle
{
    public partial class FormMain : System.Windows.Forms.Form
    {

        private GameBoard playerBoard;
        private GameBoard computerBoard;

        private Random random = new Random();

        private bool playerTurn = true;

        private Queue<Point> targetCells = new Queue<Point>();
        private List<Point> currentHits = new List<Point>();

        private int playerShots = 0;
        private int playerHits = 0;

        private int computerShots = 0;
        private int computerHits = 0;
        public FormMain()
        {
            InitializeComponent();

            playerBoard = new GameBoard();
            computerBoard = new GameBoard();

            InitializeGrid(dgvPlayer);
            InitializeGrid(dgvComputer);
            dgvComputer.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvComputer.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvPlayer.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvPlayer.DefaultCellStyle.SelectionForeColor = Color.Black;
            
            dgvComputer.CellClick += dgvComputer_CellClick;

            dgvPlayer.ClearSelection();
            dgvComputer.ClearSelection();

            dgvComputer.Enabled = false;
        }

        private void InitializeGrid(DataGridView dgv)
        {
            dgv.Columns.Clear();
            dgv.Rows.Clear();

            for (int i = 0; i < 10; i++)
            {
                DataGridViewTextBoxColumn col =
                    new DataGridViewTextBoxColumn();

                col.Width = 35;

                col.HeaderText =
                    ((char)('A' + i)).ToString();

                dgv.Columns.Add(col);
            }

            dgv.Rows.Add(10);

            for (int i = 0; i < 10; i++)
            {
                dgv.Rows[i].Height = 35;

                dgv.Rows[i].HeaderCell.Value =
                    (i + 1).ToString();
            }

            dgv.RowHeadersWidth = 50;
        }

        private void DrawPlayerBoard()
        {
            for (int r = 0; r < 10; r++)
            {
                for (int c = 0; c < 10; c++)
                {
                    dgvPlayer.Rows[r].Cells[c].Style.BackColor =
                        Color.White;

                    if (playerBoard.Cells[r, c] ==
                        CellState.Ship)
                    {
                        dgvPlayer.Rows[r]
                            .Cells[c]
                            .Style
                            .BackColor = Color.Gray;
                    }
                }
            }
        }

        private void DrawPlayerShots()
        {
            for (int r = 0; r < 10; r++)
            {
                for (int c = 0; c < 10; c++)
                {
                    if (playerBoard.Cells[r, c] == CellState.Hit)
                    {
                        dgvPlayer.Rows[r].Cells[c].Style.BackColor = Color.Red;
                    }

                    if (playerBoard.Cells[r, c] == CellState.Miss)
                    {
                        dgvPlayer.Rows[r].Cells[c].Style.BackColor = Color.LightBlue;
                    }
                }
            }
        }

        private void DrawComputerBoard()
        {
            for (int r = 0; r < 10; r++)
            {
                for (int c = 0; c < 10; c++)
                {
                    dgvComputer.Rows[r]
                               .Cells[c]
                               .Style.BackColor = Color.White;

                    if (computerBoard.Cells[r, c] == CellState.Hit)
                    {
                        dgvComputer.Rows[r]
                                   .Cells[c]
                                   .Style.BackColor = Color.Red;
                    }

                    if (computerBoard.Cells[r, c] == CellState.Miss)
                    {
                        dgvComputer.Rows[r]
                                   .Cells[c]
                                   .Style.BackColor = Color.LightBlue;
                    }
                }
            }
        }

        private void ClearBoards()
        {
            for (int r = 0; r < 10; r++)
            {
                for (int c = 0; c < 10; c++)
                {
                    dgvPlayer.Rows[r].Cells[c].Style.BackColor =
                        Color.White;

                    dgvComputer.Rows[r].Cells[c].Style.BackColor =
                        Color.White;
                }
            }
        }

        private void UpdateStatistics()
        {
            lblStatistics.Text =
                $"Пострілів гравця: {playerShots}\n" +
                $"Влучань гравця: {playerHits}\n\n" +
                $"Пострілів ПК: {computerShots}\n" +
                $"Влучань ПК: {computerHits}";
        }

        private void dgvPlayer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPlaceShips_Click(object sender, EventArgs e)
        {
            playerBoard = new GameBoard();

            playerBoard.PlaceShipsRandomly();

            DrawPlayerBoard();

            btnStartGame.Enabled = true;

            rtbInfo.AppendText(
                "Кораблі успішно розставлені.\n");
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            computerBoard = new GameBoard();

            computerBoard.PlaceShipsRandomly();

            DrawComputerBoard();

            dgvComputer.Enabled = true;

            rtbInfo.AppendText(
                "Гру розпочато.\n");

            btnStartGame.Enabled = false;
        }

        private void dgvComputer_CellClick( object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 ||
                e.ColumnIndex < 0)
                return;

            if (!playerTurn)
            {
                return;
            }

            playerShots++;

            bool hit =
                computerBoard.Shoot(
                    e.RowIndex,
                    e.ColumnIndex);

            if (hit)
            {
                playerHits++;
            }

            DrawComputerBoard();
            UpdateStatistics();
            dgvComputer.ClearSelection();
            if (computerBoard.AllShipsDestroyed())
            {
                MessageBox.Show("Ви перемогли!");

                dgvComputer.Enabled = false;

                return;
            }

            if (hit)
            {
                rtbInfo.AppendText(
                    "Влучання! Ваш хід продовжується.\n");

                if (computerBoard.IsShipSunk( e.RowIndex, e.ColumnIndex))
                {
                    Ship sunkShip =
                        computerBoard.GetShipAt(
                            e.RowIndex,
                            e.ColumnIndex);

                    MarkAroundSunkShip(
                        sunkShip,
                        computerBoard);

                    DrawComputerBoard();

                    rtbInfo.AppendText(
                        "Корабель противника потоплено!\n");
                }
            }
            else
            {
                rtbInfo.AppendText(
                    "Промах!\n");

                playerTurn = false;

                ComputerMove();
            }
        }


        private void ComputerMove()
        {
            int row;
            int col;

            if (targetCells.Count > 0)
            {
                Point target = targetCells.Dequeue();

                row = target.X;
                col = target.Y;
            }
            else
            {
                do
                {
                    row = random.Next(10);
                    col = random.Next(10);
                }
                while (
                    playerBoard.Cells[row, col] == CellState.Hit ||
                    playerBoard.Cells[row, col] == CellState.Miss);
            }

            computerShots++;

            bool hit = playerBoard.Shoot(row, col);

            if (hit)
            {
                computerHits++;
            }

            bool shipSunk = false;

            if (hit)
            {
                shipSunk =
                    playerBoard.IsShipSunk(row, col);
            }

            if (hit)
            {
                currentHits.Add(new Point(row, col));

                if (currentHits.Count == 1)
                {
                    AddNeighborCells(row, col);
                }
                else
                {
                    AddDirectionalTargets();
                }

                ComputerMove();

                return;
            }

            DrawPlayerBoard();
            DrawPlayerShots();
            UpdateStatistics();

            if (hit)
            {
                rtbInfo.AppendText(
                    $"Комп'ютер влучив ({row + 1};{col + 1})\n");

                if (shipSunk)
                {
                    Ship sunkShip =
                        playerBoard.GetShipAt(
                            row,
                            col);

                    MarkAroundSunkShip(
                        sunkShip,
                        playerBoard);

                    while (targetCells.Count > 0)
                    {
                        targetCells.Dequeue();
                    }

                    DrawPlayerBoard();
                    DrawPlayerShots();

                    rtbInfo.AppendText(
                        "Комп'ютер потопив ваш корабель!\n");
                }
            }
            else
            {
                rtbInfo.AppendText(
                    $"Комп'ютер промахнувся ({row + 1};{col + 1})\n");
            }

            if (playerBoard.AllShipsDestroyed())
            {
                MessageBox.Show(
                    "Переміг комп'ютер!");

                dgvComputer.Enabled = false;

                return;
            }

            playerTurn = true;
        }

        private void AddNeighborCells(int row, int col)
        {
            int[,] directions =
            {
        { -1, 0 },
        { 1, 0 },
        { 0, -1 },
        { 0, 1 }
    };

            for (int i = 0; i < 4; i++)
            {
                int newRow = row + directions[i, 0];
                int newCol = col + directions[i, 1];

                if (newRow >= 0 &&
                    newRow < 10 &&
                    newCol >= 0 &&
                    newCol < 10)
                {
                    if (playerBoard.Cells[newRow, newCol] != CellState.Hit &&
                        playerBoard.Cells[newRow, newCol] != CellState.Miss)
                    {
                        targetCells.Enqueue(
                            new Point(newRow, newCol));
                    }
                }
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            playerBoard = new GameBoard();
            computerBoard = new GameBoard();

            targetCells.Clear();
            currentHits.Clear();

            playerTurn = true;

            playerShots = 0;
            playerHits = 0;

            computerShots = 0;
            computerHits = 0;

            UpdateStatistics();

            ClearBoards();

            dgvPlayer.ClearSelection();
            dgvComputer.ClearSelection();

            rtbInfo.Clear();

            btnStartGame.Enabled = false;

            dgvComputer.Enabled = false;

            dgvComputer.Enabled = true;

            rtbInfo.AppendText(
                "Створено нову гру.\n");
        }

        private void MarkAroundSunkShip( Ship ship, GameBoard board)
        {
            foreach (Point cell in ship.Cells)
            {
                for (int r = cell.X - 1; r <= cell.X + 1; r++)
                {
                    for (int c = cell.Y - 1; c <= cell.Y + 1; c++)
                    {
                        if (r >= 0 &&
                            r < 10 &&
                            c >= 0 &&
                            c < 10)
                        {
                            if (board.Cells[r, c] ==
                                CellState.Empty)
                            {
                                board.Cells[r, c] =
                                    CellState.Miss;
                            }
                        }
                    }
                }
            }
        }

        private void AddDirectionalTargets()
        {
            if (currentHits.Count < 2)
                return;

            Point first = currentHits[0];
            Point second = currentHits[1];

            targetCells.Clear();

            if (first.X == second.X)
            {
                int row = first.X;

                int minCol =
                    currentHits.Min(p => p.Y);

                int maxCol =
                    currentHits.Max(p => p.Y);

                if (minCol - 1 >= 0)
                {
                    targetCells.Enqueue(
                        new Point(row,
                        minCol - 1));
                }

                if (maxCol + 1 < 10)
                {
                    targetCells.Enqueue(
                        new Point(row,
                        maxCol + 1));
                }
            }
            else
            {
                int col = first.Y;

                int minRow =
                    currentHits.Min(p => p.X);

                int maxRow =
                    currentHits.Max(p => p.X);

                if (minRow - 1 >= 0)
                {
                    targetCells.Enqueue(
                        new Point(
                            minRow - 1,
                            col));
                }

                if (maxRow + 1 < 10)
                {
                    targetCells.Enqueue(
                        new Point(
                            maxRow + 1,
                            col));
                }
            }
        }

    }
}
