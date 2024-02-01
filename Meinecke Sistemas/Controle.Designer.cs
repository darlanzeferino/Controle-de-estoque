namespace Meinecke_Sistemas
{
    partial class Controle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controle));
            dataGridView1 = new DataGridView();
            Atualizar = new Button();
            dataGridView2 = new DataGridView();
            btnAtualiza2 = new Button();
            btnAlterar1 = new Button();
            btnalterar = new Button();
            btnDelete = new Button();
            btnDeletar2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(443, 332);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Atualizar
            // 
            Atualizar.BackColor = SystemColors.ButtonHighlight;
            Atualizar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Atualizar.Location = new Point(110, 14);
            Atualizar.Name = "Atualizar";
            Atualizar.Size = new Size(277, 39);
            Atualizar.TabIndex = 1;
            Atualizar.Text = "Atualiza Produtos";
            Atualizar.UseVisualStyleBackColor = false;
            Atualizar.Click += button1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(492, 118);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(443, 332);
            dataGridView2.TabIndex = 2;
            // 
            // btnAtualiza2
            // 
            btnAtualiza2.BackColor = SystemColors.ButtonHighlight;
            btnAtualiza2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualiza2.Location = new Point(577, 12);
            btnAtualiza2.Name = "btnAtualiza2";
            btnAtualiza2.Size = new Size(276, 39);
            btnAtualiza2.TabIndex = 3;
            btnAtualiza2.Text = "Atualiza Fornecedores";
            btnAtualiza2.UseVisualStyleBackColor = false;
            btnAtualiza2.Click += btnAtualiza2_Click;
            // 
            // btnAlterar1
            // 
            btnAlterar1.BackColor = SystemColors.ButtonHighlight;
            btnAlterar1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterar1.Location = new Point(23, 73);
            btnAlterar1.Name = "btnAlterar1";
            btnAlterar1.Size = new Size(160, 39);
            btnAlterar1.TabIndex = 4;
            btnAlterar1.Text = "Alterar ";
            btnAlterar1.UseVisualStyleBackColor = false;
            btnAlterar1.Click += button1_Click_1;
            // 
            // btnalterar
            // 
            btnalterar.BackColor = SystemColors.ButtonHighlight;
            btnalterar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnalterar.Location = new Point(492, 73);
            btnalterar.Name = "btnalterar";
            btnalterar.Size = new Size(161, 39);
            btnalterar.TabIndex = 5;
            btnalterar.Text = "Alterar ";
            btnalterar.UseVisualStyleBackColor = false;
            btnalterar.Click += btnalterar2_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ButtonHighlight;
            btnDelete.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(306, 73);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(160, 39);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnDeletar2
            // 
            btnDeletar2.BackColor = SystemColors.ButtonHighlight;
            btnDeletar2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeletar2.Location = new Point(775, 73);
            btnDeletar2.Name = "btnDeletar2";
            btnDeletar2.Size = new Size(160, 39);
            btnDeletar2.TabIndex = 7;
            btnDeletar2.Text = "Delete";
            btnDeletar2.UseVisualStyleBackColor = false;
            btnDeletar2.Click += btnDeletar2_Click;
            // 
            // Controle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(958, 462);
            Controls.Add(btnDeletar2);
            Controls.Add(btnDelete);
            Controls.Add(btnalterar);
            Controls.Add(btnAlterar1);
            Controls.Add(btnAtualiza2);
            Controls.Add(dataGridView2);
            Controls.Add(Atualizar);
            Controls.Add(dataGridView1);
            Name = "Controle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Atualizar;
        private DataGridView dataGridView2;
        private Button btnAtualiza2;
        private Button btnAlterar1;
        private Button btnalterar;
        private Button btnDelete;
        private Button btnDeletar2;
    }
}