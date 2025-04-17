using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Previsao_do_Tempo
{
    public partial class forms1 : Form
    {

        private const String API_KEY = "167ee59d2341ff6d6b1496222a21c59e";

        public forms1()
        {
            InitializeComponent();
            btnBuscar.Click += new EventHandler(btnBuscar_Click);
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            string cidade = txtCidade.Text.Trim();
            if (string.IsNullOrEmpty(cidade))
            {
                MessageBox.Show("Por favor, insira o nome de uma cidade.");
                return;
            }
            lblResultado.Text = "Buscando...";
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={cidade}&appid={API_KEY}&lang=pt_br&units=metric";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string resposta = await client.GetStringAsync(url);

                    JObject json = JObject.Parse(resposta);

                    string descricao = json["weather"][0]["description"].ToString();
                    string temperatura = json["main"]["temp"].ToString();
                    string umidade = json["main"]["humidity"].ToString();


                    lblResultado.Text = $"Tempo em {cidade}:\n" +
                                        $"{descricao}\n" +
                                        $"Temperatura: {temperatura}°C\n" +
                                        $"Umidade: {umidade}%\n";
                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = $"Erro ao buscar dados" + ex.Message;
            }
        }

        private void txtCidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar.PerformClick();        // Aciona o clique do botão buscar
                e.SuppressKeyPress = true;       // Impede o som do "beep"
            }
        }
    }
}
