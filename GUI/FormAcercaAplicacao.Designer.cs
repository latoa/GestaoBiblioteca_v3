namespace GestaoBiblioteca.GUI
{
    partial class FormAcercaAplicacao
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
            this.LabelNomeAplicacao = new System.Windows.Forms.Label();
            this.LabelVersao = new System.Windows.Forms.Label();
            this.LabelCopyright = new System.Windows.Forms.Label();
            this.LinkRepositorio = new System.Windows.Forms.LinkLabel();
            this.BotaoOk = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelNomeAplicacao
            // 
            this.LabelNomeAplicacao.AutoSize = true;
            this.LabelNomeAplicacao.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.LabelNomeAplicacao.Location = new System.Drawing.Point(182, 33);
            this.LabelNomeAplicacao.Name = "LabelNomeAplicacao";
            this.LabelNomeAplicacao.Size = new System.Drawing.Size(104, 41);
            this.LabelNomeAplicacao.TabIndex = 1;
            this.LabelNomeAplicacao.Text = "label1";
            // 
            // LabelVersao
            // 
            this.LabelVersao.AutoSize = true;
            this.LabelVersao.Location = new System.Drawing.Point(182, 74);
            this.LabelVersao.Name = "LabelVersao";
            this.LabelVersao.Size = new System.Drawing.Size(45, 19);
            this.LabelVersao.TabIndex = 2;
            this.LabelVersao.Text = "label1";
            // 
            // LabelCopyright
            // 
            this.LabelCopyright.AutoSize = true;
            this.LabelCopyright.Location = new System.Drawing.Point(182, 103);
            this.LabelCopyright.Name = "LabelCopyright";
            this.LabelCopyright.Size = new System.Drawing.Size(45, 19);
            this.LabelCopyright.TabIndex = 3;
            this.LabelCopyright.Text = "label2";
            // 
            // LinkRepositorio
            // 
            this.LinkRepositorio.AutoSize = true;
            this.LinkRepositorio.Location = new System.Drawing.Point(182, 131);
            this.LinkRepositorio.Name = "LinkRepositorio";
            this.LinkRepositorio.Size = new System.Drawing.Size(66, 19);
            this.LinkRepositorio.TabIndex = 4;
            this.LinkRepositorio.TabStop = true;
            this.LinkRepositorio.Text = "LinkLabel";
            this.LinkRepositorio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
            // 
            // BotaoOk
            // 
            this.BotaoOk.Location = new System.Drawing.Point(402, 170);
            this.BotaoOk.Name = "BotaoOk";
            this.BotaoOk.Size = new System.Drawing.Size(75, 23);
            this.BotaoOk.TabIndex = 5;
            this.BotaoOk.Text = "&OK";
            this.BotaoOk.UseVisualStyleBackColor = true;
            this.BotaoOk.Click += new System.EventHandler(this.BotaoOk_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestaoBiblioteca.Properties.Resources.livros;
            this.pictureBox1.Location = new System.Drawing.Point(12, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormAcercaAplicacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 205);
            this.Controls.Add(this.BotaoOk);
            this.Controls.Add(this.LinkRepositorio);
            this.Controls.Add(this.LabelCopyright);
            this.Controls.Add(this.LabelVersao);
            this.Controls.Add(this.LabelNomeAplicacao);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormAcercaAplicacao";
            this.Text = "FormAcercaAplicacao";
            this.Load += new System.EventHandler(this.FormAcercaAplicacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LabelNomeAplicacao;
        private System.Windows.Forms.Label LabelVersao;
        private System.Windows.Forms.Label LabelCopyright;
        private System.Windows.Forms.LinkLabel LinkRepositorio;
        private System.Windows.Forms.Button BotaoOk;
    }
}