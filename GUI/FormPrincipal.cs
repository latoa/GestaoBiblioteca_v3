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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            // A janela deverá surgir no centro do ecrã
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Sair pelo menuItem Sair
        /// </summary>
        
        private void MenuItemSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();
            
            this.Text = "Principal - Bibliotex";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            
            LabelTituloAplicacao.Text = Definicoes.NomeAplicacao;
           
            this.ResumeLayout(false);
        }

        private void acercaDaAplicaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Application.Run(new GUI.FormAcercaAplicacao());
            Form f2 = new FormAcercaAplicacao();
            f2.ShowDialog();
            f2.Dispose();
        }
        /// <summary>
        /// Gestão de utilizadores.
        /// Click BotaõUtilizadores
        /// </summary>
        private void BotaoUtilizadores_Click(object sender, EventArgs e)
        {
            FormUtilizadores frmUtilizadores = new FormUtilizadores();
            frmUtilizadores.ShowDialog();
            frmUtilizadores.Dispose();
        }
    }
}
