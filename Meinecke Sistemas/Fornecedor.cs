using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meinecke_Sistemas
{
    public partial class Fornecedor : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;

        string strSQL;

        public Fornecedor()
        {
            InitializeComponent();
        }

        private void NomeFornecedor_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificação de campos em branco
            if (string.IsNullOrWhiteSpace(txbFornecedor.Text) || string.IsNullOrWhiteSpace(txbtel.Text) || string.IsNullOrWhiteSpace(txbEndere.Text) || string.IsNullOrWhiteSpace(txbcep.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            try
            {
                conexao = new SqlConnection(@"Data Source=DESKTOP-F7I1U4R\SQLSERVERDARLAN;Initial Catalog=estoquess;Integrated Security=True;TrustServerCertificate=true");

               

                strSQL = "INSERT INTO fornecedor (fornecedor, telefone, endereco, cep) VALUES (@fornecedor, @telefone, @endereco, @cep)";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@fornecedor", txbFornecedor.Text);
                comando.Parameters.AddWithValue("@telefone", txbtel.Text);
                comando.Parameters.AddWithValue("@endereco", txbEndere.Text);
                comando.Parameters.AddWithValue("@cep", txbcep.Text);

                conexao.Open();
                comando.ExecuteNonQuery();

                // Adicione a mensagem de sucesso aqui
                MessageBox.Show("Os valores foram inseridos com sucesso no banco de dados.");

                // Limpe todos os TextBoxes aqui
                txbFornecedor.Clear();
                txbtel.Clear();
                txbEndere.Clear();
                txbcep.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                comando.Dispose();
            }
        }
    }
}
