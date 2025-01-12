using System.Windows.Forms;

namespace GestaoBiblioteca.GUI
{
    partial class FormAutenticacao
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
            this.user = new System.Windows.Forms.Label();
            this.Utilizador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.BotaoOk = new System.Windows.Forms.Button();
            this.BotaoCancelar = new System.Windows.Forms.Button();
            this.LabelFeedback = new System.Windows.Forms.Label();
            this.ImagemAplicacao = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemAplicacao)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelNomeAplicacao
            // 
            this.LabelNomeAplicacao.AutoSize = true;
            this.LabelNomeAplicacao.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNomeAplicacao.Location = new System.Drawing.Point(164, 9);
            this.LabelNomeAplicacao.Name = "LabelNomeAplicacao";
            this.LabelNomeAplicacao.Size = new System.Drawing.Size(104, 41);
            this.LabelNomeAplicacao.TabIndex = 0;
            this.LabelNomeAplicacao.Text = "label1";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(12, 208);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(70, 19);
            this.user.TabIndex = 1;
            this.user.Text = "&Utilizador:";
            // 
            // Utilizador
            // 
            this.Utilizador.Location = new System.Drawing.Point(100, 201);
            this.Utilizador.Name = "Utilizador";
            this.Utilizador.Size = new System.Drawing.Size(297, 26);
            this.Utilizador.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "&Password:";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(100, 245);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(297, 26);
            this.Password.TabIndex = 4;
            // 
            // BotaoOk
            // 
            this.BotaoOk.Location = new System.Drawing.Point(199, 323);
            this.BotaoOk.Name = "BotaoOk";
            this.BotaoOk.Size = new System.Drawing.Size(99, 27);
            this.BotaoOk.TabIndex = 6;
            this.BotaoOk.Text = "&OK";
            this.BotaoOk.UseVisualStyleBackColor = true;
            this.BotaoOk.Click += new System.EventHandler(this.BotaoOk_Click);
            // 
            // BotaoCancelar
            // 
            this.BotaoCancelar.Location = new System.Drawing.Point(304, 323);
            this.BotaoCancelar.Name = "BotaoCancelar";
            this.BotaoCancelar.Size = new System.Drawing.Size(93, 27);
            this.BotaoCancelar.TabIndex = 7;
            this.BotaoCancelar.Text = "&Cancelar";
            this.BotaoCancelar.UseVisualStyleBackColor = true;
            this.BotaoCancelar.Click += new System.EventHandler(this.BotaoCancelar_Click);
            // 
            // LabelFeedback
            // 
            this.LabelFeedback.AutoSize = true;
            this.LabelFeedback.Location = new System.Drawing.Point(100, 278);
            this.LabelFeedback.Name = "LabelFeedback";
            this.LabelFeedback.Size = new System.Drawing.Size(45, 19);
            this.LabelFeedback.TabIndex = 5;
            this.LabelFeedback.Text = "label2";
            // 
            // ImagemAplicacao
            // 
            this.ImagemAplicacao.Location = new System.Drawing.Point(168, 53);
            this.ImagemAplicacao.Name = "ImagemAplicacao";
            this.ImagemAplicacao.Size = new System.Drawing.Size(100, 50);
            this.ImagemAplicacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImagemAplicacao.TabIndex = 1;
            this.ImagemAplicacao.TabStop = false;
            // 
            // FormAutenticacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 383);
            this.Controls.Add(this.LabelFeedback);
            this.Controls.Add(this.BotaoCancelar);
            this.Controls.Add(this.BotaoOk);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Utilizador);
            this.Controls.Add(this.user);
            this.Controls.Add(this.ImagemAplicacao);
            this.Controls.Add(this.LabelNomeAplicacao);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "FormAutenticacao";
            this.Text = "FormAutenticacao";
            this.Load += new System.EventHandler(this.FormAutenticacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagemAplicacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Label LabelNomeAplicacao;
        private PictureBox ImagemAplicacao;
        private Label user;
        private TextBox Utilizador;
        private Label label1;
        private TextBox Password;
        private Button BotaoOk;
        private Button BotaoCancelar;
        private Label LabelFeedback;
    }
}