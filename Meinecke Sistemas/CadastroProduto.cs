using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Meinecke_Sistemas
{
    public partial class CadastroProduto : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;

        string strSQL;

        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void lbproduto_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Verificação de campos em branco
            if (string.IsNullOrWhiteSpace(txtQuantidade.Text) || string.IsNullOrWhiteSpace(txbCodigo.Text) || string.IsNullOrWhiteSpace(txbDescricao.Text) || string.IsNullOrWhiteSpace(txbProduto.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            try
            {
                conexao = new SqlConnection(@"Data Source=DESKTOP-F7I1U4R\SQLSERVERDARLAN;Initial Catalog=estoquess;Integrated Security=True;TrustServerCertificate=true");

                // Verificação de código de produto duplicado
                strSQL = "SELECT COUNT(*) FROM produto WHERE codigo = @codigo";
                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@codigo", txbCodigo.Text);
                conexao.Open();
                int count = (int)comando.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Já existe um produto com este código.");
                    return;
                }
                conexao.Close();

                strSQL = "INSERT INTO produto (quantidade, codigo, descricao, produto) VALUES (@quantidade, @codigo, @descricao, @produto)";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@quantidade", txtQuantidade.Text);
                comando.Parameters.AddWithValue("@codigo", txbCodigo.Text);
                comando.Parameters.AddWithValue("@descricao", txbDescricao.Text);
                comando.Parameters.AddWithValue("@produto", txbProduto.Text);

                conexao.Open();
                comando.ExecuteNonQuery();

                // Adicione a mensagem de sucesso aqui
                MessageBox.Show("Os valores foram inseridos com sucesso no banco de dados.");

                // Limpe todos os TextBoxes aqui
                txtQuantidade.Clear();
                txbCodigo.Clear();
                txbDescricao.Clear();
                txbProduto.Clear();
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