namespace Meinecke_Sistemas
{
    partial class Fornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fornecedor));
            NomeFornecedor = new Label();
            lblTelefone = new Label();
            lblEndereco = new Label();
            lblcep = new Label();
            txbFornecedor = new TextBox();
            txbtel = new TextBox();
            txbEndere = new TextBox();
            txbcep = new TextBox();
            btnsalvarfor = new Button();
            SuspendLayout();
            // 
            // NomeFornecedor
            // 
            NomeFornecedor.AutoSize = true;
            NomeFornecedor.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NomeFornecedor.Location = new Point(42, 20);
            NomeFornecedor.Name = "NomeFornecedor";
            NomeFornecedor.Size = new Size(144, 32);
            NomeFornecedor.TabIndex = 0;
            NomeFornecedor.Text = "Fornecedor";
            NomeFornecedor.Click += NomeFornecedor_Click;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefone.Location = new Point(42, 74);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(111, 32);
            lblTelefone.TabIndex = 1;
            lblTelefone.Text = "Telefone";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndereco.Location = new Point(42, 126);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(120, 32);
            lblEndereco.TabIndex = 2;
            lblEndereco.Text = "Endereço";
            // 
            // lblcep
            // 
            lblcep.AutoSize = true;
            lblcep.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcep.Location = new Point(42, 181);
            lblcep.Name = "lblcep";
            lblcep.Size = new Size(57, 32);
            lblcep.TabIndex = 3;
            lblcep.Text = "CEP";
            // 
            // txbFornecedor
            // 
            txbFornecedor.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbFornecedor.Location = new Point(190, 13);
            txbFornecedor.Name = "txbFornecedor";
            txbFornecedor.Size = new Size(323, 39);
            txbFornecedor.TabIndex = 4;
            // 
            // txbtel
            // 
            txbtel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbtel.Location = new Point(159, 67);
            txbtel.Name = "txbtel";
            txbtel.Size = new Size(189, 39);
            txbtel.TabIndex = 5;
            // 
            // txbEndere
            // 
            txbEndere.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbEndere.Location = new Point(168, 119);
            txbEndere.Name = "txbEndere";
            txbEndere.Size = new Size(345, 39);
            txbEndere.TabIndex = 6;
            // 
            // txbcep
            // 
            txbcep.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbcep.Location = new Point(116, 174);
            txbcep.Name = "txbcep";
            txbcep.Size = new Size(166, 39);
            txbcep.TabIndex = 7;
            // 
            // btnsalvarfor
            // 
            btnsalvarfor.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsalvarfor.Location = new Point(181, 238);
            btnsalvarfor.Name = "btnsalvarfor";
            btnsalvarfor.Size = new Size(133, 43);
            btnsalvarfor.TabIndex = 8;
            btnsalvarfor.Text = "Salvar";
            btnsalvarfor.TextAlign = ContentAlignment.TopCenter;
            btnsalvarfor.UseVisualStyleBackColor = true;
            btnsalvarfor.Click += button1_Click;
            // 
            // Fornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(516, 284);
            Controls.Add(btnsalvarfor);
            Controls.Add(txbcep);
            Controls.Add(txbEndere);
            Controls.Add(txbtel);
            Controls.Add(txbFornecedor);
            Controls.Add(lblcep);
            Controls.Add(lblEndereco);
            Controls.Add(lblTelefone);
            Controls.Add(NomeFornecedor);
            Name = "Fornecedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fornecedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NomeFornecedor;
        private Label lblTelefone;
        private Label lblEndereco;
        private Label lblcep;
        private TextBox txbFornecedor;
        private TextBox txbtel;
        private TextBox txbEndere;
        private TextBox txbcep;
        private Button btnsalvarfor;
    }
}