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
    /// <summary>
    /// 10 Criar Form
    /// 11 FormUtilizadores Click BotaoCriar
    /// 12 FormUtilizadores Click BotaoEditar
    /// 13 Propriedades tipo de Letra e dimensoes
    /// 14 Adicionar controlos
    /// 15 Tab Order
    /// 16 Adicione código (Construtor)(Load())
    /// 17 Click do botão BotaoOK
    /// 18 Click do botão BotaoCancelar:
    /// </summary>
    public partial class FormUtilizador : Form
    {
        public FormUtilizador()
        {
            InitializeComponent();
            // A janela deverá surgir no centro do ecrã
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormUtilizador_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();

            this.AcceptButton = BotaoOk;
            this.CancelButton = BotaoCancelar;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            this.ResumeLayout(false);
        }
        /// <summary>
        /// Terminar a operação.
        /// </summary>
        private void BotaoOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        /// <summary>
        /// Cancelar a operação e fechar a janela.
        /// </summary>
        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
