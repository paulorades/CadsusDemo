using System;
using System.Configuration;
using System.Data;
using System.Data.Odbc;
using System.Text;
using System.Windows.Forms;

namespace CadsusDemo
{
    public partial class FrmUsuariosCNSSanitas : Form
    {
        private string cpf;
        private string currentConnection;

        public FrmUsuariosCNSSanitas()
        {
            InitializeComponent();

            this.currentConnection = ConfigurationManager.ConnectionStrings
                [
                    ConfigurationManager.AppSettings
                    [
                        ConfigurationManager.AppSettings["MSSQL_CONEXAO_ATUAL"].ToString()
                    ]
                ].ConnectionString;

            dtgUsuariosSemCNS.RowEnter += UpdateCPFFromSelectedUser;
            dtgUsuariosSemCNS.CellClick += UpdateCPFFromSelectedUser;
        }

        private void UpdateCPFFromSelectedUser(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgUsuariosSemCNS.SelectedRows.Count > 0)
            {
                var row = dtgUsuariosSemCNS.SelectedRows[0];
                this.cpf = row.Cells[2].FormattedValue.ToString().Replace("-", "").Replace(".", "").ToString();
                lblCPF.Text = $"CPF: {row.Cells[2].FormattedValue.ToString()}";
            }
        }

        private void FrmUsuariosCNSSanitas_Load(object sender, EventArgs e)
        {
            using (OdbcConnection connection = new OdbcConnection(this.currentConnection))
            {
                try
                {
                    connection.Open();

                    var sql = new StringBuilder();
                    sql.AppendLine("SELECT TOP 10 cdusuario AS Código, ");
                    sql.AppendLine("              nmusuario AS Nome, ");
                    sql.AppendLine("              CPF = substring(nucpf, 1, 3) + '.' + substring(nucpf, 4, 3) + '.' + substring(nucpf, 7, 3) + '-' + substring(nucpf, 10, 2),");
                    sql.AppendLine("              Nascimento = CONVERT(VARCHAR, CONVERT(DATETIME, dtnascusu, 106), 103), ");
                    sql.AppendLine("              nucns     AS CNS ");

                    //sql.Append("WHERE  Len(Ltrim(Rtrim(nucns))) = 16");
                    sql.Append("FROM dbo.sscusuar ");
                    sql.Append("WHERE   (Len(Ltrim(Rtrim(nucns))) = 0 OR nucns IS NULL)");
                    sql.Append("AND (Len(Ltrim(Rtrim(nucpf))) = 11 AND nucpf IS NOT NULL)");
                    sql.Append("ORDER BY 1");

                    DataSet dataset = new DataSet();                    

                    OdbcDataAdapter adapter = new OdbcDataAdapter(sql.ToString(), connection);
                    adapter.Fill(dataset, "dbo.sscusuar");
                    dtgUsuariosSemCNS.DataSource = dataset.Tables["dbo.sscusuar"];                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Erro:{ex.Message}", "Erro!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);                    
                    this.Close();
                }
            }
        }

        private async void btnAtualizarCNS_Click(object sender, EventArgs e)
        {
            using (var servico = new CadsusService.CadsusServicePortTypeClient())
            {
                try
                {
                    //pesquisa no serviço
                    servico.ClientCredentials.UserName.UserName = ConfigurationManager.AppSettings["ClientCredentials.UserName.UserName"].ToString();
                    servico.ClientCredentials.UserName.Password = ConfigurationManager.AppSettings["ClientCredentials.UserName.Password"].ToString();

                    var requestPesquisa = new CadsusService.requestPesquisar();
                    requestPesquisa.CNESUsuario = new CadsusService.CNESUsuarioType();
                    requestPesquisa.CNESUsuario.CNES = ConfigurationManager.AppSettings["CNESUsuario.CNES"].ToString();
                    requestPesquisa.CNESUsuario.Usuario = ConfigurationManager.AppSettings["CNESUsuario.Usuario"].ToString();
                    requestPesquisa.CNESUsuario.Senha = ConfigurationManager.AppSettings["CNESUsuario.Senha"].ToString();

                    requestPesquisa.FiltroPesquisa = new CadsusService.FiltroPesquisa();
                    requestPesquisa.FiltroPesquisa.CPF = new CadsusService.CPFType();
                    requestPesquisa.FiltroPesquisa.CPF.numeroCPF = this.cpf;
                    requestPesquisa.FiltroPesquisa.tipoPesquisa = CadsusService.TipoPesquisaType.IDENTICA;

                    CadsusService.responsePesquisar result = await servico.pesquisarAsync(requestPesquisa);

                    //atualiza no sanitas
                    AtualizaCNSUsuario(result.responsePesquisar1[0].CNS);
                }
                catch (System.ServiceModel.FaultException<CadsusService.MSFalha> ex)
                {
                    var strb = new StringBuilder();
                    strb.Append("Erro ao consultar CNS:\n\n");
                    foreach (var err in ex.Detail.Mensagem)
                    {
                        //strb.AppendLine($"Cód. erro: [{err.codigo}]");
                        strb.Append($"Descrição: { err.descricao}");
                    }

                    MessageBox.Show(strb.ToString(), "Erro!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro:\n Descrição: {ex.ToString()}", "Erro!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
        }

        private void AtualizaCNSUsuario(CadsusService.CNSType cnsType)
        {
            using (OdbcConnection connection = new OdbcConnection(this.currentConnection))
            {
                try
                {
                    string updateSQL = "UPDATE dbo.sscusuar SET nucns = ? WHERE nucpf = ?;";

                    var command = new OdbcCommand(updateSQL, connection);
                    command.Parameters.AddWithValue("@nucns", cnsType.numeroCNS);
                    command.Parameters.AddWithValue("@nucpf", this.cpf);

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show($"Cadastro atualizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.FrmUsuariosCNSSanitas_Load(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro:\n Descrição: {ex.ToString()}", "Erro!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
        }
    }
}
