using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Crud_Estoque
{
    
    public partial class Form1 : Form
    {


        

        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            SqlConnection conexao = new SqlConnection();
            SqlCommand comando;
            string querySQL;
            string stringConexao;



            stringConexao = @"Server=UEDAT;Database=componentes;Trusted_Connection=True";
            conexao = new SqlConnection(stringConexao);
            conexao.Open();


            querySQL = "INSERT INTO pecas (id, nome, quantidade)VALUES(@id,@nome,@quantidade)";
            comando = new SqlCommand(querySQL, conexao);

            comando.Parameters.AddWithValue("@id", int.Parse(campo_id.Text));
            comando.Parameters.AddWithValue("@nome", campo_nome.Text);
            comando.Parameters.AddWithValue("@quantidade", int.Parse(campo_quantidade.Text));
            comando.ExecuteNonQuery();

           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlConnection conexao = new SqlConnection();
            string querySQL;
            string stringConexao = @"Server=UEDAT;Database=componentes;Trusted_Connection=True"; ;

            conexao = new SqlConnection(stringConexao);
            conexao.Open();


            querySQL = "SELECT * FROM pecas";
            DataSet dataSet = new DataSet();
            da = new SqlDataAdapter(querySQL, conexao);
            da.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];


        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {

            SqlConnection conexao = new SqlConnection();
            SqlCommand comando;
            string querySQL;
            string stringConexao;



            stringConexao = @"Server=UEDAT;Database=componentes;Trusted_Connection=True";
            conexao = new SqlConnection(stringConexao);
            conexao.Open();


            querySQL = "UPDATE pecas SET nome = @nome, quantidade = @quantidade where id = @id ";
            comando = new SqlCommand(querySQL, conexao);

            comando.Parameters.AddWithValue("@id", int.Parse(campo_id.Text));
            comando.Parameters.AddWithValue("@nome", campo_nome.Text);
            comando.Parameters.AddWithValue("@quantidade", int.Parse(campo_quantidade.Text));
            comando.ExecuteNonQuery();



        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {

            SqlConnection conexao = new SqlConnection();
            SqlCommand comando;
            string querySQL;
            string stringConexao;



            stringConexao = @"Server=UEDAT;Database=componentes;Trusted_Connection=True";
            conexao = new SqlConnection(stringConexao);
            conexao.Open();


            querySQL = "DELETE FROM pecas where id = @id";
            comando = new SqlCommand(querySQL, conexao);

            comando.Parameters.AddWithValue("@id", int.Parse(campo_id.Text));
            comando.ExecuteNonQuery();




        }
    }
}