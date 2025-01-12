namespace GestaoBiblioteca.GUI
{
    partial class FormUtilizador
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
            this.Mensagem = new System.Windows.Forms.Label();
            this.UtilizadorId = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BotaoOk = new System.Windows.Forms.Button();
            this.BotaoCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Mensagem
            // 
            this.Mensagem.AutoSize = true;
            this.Mensagem.Location = new System.Drawing.Point(13, 13);
            this.Mensagem.Name = "Mensagem";
            this.Mensagem.Size = new System.Drawing.Size(45, 19);
            this.Mensagem.TabIndex = 0;
            this.Mensagem.Text = "label1";
            // 
            // UtilizadorId
            // 
            this.UtilizadorId.AutoSize = true;
            this.UtilizadorId.Location = new System.Drawing.Point(39, 47);
            this.UtilizadorId.Name = "UtilizadorId";
            this.UtilizadorId.Size = new System.Drawing.Size(45, 19);
            this.UtilizadorId.TabIndex = 2;
            this.UtilizadorId.Text = "label2";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(336, 47);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 23);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "&Ativo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "&Nome";
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(84, 85);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(315, 26);
            this.Nome.TabIndex = 5;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(84, 123);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(315, 26);
            this.Email.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "&Email";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(84, 162);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(315, 26);
            this.Username.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "&Username";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(84, 199);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(315, 26);
            this.Password.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "&Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "ID:";
            // 
            // BotaoOk
            // 
            this.BotaoOk.Location = new System.Drawing.Point(244, 240);
            this.BotaoOk.Name = "BotaoOk";
            this.BotaoOk.Size = new System.Drawing.Size(75, 23);
            this.BotaoOk.TabIndex = 12;
            this.BotaoOk.Text = "&Ok";
            this.BotaoOk.UseVisualStyleBackColor = true;
            this.BotaoOk.Click += new System.EventHandler(this.BotaoOk_Click);
            // 
            // BotaoCancelar
            // 
            this.BotaoCancelar.Location = new System.Drawing.Point(326, 240);
            this.BotaoCancelar.Name = "BotaoCancelar";
            this.BotaoCancelar.Size = new System.Drawing.Size(75, 23);
            this.BotaoCancelar.TabIndex = 13;
            this.BotaoCancelar.Text = "&Cancelar";
            this.BotaoCancelar.UseVisualStyleBackColor = true;
            this.BotaoCancelar.Click += new System.EventHandler(this.BotaoCancelar_Click);
            // 
            // FormUtilizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 275);
            this.Controls.Add(this.BotaoCancelar);
            this.Controls.Add(this.BotaoOk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.UtilizadorId);
            this.Controls.Add(this.Mensagem);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormUtilizador";
            this.Text = "FormUtilizador";
            this.Load += new System.EventHandler(this.FormUtilizador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Mensagem;
        private System.Windows.Forms.Label UtilizadorId;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BotaoOk;
        private System.Windows.Forms.Button BotaoCancelar;
    }
}