using Newtonsoft.Json;
using RedeService.Helpers;
using RedeService.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedeService
{
    public partial class FrmRedeService : Form
    {
        private readonly HttpClient _client = new HttpClient();
        private static readonly string _urlBank = ConfigurationManager.AppSettings["urlBank"]?.ToString();
        string _pathArquivo = Environment.CurrentDirectory;
        string _nomeArquivo = "numeros_ordenados.txt";
        List<Teste> _listTesteNovo = new List<Teste>();

        public FrmRedeService()
        {
            InitializeComponent();

            label4.Text = "Pronto para Começar";
            label4.ForeColor = Color.Green;
            label17.Text = "";

            btnAbriArquivo.Enabled = false;
            btnGravarLista.Enabled = false;
        }

        private void textNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            btnGravarLista.Enabled = true;
            if (textNumero.Text != "" && textNumero.Text != null)
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    dataGridView1.Columns.Add("Numero", "Numero");
                    dataGridView1.Rows.Add(new object[] { textNumero.Text.ToString() });

                    textNumero.Clear();
                }
                else
                {
                    dataGridView1.Rows.Add(new object[] { textNumero.Text.ToString() });
                    textNumero.Clear();
                }
            }
            else
            {
                label4.Text = "Informe 1 número";
                label4.ForeColor = Color.Red;
            }
        }

        private void btnGravarLista_Click(object sender, EventArgs e)
        {
            btnAbriArquivo.Enabled = true;
            _pathArquivo = Environment.CurrentDirectory;
            var listNumero = new List<string>();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                listNumero.Add(dataGridView1?.Rows[i].Cells[0].Value?.ToString());
            }

            label4.Text = "Lista criada com sucesso!!";
            label4.ForeColor = Color.Green;
            SalvarArquivo.SalvandoArquivos(listNumero, _pathArquivo, _nomeArquivo);
        }

        private void btnAbriArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = _pathArquivo;

            Process.Start(new ProcessStartInfo()
            {
                WorkingDirectory = _pathArquivo,
                FileName = _nomeArquivo,
                UseShellExecute = true
            });
            label4.Text = "Arquivo aberto com sucesso!!";
            label4.ForeColor = Color.Green;
        }

        private void btnCreateJson_Click(object sender, EventArgs e)
        {
            SalvarArquivo.SalvandoArquivoJson(_listTesteNovo, _pathArquivo + @"\data.json");
            label4.Text = "Lista criada e arquivo data.json gravado com sucesso!!";
            label4.ForeColor = Color.Green;
        }

        private void btnCarregarGrid_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                var novoTeste = new Teste
                {
                    Codigo = i,
                    Descricao = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")
                };

                _listTesteNovo.Add(novoTeste);
            }
            dataJson.DataSource = _listTesteNovo;
            dataJson.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            label4.Text = "Grid carregado com sucesso!!";
            label4.ForeColor = Color.Green;
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtCep.Text != "")
            {
                var clientCep = new WSCorreios.AtendeClienteClient();
                var retornoCep = await clientCep.consultaCEPAsync(txtCep.Text);
                var dataJson = JsonConvert.SerializeObject(retornoCep.@return, Formatting.Indented);
                txtResultCep.Text = dataJson;

                label4.Text = "CONSULTA EFETUADA COM SUCESSO";
                label4.ForeColor = Color.Green;
            }
            else
            {
                label4.Text = "";
                label17.Text = "CEP INVÁLIDO";
                label17.ForeColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = _client.GetAsync(_urlBank).Result;
                response.EnsureSuccessStatusCode();

                var result = response.Content.ReadAsStringAsync();
                var resultJsonBank = JsonConvert.DeserializeObject<List<BankModel>>(result.Result);

                if (resultJsonBank.Count != 0)
                {
                    dataGridBanco.DataSource = resultJsonBank;
                    dataGridBanco.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    label4.Text = "Consulta feita com sucesso!";

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Banco não encontrado!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                var bytes = client.DownloadData("https://redeservice.com.br/wp-content/uploads/2020/07/redeservice-logo.png");
                string base64String = Convert.ToBase64String(bytes);

                txtBaixarImagem.Text = base64String;
                label4.Text = "Arquivo Baixado e Visualizado em base64";
            }
        }
    }
}
