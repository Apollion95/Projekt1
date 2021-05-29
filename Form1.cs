using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dapper;


namespace Projekt1
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=DESKTOP-BR95J8J\SQLEXPRESS;Initial Catalog=WypozyczalniaFilmowDB;Integrated Security=True;Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False;MultipleActiveResultSets=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Lista Filmow
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlDataAdapter SqlData = new SqlDataAdapter("SELECT * FROM dbo.Film", sqlcon);
                DataTable dataTable = new DataTable();
                SqlData.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Dostepnosc
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlDataAdapter SqlData = new SqlDataAdapter("SELECT * FROM dbo.Dostepnosc", sqlcon);
                DataTable dataTable = new DataTable();
                SqlData.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //kontakt z klientem
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlDataAdapter SqlData = new SqlDataAdapter("SELECT * FROM dbo.Kontakt_Klient", sqlcon);
                DataTable dataTable = new DataTable();
                SqlData.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Pracownik
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlDataAdapter SqlData = new SqlDataAdapter("SELECT * FROM dbo.Pracownik", sqlcon);
                DataTable dataTable = new DataTable();
                SqlData.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

               

            }
        }
    
        

        private void button6_Click(object sender, EventArgs e)
        {
            //wynajem powinno byc wypozyczenie
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlDataAdapter SqlData = new SqlDataAdapter("SELECT * FROM dbo.Wynajem", sqlcon);
                DataTable dataTable = new DataTable();
                SqlData.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
