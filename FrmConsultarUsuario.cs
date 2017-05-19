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
    public partial class FrmConsultarUsuario : Form
    {
        public FrmConsultarUsuario()
        {
            InitializeComponent();

            dtgResultado.Columns.Add("Key", "Key");
            dtgResultado.Columns.Add("Data", "Data");
        }

        private async void btnConsultarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                using (var servico = new CadsusService.CadsusServicePortTypeClient())
                {
                    servico.ClientCredentials.UserName.UserName = ConfigurationManager.AppSettings["ClientCredentials.UserName.UserName"].ToString();
                    servico.ClientCredentials.UserName.Password = ConfigurationManager.AppSettings["ClientCredentials.UserName.Password"].ToString();

                    dtgResultado.Rows.Clear();

                    var requestPesquisa = new CadsusService.requestPesquisar();
                    requestPesquisa.CNESUsuario = new CadsusService.CNESUsuarioType();
                    requestPesquisa.CNESUsuario.CNES = ConfigurationManager.AppSettings["CNESUsuario.CNES"].ToString();
                    requestPesquisa.CNESUsuario.Usuario = ConfigurationManager.AppSettings["CNESUsuario.Usuario"].ToString();
                    requestPesquisa.CNESUsuario.Senha = ConfigurationManager.AppSettings["CNESUsuario.Senha"].ToString();

                    requestPesquisa.FiltroPesquisa = new CadsusService.FiltroPesquisa();
                    requestPesquisa.FiltroPesquisa.CPF = new CadsusService.CPFType();
                    requestPesquisa.FiltroPesquisa.CPF.numeroCPF = txbCPFsuario.Text;
                    requestPesquisa.FiltroPesquisa.tipoPesquisa = CadsusService.TipoPesquisaType.IDENTICA;

                    CadsusService.responsePesquisar x = await servico.pesquisarAsync(requestPesquisa);

                    if (x.responsePesquisar1.Length > 0)
                    {
                        var requestConsultar = new CadsusService.requestConsultar();
                        requestConsultar.CNESUsuario = new CadsusService.CNESUsuarioType();
                        requestConsultar.CNESUsuario.CNES = ConfigurationManager.AppSettings["CNESUsuario.CNES"].ToString();
                        requestConsultar.CNESUsuario.Usuario = ConfigurationManager.AppSettings["CNESUsuario.Usuario"].ToString();
                        requestConsultar.CNESUsuario.Senha = ConfigurationManager.AppSettings["CNESUsuario.Senha"].ToString();
                        requestConsultar.CNS = new CadsusService.CNSType();
                        requestConsultar.CNS.numeroCNS = x.responsePesquisar1[0].CNS.numeroCNS;
                        var y = await servico.consultarAsync(requestConsultar);

                        if (y.responseConsultar.UsuarioSUS != null)
                        {
                            var user = y.responseConsultar.UsuarioSUS;

                            dtgResultado.Rows.Add(new object[]
                            {
                                "Nome",
                                user.NomeCompleto.Nome
                            });

                            if (user.Mae != null)
                                dtgResultado.Rows.Add(new object[]
                                {
                                    "Mãe",
                                    user.Mae.Nome
                                });

                            dtgResultado.Rows.Add(new object[]
                            {
                                "CNS",
                                 x.responsePesquisar1[0].CNS.numeroCNS
                            });

                            if (user.Pai != null)
                                dtgResultado.Rows.Add(new object[]
                                {
                                    "Pai",
                                    user.Pai.Nome
                                });

                            if (user.CPF != null)
                                dtgResultado.Rows.Add(new object[]
                                {
                                    "CPF",
                                    user.CPF.numeroCPF
                                });

                            if (user.dataNascimento != null)
                                dtgResultado.Rows.Add(new object[]
                                {
                                    "Nascimento",
                                    user.dataNascimento.ToShortDateString()
                                });

                            foreach (var t in user.Telefones)
                            {
                                dtgResultado.Rows.Add(new object[]
                                {
                                    "Telefone",
                                    $"{t.DDD} - {t.numeroTelefone}"
                                });
                            }

                            if (user.Sexo != null)
                                dtgResultado.Rows.Add(new object[]
                                {
                                    "Sexo",
                                    user.Sexo.descricaoSexo
                                });

                            if (user.RacaCor != null)
                                dtgResultado.Rows.Add(new object[]
                                {
                                    "Raça/Cor",
                                    user.RacaCor.descricaoRacaCor
                                });

                            if (user.Certidoes != null)
                            {
                                foreach (var c in user.Certidoes.Certidao)
                                    dtgResultado.Rows.Add(new object[]
                                      {
                                            "Certidão",
                                            $"{c.ano} - {c.dataEmissao} + {c.digitoVerificador} - {c.folha} + {c.livro} + {c.numeroCartorio} + {c.TipoCertidao}"
                                      });

                                foreach (var c in user.Certidoes.CertidaoAntiga)
                                    if (user.Certidoes.CertidaoAntiga != null)
                                        dtgResultado.Rows.Add(new object[]
                                        {
                                            "Certidão Antiga",
                                            $"{c.dataEmissao} - {c.folha} - {c.livro} - {c.nomeCartorio} - {c.TipoCertidao}"
                                        });
                            }

                            if (user.Documentos.CNH != null)
                                dtgResultado.Rows.Add(new object[]
                                {
                                    "CNH",
                                    user.Documentos.CNH.numeroCNH
                                });

                            if (user.Documentos.CTPS != null)
                                dtgResultado.Rows.Add(new object[]
                                {
                                    "CTPS",
                                    user.Documentos.CTPS.numeroCTPS
                                });

                            if (user.Documentos.DNV != null)
                                dtgResultado.Rows.Add(new object[]
                                {
                                    "DNV",
                                    user.Documentos.DNV.numeroDNV
                                });

                            if (user.Documentos.Identidade != null)
                                dtgResultado.Rows.Add(new object[]
                                {
                                    "Identidade",
                                    user.Documentos.Identidade.numeroIdentidade
                                });

                            if (user.Documentos.NIS != null)
                                dtgResultado.Rows.Add(new object[]
                                {
                                    "NIS",
                                    user.Documentos.NIS.numeroDocumento
                                });

                            if (user.Documentos.Passaporte != null)
                                dtgResultado.Rows.Add(new object[]
                                {
                                    "Passaporte",
                                    user.Documentos.Passaporte.numeroPassaporte
                                });

                            if (user.Documentos.TituloEleitor != null)
                                dtgResultado.Rows.Add(new object[]
                                {
                                    "Título de Eleitor",
                                    user.Documentos.TituloEleitor.numeroTituloEleitor
                                });
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
