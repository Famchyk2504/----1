using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; 

namespace MythologicalCharacters
{
    public partial class Form1 : Form
    {
        OleDbConnection connection;
        OleDbDataAdapter adapter;
        DataTable table;
        int selectedId = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            string connectionString =
        @"Provider=Microsoft.ACE.OLEDB.12.0;
          Data Source=D:\OOP-Lab\Mythology.accdb";

            connection =
                new OleDbConnection(connectionString);

            adapter =
                new OleDbDataAdapter(
                    "SELECT * FROM Characters",
                    connection);

            table = new DataTable();

            adapter.Fill(table);

            dgvCharacters.DataSource = null;
            dgvCharacters.DataSource = table;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string query =
                 "INSERT INTO [Characters] ([Name], [Mythology], [Gender], [Description], [Image]) " + "VALUES (?, ?, ?, ?, ?)";

                OleDbCommand cmd = new OleDbCommand(query, connection);

                cmd.Parameters.AddWithValue("@p1", txtName.Text);
                cmd.Parameters.AddWithValue("@p2", txtMythology.Text);
                cmd.Parameters.AddWithValue("@p3", txtGender.Text);
                cmd.Parameters.AddWithValue("@p4", txtDescription.Text);
                cmd.Parameters.AddWithValue("@p5", "");

                cmd.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Персонажа додано!");

                LoadData();

                txtName.Clear();
                txtMythology.Clear();
                txtGender.Clear();
                txtDescription.Clear();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCharacters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvCharacters.Rows[e.RowIndex];

                selectedId =
                 Convert.ToInt32(
                row.Cells["CharacterID"].Value);

                txtName.Text =
                    row.Cells["Name"].Value.ToString();

                txtMythology.Text =
                    row.Cells["Mythology"].Value.ToString();

                txtGender.Text =
                    row.Cells["Gender"].Value.ToString();

                txtDescription.Text =
                    row.Cells["Description"].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedId == -1)
                {
                    MessageBox.Show(
                        "Оберіть персонажа!");

                    return;
                }

                connection.Open();

                string query =
                    "UPDATE Characters " +
                    "SET Name=?, " +
                    "Mythology=?, " +
                    "Gender=?, " +
                    "Description=? " +
                    "WHERE CharacterID=?";

                OleDbCommand cmd =
                    new OleDbCommand(
                        query,
                        connection);

                cmd.Parameters.AddWithValue(
                    "@p1",
                    txtName.Text);

                cmd.Parameters.AddWithValue(
                    "@p2",
                    txtMythology.Text);

                cmd.Parameters.AddWithValue(
                    "@p3",
                    txtGender.Text);

                cmd.Parameters.AddWithValue(
                    "@p4",
                    txtDescription.Text);

                cmd.Parameters.AddWithValue(
                    "@p5",
                    selectedId);

                cmd.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show(
                    "Дані змінено!");

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                if (connection.State ==
                    ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedId == -1)
                {
                    MessageBox.Show(
                        "Оберіть персонажа!");

                    return;
                }

                DialogResult result =
                    MessageBox.Show(
                        "Ви дійсно хочете видалити персонажа?",
                        "Підтвердження",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return;

                connection.Open();

                string query =
                    "DELETE FROM Characters " +
                    "WHERE CharacterID=?";

                OleDbCommand cmd =
                    new OleDbCommand(
                        query,
                        connection);

                cmd.Parameters.AddWithValue(
                    "@p1",
                    selectedId);

                cmd.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show(
                    "Персонажа видалено!");

                selectedId = -1;

                txtName.Clear();
                txtMythology.Clear();
                txtGender.Clear();
                txtDescription.Clear();

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                if (connection.State ==
                    ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (txtSearch.Text.Trim() == "")
            {
                LoadData();
                return;
            }

            try
            {
                string search =
                    txtSearch.Text.Trim();

                string connectionString =
                    @"Provider=Microsoft.ACE.OLEDB.12.0;
              Data Source=D:\OOP-Lab\Mythology.accdb";

                connection =
                    new OleDbConnection(
                        connectionString);

                string query =
                    "SELECT * FROM Characters " +
                    "WHERE Name LIKE ? " +
                    "OR Mythology LIKE ?";

                adapter =
                    new OleDbDataAdapter(
                        query,
                        connection);

                adapter.SelectCommand.Parameters
                       .AddWithValue(
                           "@p1",
                           "%" + search + "%");

                adapter.SelectCommand.Parameters
                       .AddWithValue(
                           "@p2",
                           "%" + search + "%");

                table = new DataTable();

                adapter.Fill(table);

                dgvCharacters.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReport1_Click(object sender, EventArgs e)
        {
            try
            {
                string query =
                    "SELECT CharacterID, Name, Mythology, Gender, Description " +
                    "FROM Characters";

                adapter = new OleDbDataAdapter(query, connection);

                DataTable reportTable = new DataTable();

                adapter.Fill(reportTable);

                dgvCharacters.DataSource = reportTable;

                MessageBox.Show("Звіт сформовано!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReport2_Click(object sender, EventArgs e)
        {
            try
            {
                string query =
                    "SELECT Characters.Name, " +
                    "Characters.Mythology, " +
                    "Powers.PowerName " +
                    "FROM Characters " +
                    "INNER JOIN Powers " +
                    "ON Characters.CharacterID = Powers.CharacterID";

                adapter = new OleDbDataAdapter(query, connection);

                DataTable reportTable = new DataTable();

                adapter.Fill(reportTable);

                dgvCharacters.DataSource = reportTable;

                MessageBox.Show("Звіт сформовано!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
