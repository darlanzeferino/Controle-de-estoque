namespace Meinecke_Sistemas
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            menuStripTopo = new MenuStrip();
            cadastroClienteToolStripMenuItem = new ToolStripMenuItem();
            estoqueToolStripMenuItem = new ToolStripMenuItem();
            estoqueToolStripMenuItem1 = new ToolStripMenuItem();
            menuStripTopo.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripTopo
            // 
            menuStripTopo.Items.AddRange(new ToolStripItem[] { cadastroClienteToolStripMenuItem, estoqueToolStripMenuItem, estoqueToolStripMenuItem1 });
            menuStripTopo.Location = new Point(0, 0);
            menuStripTopo.Name = "menuStripTopo";
            menuStripTopo.Size = new Size(800, 24);
            menuStripTopo.TabIndex = 0;
            menuStripTopo.Text = "menuStrip1";
            // 
            // cadastroClienteToolStripMenuItem
            // 
            cadastroClienteToolStripMenuItem.Name = "cadastroClienteToolStripMenuItem";
            cadastroClienteToolStripMenuItem.Size = new Size(79, 20);
            cadastroClienteToolStripMenuItem.Text = "Fornecedor";
            cadastroClienteToolStripMenuItem.Click += cadastroClienteToolStripMenuItem_Click;
            // 
            // estoqueToolStripMenuItem
            // 
            estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            estoqueToolStripMenuItem.Size = new Size(62, 20);
            estoqueToolStripMenuItem.Text = "Produto";
            estoqueToolStripMenuItem.Click += estoqueToolStripMenuItem_Click;
            // 
            // estoqueToolStripMenuItem1
            // 
            estoqueToolStripMenuItem1.Name = "estoqueToolStripMenuItem1";
            estoqueToolStripMenuItem1.Size = new Size(61, 20);
            estoqueToolStripMenuItem1.Text = "Estoque";
            estoqueToolStripMenuItem1.Click += estoqueToolStripMenuItem1_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStripTopo);
            MainMenuStrip = menuStripTopo;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciamento de Recursos";
            Load += Principal_Load;
            menuStripTopo.ResumeLayout(false);
            menuStripTopo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripTopo;
        private ToolStripMenuItem cadastroClienteToolStripMenuItem;
        private ToolStripMenuItem estoqueToolStripMenuItem;
        private ToolStripMenuItem estoqueToolStripMenuItem1;
    }
}
