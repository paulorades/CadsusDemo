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
    public partial class FrmPesquisaPorCPF : Form
    {
        public FrmPesquisaPorCPF()
        {
            InitializeComponent();

            cbbPrecisaoPesquisa.DataSource = Enum.GetValues(typeof(CadsusService.TipoPesquisaType));
            cbbPrecisaoPesquisa.DropDownStyle = ComboBoxStyle.DropDownList;

            dtgResultado.Columns.Add("Nome", "Nome");
            dtgResultado.Columns.Add("CNS", "CNS");
            dtgResultado.Columns.Add("Nascimento", "Nascimento");
            dtgResultado.Columns.Add("Naturalidade", "Naturalidade");
        }

        private async void btnPesquisar_Click(object sender, EventArgs e)
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
                    requestPesquisa.FiltroPesquisa.CPF.numeroCPF = txtCPF.Text;
                    requestPesquisa.FiltroPesquisa.tipoPesquisa = (CadsusService.TipoPesquisaType)cbbPrecisaoPesquisa.SelectedValue;

                    CadsusService.responsePesquisar x = await servico.pesquisarAsync(requestPesquisa);

                    foreach (var r in x.responsePesquisar1)
                    {
                        dtgResultado.Rows.Add(new object[]
                        {
                            r.NomeCompleto.Nome,
                            r.CNS.numeroCNS,
                            r.dataNascimento.ToShortDateString(),
                            r.MunicipioNascimento.nomeMunicipio
                        });
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
