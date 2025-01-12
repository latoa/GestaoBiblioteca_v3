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

    
    public partial class FormUtilizadores : Form
    {
        public FormUtilizadores()
        {
            InitializeComponent();
            // A janela deverá surgir no centro do ecrã
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormUtilizadores_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();
            this.CancelButton = BotaoFechar;
            this.Text = "Utilizadores";

            this.MinimumSize = new Size(816, 384);
            
            this.SizeGripStyle = SizeGripStyle.Show;


            // inicializar a ListView ListaUtilizadores
            ListaUtilizadores.View = View.Details;
            ListaUtilizadores.FullRowSelect = true;
            // Acrescentar as colunas à lista de utilizadores
            ListaUtilizadores.Columns.Add("Ativo", 50, HorizontalAlignment.Center);
            ListaUtilizadores.Columns.Add("ID", 240, HorizontalAlignment.Left);
            ListaUtilizadores.Columns.Add("Username", 150, HorizontalAlignment.Left);
            ListaUtilizadores.Columns.Add("Nome", 160, HorizontalAlignment.Left);
            ListaUtilizadores.Columns.Add("Email", -2, HorizontalAlignment.Left);

            this.ResumeLayout(false);
        }
        /// <summary>
        /// Editar os dados de um utilizador.
        /// </summary>
        private void BotaoEditar_Click(object sender, EventArgs e)
        {
            FormUtilizador frmUtilizador = new FormUtilizador();
            frmUtilizador.ShowDialog();
            frmUtilizador.Dispose();
        }

        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Criar um novo utilizador.
        /// </summary>
        private void BotaoCriar_Click(object sender, EventArgs e)
        {
            FormUtilizador frmUtilizador = new FormUtilizador();
            frmUtilizador.ShowDialog();
            frmUtilizador.Dispose();
        }
    }
}
