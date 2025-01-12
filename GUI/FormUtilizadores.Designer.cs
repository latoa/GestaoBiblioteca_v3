namespace GestaoBiblioteca.GUI
{
    partial class FormUtilizadores
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
            this.label1 = new System.Windows.Forms.Label();
            this.ListaUtilizadores = new System.Windows.Forms.ListView();
            this.BotaoCriar = new System.Windows.Forms.Button();
            this.BotaoEditar = new System.Windows.Forms.Button();
            this.BotaoEliminar = new System.Windows.Forms.Button();
            this.BotaoFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label1.Location = new System.Drawing.Point(25, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 0;
            this.label1.Tag = "";
            this.label1.Text = "Gestão de Utilizadores";
            // 
            // ListaUtilizadores
            // 
            this.ListaUtilizadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListaUtilizadores.HideSelection = false;
            this.ListaUtilizadores.Location = new System.Drawing.Point(24, 51);
            this.ListaUtilizadores.Name = "ListaUtilizadores";
            this.ListaUtilizadores.Size = new System.Drawing.Size(741, 231);
            this.ListaUtilizadores.TabIndex = 0;
            this.ListaUtilizadores.UseCompatibleStateImageBehavior = false;
            // 
            // BotaoCriar
            // 
            this.BotaoCriar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BotaoCriar.Location = new System.Drawing.Point(29, 302);
            this.BotaoCriar.Name = "BotaoCriar";
            this.BotaoCriar.Size = new System.Drawing.Size(111, 23);
            this.BotaoCriar.TabIndex = 1;
            this.BotaoCriar.Text = "&Criar utilizador";
            this.BotaoCriar.UseVisualStyleBackColor = true;
            this.BotaoCriar.Click += new System.EventHandler(this.BotaoCriar_Click);
            // 
            // BotaoEditar
            // 
            this.BotaoEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BotaoEditar.Location = new System.Drawing.Point(155, 302);
            this.BotaoEditar.Name = "BotaoEditar";
            this.BotaoEditar.Size = new System.Drawing.Size(114, 23);
            this.BotaoEditar.TabIndex = 2;
            this.BotaoEditar.Text = "&Editar utilizador";
            this.BotaoEditar.UseVisualStyleBackColor = true;
            this.BotaoEditar.Click += new System.EventHandler(this.BotaoEditar_Click);
            // 
            // BotaoEliminar
            // 
            this.BotaoEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BotaoEliminar.Location = new System.Drawing.Point(284, 302);
            this.BotaoEliminar.Name = "BotaoEliminar";
            this.BotaoEliminar.Size = new System.Drawing.Size(128, 23);
            this.BotaoEliminar.TabIndex = 3;
            this.BotaoEliminar.Text = "&Eliminar utilizador";
            this.BotaoEliminar.UseVisualStyleBackColor = true;
            // 
            // BotaoFechar
            // 
            this.BotaoFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BotaoFechar.Location = new System.Drawing.Point(689, 301);
            this.BotaoFechar.Name = "BotaoFechar";
            this.BotaoFechar.Size = new System.Drawing.Size(75, 23);
            this.BotaoFechar.TabIndex = 4;
            this.BotaoFechar.Text = "&Fechar";
            this.BotaoFechar.UseVisualStyleBackColor = true;
            this.BotaoFechar.Click += new System.EventHandler(this.BotaoFechar_Click);
            // 
            // FormUtilizadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 337);
            this.Controls.Add(this.BotaoFechar);
            this.Controls.Add(this.BotaoEliminar);
            this.Controls.Add(this.BotaoEditar);
            this.Controls.Add(this.BotaoCriar);
            this.Controls.Add(this.ListaUtilizadores);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormUtilizadores";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormUtilizadores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ListaUtilizadores;
        private System.Windows.Forms.Button BotaoCriar;
        private System.Windows.Forms.Button BotaoEditar;
        private System.Windows.Forms.Button BotaoEliminar;
        private System.Windows.Forms.Button BotaoFechar;
    }
}