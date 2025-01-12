namespace GestaoBiblioteca.GUI
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelTituloAplicacao = new System.Windows.Forms.Label();
            this.LabelSubtituloAplicacao = new System.Windows.Forms.Label();
            this.BotaoUtilizadores = new System.Windows.Forms.Button();
            this.BotaoCatalogo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSair = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDaAplicaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTituloAplicacao
            // 
            this.LabelTituloAplicacao.AutoSize = true;
            this.LabelTituloAplicacao.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.LabelTituloAplicacao.Location = new System.Drawing.Point(333, 39);
            this.LabelTituloAplicacao.Name = "LabelTituloAplicacao";
            this.LabelTituloAplicacao.Size = new System.Drawing.Size(87, 41);
            this.LabelTituloAplicacao.TabIndex = 0;
            this.LabelTituloAplicacao.Text = "label";
            // 
            // LabelSubtituloAplicacao
            // 
            this.LabelSubtituloAplicacao.AutoSize = true;
            this.LabelSubtituloAplicacao.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.LabelSubtituloAplicacao.Location = new System.Drawing.Point(240, 94);
            this.LabelSubtituloAplicacao.Name = "LabelSubtituloAplicacao";
            this.LabelSubtituloAplicacao.Size = new System.Drawing.Size(273, 25);
            this.LabelSubtituloAplicacao.TabIndex = 1;
            this.LabelSubtituloAplicacao.Text = "Sistema de Gestão de Bibliotecas";
            // 
            // BotaoUtilizadores
            // 
            this.BotaoUtilizadores.Location = new System.Drawing.Point(137, 389);
            this.BotaoUtilizadores.Name = "BotaoUtilizadores";
            this.BotaoUtilizadores.Size = new System.Drawing.Size(90, 23);
            this.BotaoUtilizadores.TabIndex = 4;
            this.BotaoUtilizadores.Text = "&Utilizadores";
            this.BotaoUtilizadores.UseVisualStyleBackColor = true;
            this.BotaoUtilizadores.Click += new System.EventHandler(this.BotaoUtilizadores_Click);
            // 
            // BotaoCatalogo
            // 
            this.BotaoCatalogo.Location = new System.Drawing.Point(419, 389);
            this.BotaoCatalogo.Name = "BotaoCatalogo";
            this.BotaoCatalogo.Size = new System.Drawing.Size(75, 23);
            this.BotaoCatalogo.TabIndex = 5;
            this.BotaoCatalogo.Text = "&Catálogo";
            this.BotaoCatalogo.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemSair});
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.ficheiroToolStripMenuItem.Text = "&Ficheiro";
            // 
            // MenuItemSair
            // 
            this.MenuItemSair.Name = "MenuItemSair";
            this.MenuItemSair.Size = new System.Drawing.Size(117, 26);
            this.MenuItemSair.Text = "&Sair";
            this.MenuItemSair.Click += new System.EventHandler(this.MenuItemSair_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDaAplicaçãoToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.ajudaToolStripMenuItem.Text = "&Ajuda";
            // 
            // acercaDaAplicaçãoToolStripMenuItem
            // 
            this.acercaDaAplicaçãoToolStripMenuItem.Name = "acercaDaAplicaçãoToolStripMenuItem";
            this.acercaDaAplicaçãoToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.acercaDaAplicaçãoToolStripMenuItem.Text = "Ac&erca da aplicação";
            this.acercaDaAplicaçãoToolStripMenuItem.Click += new System.EventHandler(this.acercaDaAplicaçãoToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GestaoBiblioteca.Properties.Resources.catalogo;
            this.pictureBox2.Location = new System.Drawing.Point(354, 170);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestaoBiblioteca.Properties.Resources.utilizadores;
            this.pictureBox1.Location = new System.Drawing.Point(90, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.BotaoCatalogo);
            this.Controls.Add(this.BotaoUtilizadores);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabelSubtituloAplicacao);
            this.Controls.Add(this.LabelTituloAplicacao);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTituloAplicacao;
        private System.Windows.Forms.Label LabelSubtituloAplicacao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BotaoUtilizadores;
        private System.Windows.Forms.Button BotaoCatalogo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSair;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDaAplicaçãoToolStripMenuItem;
    }
}

