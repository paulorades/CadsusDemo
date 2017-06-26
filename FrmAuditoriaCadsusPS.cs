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
    public partial class FrmAuditoriaCadsusPS : Form
    {
        public FrmAuditoriaCadsusPS()
        {
            InitializeComponent();
            lblDataUltimaAtualizacao.Text = "";
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var servico = new AuditoriaCadsusService.AuditoriaCadsusServicePortTypeClient())
                {
                    servico.ClientCredentials.UserName.UserName = ConfigurationManager.AppSettings["ClientCredentials.UserName.UserName"].ToString();
                    servico.ClientCredentials.UserName.Password = ConfigurationManager.AppSettings["ClientCredentials.UserName.Password"].ToString();


                    lblDataUltimaAtualizacao.Text = "";

                    var requestPesquisa = new AuditoriaCadsusService.requestObterUltimaDataAlteracaoUsuarioSUS();
                    requestPesquisa.CNESUsuario = new AuditoriaCadsusService.CNESUsuarioType();
                    requestPesquisa.CNESUsuario.CNES = ConfigurationManager.AppSettings["CNESUsuario.CNES"].ToString();
                    requestPesquisa.CNESUsuario.Usuario = ConfigurationManager.AppSettings["CNESUsuario.Usuario"].ToString();
                    requestPesquisa.CNESUsuario.Senha = ConfigurationManager.AppSettings["CNESUsuario.Senha"].ToString();

                    requestPesquisa.CNS = new AuditoriaCadsusService.CNSType();
                    requestPesquisa.CNS.numeroCNS = txtCNS.Text;

                    AuditoriaCadsusService.responseObterUltimaDataAlteracaoUsuarioSUS1 x =
                        await servico.obterUltimaDataAlteracaoUsuarioSUSAsync(requestPesquisa);

                    if (x != null)
                        lblDataUltimaAtualizacao.Text =
                            x.responseObterUltimaDataAlteracaoUsuarioSUS.dataHoraUltimaModificacao.ToString();

                    var requestHistoricoImpressao = new AuditoriaCadsusService.requestObterHistoricoImpressao();
                    requestHistoricoImpressao.CNESUsuario = new AuditoriaCadsusService.CNESUsuarioType();
                    requestHistoricoImpressao.CNESUsuario.CNES = ConfigurationManager.AppSettings["CNESUsuario.CNES"].ToString();
                    requestHistoricoImpressao.CNESUsuario.Usuario = ConfigurationManager.AppSettings["CNESUsuario.Usuario"].ToString();
                    requestHistoricoImpressao.CNESUsuario.Senha = ConfigurationManager.AppSettings["CNESUsuario.Senha"].ToString();

                    requestHistoricoImpressao.CNS = new AuditoriaCadsusService.CNSType();
                    requestHistoricoImpressao.CNS.numeroCNS = txtCNS.Text;
                    requestHistoricoImpressao.CNS.tipoCartao = new AuditoriaCadsusService.TipoCNSType();                    

                    AuditoriaCadsusService.responseObterHistoricoImpressao1 p = await servico.obterHistoricoImpressaoAsync(requestHistoricoImpressao);
                    if (p != null)
                    {
                        for (int i = 0; i < p.responseObterHistoricoImpressao.ResultadoHistoricoImpressao.Length; i++)
                        {
                            lblDataUltimaAtualizacao.Text +=
                            $"{p.responseObterHistoricoImpressao.ResultadoHistoricoImpressao[i].dataEvento.ToLongDateString()} -" +
                            $"{p.responseObterHistoricoImpressao.ResultadoHistoricoImpressao[i].Funcionalidade.descricaoFuncionalidade} -" +
                            $"{p.responseObterHistoricoImpressao.ResultadoHistoricoImpressao[i].Operacao.descricaoOperacao}" +
                            $"\n";
                        }
                    }
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
