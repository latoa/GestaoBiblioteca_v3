using GestaoBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoBiblioteca.GUI
{
    public partial class FormAcercaAplicacao : Form
    {
        public FormAcercaAplicacao()
        {
            InitializeComponent();
            // A janela deverá surgir no centro do ecrã
            this.StartPosition = FormStartPosition.CenterScreen;
        }



        private void BotaoOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAcercaAplicacao_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();
            this.AcceptButton = BotaoOk;
            //this.CancelButton = BotaoCancelar;
            this.Text = "Acerca da aplicação";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            LabelNomeAplicacao.Text = Definicoes.NomeAplicacao;
            LabelVersao.Text = "0.1";
            LabelCopyright.Text = "0 2024 Luís Viegas";
            LinkRepositorio.Text = "google.pt";

            //ImagemAplicacao.Image = WindowsFormsApp1.Properties.Resources.livros;

            // Posicionar controlos
            //ImagemAplicacao.Left = (this.ClientSize.Width / 2) - (ImagemAplicacao.Width / 2);
            //LabelNomeAplicacao.Left = (this.ClientSize.Width / 2) - (LabelNomeAplicacao.Width / 2);

            //LabelFeedback.Visible = false;
            //Password.UseSystemPasswordChar = true;
            this.ResumeLayout(false);
        }

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.google.pt");
        }
    }
}
