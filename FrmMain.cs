using System;
using System.Windows.Forms;

namespace CadsusDemo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void porNomeDaMaeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmPesquisarPorNomeDaMae().Show();
        }

        private void pesquisarPorCPFtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmPesquisaPorCPF().Show();
        }

        private void pesquisarPorNomeCompletoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmPesquisarPorNomeCompleto().Show();
        }

        private void verificarAtaualizaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmConsultarUsuario().Show();
        }
    }
}
