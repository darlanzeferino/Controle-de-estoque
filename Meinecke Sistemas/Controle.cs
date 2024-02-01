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
    public partial class Controle : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;

        string strSQL;

        public Controle()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=DESKTOP-F7I1U4R\SQLSERVERDARLAN;Initial Catalog=estoquess;Integrated Security=True;TrustServerCertificate=true");

                // Supondo que suas tabelas se chamem 'tabela1' e 'tabela2'
                strSQL = "SELECT codigo,produto,quantidade,descricao FROM produto";
                //" * FROM fornecedor";

                da = new SqlDataAdapter(strSQL, conexao);

                DataTable dt = new DataTable();

                da.Fill(dt);

                // Supondo que 'dataGridView' é o nome do seu DataGridView.
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnAtualiza2_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=DESKTOP-F7I1U4R\SQLSERVERDARLAN;Initial Catalog=estoquess;Integrated Security=True;TrustServerCertificate=true");

                // Supondo que suas tabelas se chamem 'tabela1' e 'tabela2'
                strSQL = "SELECT * FROM fornecedor";


                da = new SqlDataAdapter(strSQL, conexao);

                DataTable dt = new DataTable();

                da.Fill(dt);

                // Supondo que 'dataGridView' é o nome do seu DataGridView.
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Verifique se um registro foi selecionado no DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtenha o registro selecionado
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                // Crie uma nova instância do formulário de cadastro de produto
                CadastroProduto form = new CadastroProduto();
                row.Cells["quantidade"].Value.ToString();
                row.Cells["codigo"].Value.ToString();
                row.Cells["descricao"].Value.ToString();
                row.Cells["produto"].Value.ToString();


                // Mostre o formulário
                form.Show();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um registro para alterar.");
            }
        }

        private void btnalterar2_Click(object sender, EventArgs e)
        {
            // Verifique se um registro foi selecionado no DataGridView
            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Obtenha o registro selecionado
                DataGridViewRow row = dataGridView2.SelectedRows[0];

                // Crie uma nova instância do formulário de cadastro de produto
                Fornecedor form = new Fornecedor();
                row.Cells["fornecedor"].Value.ToString();
                row.Cells["telefone"].Value.ToString();
                row.Cells["endereco"].Value.ToString();
                row.Cells["cep"].Value.ToString();


                // Mostre o formulário
                form.Show();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um registro para alterar.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtenha o registro selecionado
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                // Obtenha o código do produto que você deseja apagar
                string codigo = row.Cells["codigo"].Value.ToString();

                // Conecte ao banco de dados
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-F7I1U4R\SQLSERVERDARLAN;Initial Catalog=estoquess;Integrated Security=True;TrustServerCertificate=true"))
                {
                    conn.Open();

                    // Crie um comando SQL para apagar o registro
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM produto WHERE codigo = @codigo", conn))
                    {
                        cmd.Parameters.AddWithValue("@codigo", codigo);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Remova a linha do DataGridView
                dataGridView1.Rows.RemoveAt(row.Index);
            }
            else
            {
                MessageBox.Show("Por favor, selecione um registro para apagar.");
            }
        }

        private void btnDeletar2_Click(object sender, EventArgs e)
        {

            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Obtenha o registro selecionado
                DataGridViewRow row = dataGridView2.SelectedRows[0];

                // Obtenha o nome do fornecedor do registro que você deseja apagar
                string fornecedor = row.Cells["fornecedor"].Value.ToString();

                // Conecte ao banco de dados
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-F7I1U4R\SQLSERVERDARLAN;Initial Catalog=estoquess;Integrated Security=True;TrustServerCertificate=true"))
                {
                    conn.Open();

                    // Crie um comando SQL para apagar o registro
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM fornecedor WHERE fornecedor = @fornecedor", conn))
                    {
                        cmd.Parameters.AddWithValue("@fornecedor", fornecedor);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Remova a linha do DataGridView
                dataGridView2.Rows.RemoveAt(row.Index);
            }
            else
            {
                MessageBox.Show("Por favor, selecione um registro para apagar.");
            }
        }
    }
}
