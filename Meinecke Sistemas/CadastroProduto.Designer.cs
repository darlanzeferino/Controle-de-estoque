namespace Meinecke_Sistemas
{
    partial class CadastroProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroProduto));
            lbCodigo = new Label();
            lbProduto = new Label();
            lbDescricao = new Label();
            txbCodigo = new TextBox();
            txbProduto = new TextBox();
            txbDescricao = new TextBox();
            btnSalvarr = new Button();
            txtQuantidade = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbCodigo
            // 
            lbCodigo.AutoSize = true;
            lbCodigo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCodigo.Location = new Point(22, 26);
            lbCodigo.Name = "lbCodigo";
            lbCodigo.Size = new Size(103, 32);
            lbCodigo.TabIndex = 0;
            lbCodigo.Text = "Código:";
            // 
            // lbProduto
            // 
            lbProduto.AutoSize = true;
            lbProduto.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbProduto.Location = new Point(22, 74);
            lbProduto.Name = "lbProduto";
            lbProduto.Size = new Size(115, 32);
            lbProduto.TabIndex = 1;
            lbProduto.Text = "Produto:";
            lbProduto.Click += lbproduto_Click;
            // 
            // lbDescricao
            // 
            lbDescricao.AutoSize = true;
            lbDescricao.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDescricao.Location = new Point(21, 179);
            lbDescricao.Name = "lbDescricao";
            lbDescricao.Size = new Size(132, 32);
            lbDescricao.TabIndex = 2;
            lbDescricao.Text = "Descrição:";
            // 
            // txbCodigo
            // 
            txbCodigo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbCodigo.Location = new Point(143, 23);
            txbCodigo.Name = "txbCodigo";
            txbCodigo.Size = new Size(108, 39);
            txbCodigo.TabIndex = 3;
            // 
            // txbProduto
            // 
            txbProduto.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbProduto.Location = new Point(155, 67);
            txbProduto.Name = "txbProduto";
            txbProduto.Size = new Size(349, 39);
            txbProduto.TabIndex = 4;
            // 
            // txbDescricao
            // 
            txbDescricao.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbDescricao.Location = new Point(169, 172);
            txbDescricao.Name = "txbDescricao";
            txbDescricao.RightToLeft = RightToLeft.No;
            txbDescricao.Size = new Size(335, 39);
            txbDescricao.TabIndex = 5;
            // 
            // btnSalvarr
            // 
            btnSalvarr.BackColor = Color.Transparent;
            btnSalvarr.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvarr.Location = new Point(143, 223);
            btnSalvarr.Name = "btnSalvarr";
            btnSalvarr.Size = new Size(213, 49);
            btnSalvarr.TabIndex = 6;
            btnSalvarr.Text = "Salvar";
            btnSalvarr.UseVisualStyleBackColor = false;
            btnSalvarr.Click += btnSalvar_Click;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtQuantidade.Location = new Point(185, 120);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(76, 39);
            txtQuantidade.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 127);
            label1.Name = "label1";
            label1.Size = new Size(147, 32);
            label1.TabIndex = 8;
            label1.Text = "Quantidade";
            // 
            // CadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(516, 284);
            Controls.Add(txtQuantidade);
            Controls.Add(label1);
            Controls.Add(btnSalvarr);
            Controls.Add(txbDescricao);
            Controls.Add(txbProduto);
            Controls.Add(txbCodigo);
            Controls.Add(lbDescricao);
            Controls.Add(lbProduto);
            Controls.Add(lbCodigo);
            DoubleBuffered = true;
            Name = "CadastroProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroProduto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCodigo;
        private Label lbProduto;
        private Label lbDescricao;
        private TextBox txbCodigo;
        private TextBox txbProduto;
        private TextBox txbDescricao;
        private Button btnSalvarr;
        private TextBox txtQuantidade;
        private Label label1;
    }
}