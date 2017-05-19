using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadsusDemo
{
    public partial class FrmIncluirUsuario : Form
    {
        public FrmIncluirUsuario()
        {
            InitializeComponent();
        }

        private async void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                using (var servico = new CadsusService.CadsusServicePortTypeClient())
                {
                    servico.ClientCredentials.UserName.UserName = ConfigurationManager.AppSettings["ClientCredentials.UserName.UserName"].ToString();
                    servico.ClientCredentials.UserName.Password = ConfigurationManager.AppSettings["ClientCredentials.UserName.Password"].ToString();

                    var requestIncluir = new CadsusService.requestIncluir();
                    requestIncluir.CNESUsuario = new CadsusService.CNESUsuarioType();
                    requestIncluir.CNESUsuario.CNES = ConfigurationManager.AppSettings["CNESUsuario.CNES"].ToString();
                    requestIncluir.CNESUsuario.Usuario = ConfigurationManager.AppSettings["CNESUsuario.Usuario"].ToString();
                    requestIncluir.CNESUsuario.Senha = ConfigurationManager.AppSettings["CNESUsuario.Senha"].ToString();

                    requestIncluir.UsuarioSUS = new CadsusService.UsuarioSUSType();
                    requestIncluir.UsuarioSUS.NomeCompleto = new CadsusService.NomeCompletoType() { Nome = "USUÁRIO TESTE INCLUSÃO" };
                    requestIncluir.UsuarioSUS.Mae = new CadsusService.NomeCompletoType() { Nome = "MÃE DO USUÁRIO TESTE INCLUSÃO" };
                    requestIncluir.UsuarioSUS.Pai = new CadsusService.NomeCompletoType() { Nome = "PAI DO USUÁRIO TESTE INCLUSÃO" };
                    requestIncluir.UsuarioSUS.CPF = new CadsusService.CPFType() { numeroCPF = "65924947270" };
                    requestIncluir.UsuarioSUS.dataNascimento = new DateTime(2017, 01, 01);

                    CadsusService.responseIncluir1 inclusao = await servico.incluirAsync(requestIncluir);
                }
            }
            catch (System.ServiceModel.FaultException<CadsusService.MSFalha> ex)
            {
                var strb = new StringBuilder();
                strb.AppendLine("Erro na consulta:\n");

                foreach (var err in ex.Detail.Mensagem)
                    strb.AppendLine($"Cód: {err.codigo} - Descrição: {err.descricao}");

                MessageBox.Show(strb.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERRO: {ex.ToString()}");
            }
        }

    }
}
