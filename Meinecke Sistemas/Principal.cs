namespace Meinecke_Sistemas
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }


        private void cadastroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.ShowDialog();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProduto cadastroProduto = new CadastroProduto();
            cadastroProduto.ShowDialog();

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void estoqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.ShowDialog();
        }
    }
}
