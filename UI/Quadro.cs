using System;
using System.Threading;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using Quadro.BLL;
using Quadro.DTO;
namespace Quadro.UI

{
    public partial class Quadro : Form
    {
        private BLLSemana semana = new BLLSemana(DateTime.Now);
        private string caminhoAplicacao = Directory.GetCurrentDirectory();

        public Quadro()  
        {
            InitializeComponent();
        }

        private void QuadroAnuncios_Load(object sender, EventArgs e)
        {

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(Path.Combine(caminhoAplicacao, "QUADRO.xml"));
            XmlNode lastChild = xmlDocument.LastChild;
            XmlNode firstChild = lastChild.FirstChild;
            pnlCor1.BackColor = (colorDialog1.Color = ColorTranslator.FromHtml(firstChild.SelectSingleNode("cor1").InnerText));
            pnlCor2.BackColor = (colorDialog2.Color = ColorTranslator.FromHtml(firstChild.SelectSingleNode("cor2").InnerText));

            Carregar();
        }

        private void Carregar()
        {
            try
            {
                lblSemana.Text = semana.SemanaPorExtenso();
                n_Mes.Value = semana.Inicio.Month;
                n_Ano.Value = semana.Inicio.Year;
                string nomeArquivo = Path.Combine(caminhoAplicacao, semana.Inicio.ToString("yyyy"), semana.Inicio.ToString("MM"), semana.Inicio.ToString("yyyy-MM-dd") + ".xml");
                if (!File.Exists(nomeArquivo))
                {
                    BLLQuadro.CriarCaminho(caminhoAplicacao, nomeArquivo, semana.Inicio);

                    PreencherFormulario(new Estrutura(semana.DataReuniaoMeioSemana()));

                    txtReuniaoMeioSemana.Text = semana.DataReuniaoMeioSemana().ToString(Application.CurrentCulture.DateTimeFormat.LongDatePattern);
                    txtReuniaoFimSemana.Text = semana.DataReuniaoFimSemana().ToString(Application.CurrentCulture.DateTimeFormat.LongDatePattern);

                    Salvar(true);
                }
                else
                {
                    PreencherFormulario(BLLQuadro.CarregarArquivoDados(nomeArquivo));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void Salvar(bool first = false)
        {
            try
            {
                BLLQuadro.Salvar(caminhoAplicacao, semana, LerDoFormulario());
                if (!first)
                    MessageBox.Show("Salvo com sucesso!", "Atenção");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }
        private void PreencherFormulario(Estrutura estrutura)
        {

            txtReuniaoMeioSemana.Text = Convert.ToDateTime(estrutura.ReuniaoMeioSemana).ToString(Application.CurrentCulture.DateTimeFormat.LongDatePattern);
            txtReuniaoFimSemana.Text = Convert.ToDateTime(estrutura.ReuniaoFimSemana).ToString(Application.CurrentCulture.DateTimeFormat.LongDatePattern);

            chk_PrimeiraSemana.Checked = (estrutura.PrimeiraSemana == "true");
            chk_SalaB.Checked = (estrutura.SalaB == "true");
            chk_VisitaSup.Checked = (estrutura.VisitaSup == "true");
            chk_Assembleia.Checked = (estrutura.Assembleia == "true");
            chk_Congresso.Checked = (estrutura.Congresso == "true");
            txt_NVMC_Presidente.Text = estrutura.NVMC_Presidente;
            txt_NVMC_Oracao_Inicial.Text = estrutura.NVMC_Oracao_Inicial;
            txt_NVMC_Oracao_Final.Text = estrutura.NVMC_Oracao_Final;
            txt_NVMC_DiscursoTema.Text = estrutura.NVMC_DiscursoTema;
            txt_NVMC_DiscursoDesignado.Text = estrutura.NVMC_DiscursoDesignado;
            txt_NVMC_Joias.Text = estrutura.NVMC_Joias;
            txt_NVMC_SalaA_Dirigente.Text = estrutura.NVMC_SalaA_Dirigente;
            txt_NVMC_SalaA_Leitura.Text = estrutura.NVMC_SalaA_Leitura;
            txt_NVMC_NomePrimeiraParte.Text = estrutura.NVMC_NomePrimeiraParte;
            txt_NVMC_NomeSegundaParte.Text = estrutura.NVMC_NomeSegundaParte;
            txt_NVMC_NomeTerceiraParte.Text = estrutura.NVMC_NomeTerceiraParte;
            txt_NVMC_NomeQuartaParte.Text = estrutura.NVMC_NomeQuartaParte;
            txt_NVMC_SalaA_PrimeiraParteDesignado.Text = estrutura.NVMC_SalaA_PrimeiraParteDesignado;
            txt_NVMC_SalaA_PrimeiraParteAjudante.Text = estrutura.NVMC_SalaA_PrimeiraParteAjudante;
            txt_NVMC_SalaA_SegundaParteDesignado.Text = estrutura.NVMC_SalaA_SegundaParteDesignado;
            txt_NVMC_SalaA_SegundaParteAjudante.Text = estrutura.NVMC_SalaA_SegundaParteAjudante;
            txt_NVMC_SalaA_TerceiraParteDesignado.Text = estrutura.NVMC_SalaA_TerceiraParteDesignado;
            txt_NVMC_SalaA_TerceiraParteAjudante.Text = estrutura.NVMC_SalaA_TerceiraParteAjudante;
            txt_NVMC_SalaA_QuartaParteDesignado.Text = estrutura.NVMC_SalaA_QuartaParteDesignado;
            txt_NVMC_SalaA_QuartaParteAjudante.Text = estrutura.NVMC_SalaA_QuartaParteAjudante;
            txt_NVMC_SalaB_Dirigente.Text = estrutura.NVMC_SalaB_Dirigente;
            txt_NVMC_SalaB_Leitura.Text = estrutura.NVMC_SalaB_Leitura;
            txt_NVMC_SalaB_PrimeiraParteDesignado.Text = estrutura.NVMC_SalaB_PrimeiraParteDesignado;
            txt_NVMC_SalaB_PrimeiraParteDesignado.Text = estrutura.NVMC_SalaB_PrimeiraParteAjudante;
            txt_NVMC_SalaB_SegundaParteDesignado.Text = estrutura.NVMC_SalaB_SegundaParteDesignado;
            txt_NVMC_SalaB_SegundaParteDesignado.Text = estrutura.NVMC_SalaB_SegundaParteAjudante;
            txt_NVMC_SalaB_TerceiraParteDesignado.Text = estrutura.NVMC_SalaB_TerceiraParteDesignado;
            txt_NVMC_SalaB_TerceiraParteDesignado.Text = estrutura.NVMC_SalaB_TerceiraParteAjudante;
            txt_NVMC_SalaB_QuartaParteDesignado.Text = estrutura.NVMC_SalaB_QuartaParteDesignado;
            txt_NVMC_SalaB_QuartaParteAjudante.Text = estrutura.NVMC_SalaB_QuartaParteAjudante;
            txt_NVMC_Parte1_Dur.Text = estrutura.NVMC_Parte1_Dur;
            txt_NVMC_Parte1_Tema.Text = estrutura.NVMC_Parte1_Tema;
            txt_NVMC_Parte1_Designado.Text = estrutura.NVMC_Parte1_Designado;
            txt_NVMC_Parte2_Dur.Text = estrutura.NVMC_Parte2_Dur;
            txt_NVMC_Parte2_Tema.Text = estrutura.NVMC_Parte2_Tema;
            txt_NVMC_Parte2_Designado.Text = estrutura.NVMC_Parte2_Designado;
            txt_NVMC_Parte3_Dur.Text = estrutura.NVMC_Parte3_Dur;
            txt_NVMC_Parte3_Tema.Text = estrutura.NVMC_Parte3_Tema;
            txt_NVMC_Parte3_Designado.Text = estrutura.NVMC_Parte3_Designado;
            txt_NVMC_EBC_Dirigente.Text = estrutura.NVMC_EBC_Dirigente;
            txt_NVMC_EBC_Leitor.Text = estrutura.NVMC_EBC_Leitor;
            txt_RP_Presidente.Text = estrutura.RP_Presidente;
            txt_RP_Discurso_Tema.Text = estrutura.RP_Discurso_Tema;
            txt_RP_Discurso_Orador.Text = estrutura.RP_Discurso_Orador;
            txt_RP_Discurso_Cong.Text = estrutura.RP_Discurso_Congregacao;
            txt_RP_Sentinela_Leitor.Text = estrutura.RP_Sentinela_Leitor;
            txt_SC_Residencial.Text = estrutura.SC_Residencial;
            txt_SC_Comercial.Text = estrutura.SC_Comercial;
            txt_DS_Indicador_MS.Text = estrutura.DS_Indicador_MS;
            txt_DS_Indicador_FS.Text = estrutura.DS_Indicador_FS;
            txt_DS_Video_MS.Text = estrutura.DS_Video_MS;
            txt_DS_Video_FS.Text = estrutura.DS_Video_FS;
            txt_DS_Audio_MS.Text = estrutura.DS_Audio_MS;
            txt_DS_Audio_FS.Text = estrutura.DS_Audio_FS;
            txt_DS_Brigada_ChefeTurno.Text = estrutura.DS_Brigada_ChefeTurno;
            txt_DS_Brigada_Lider.Text = estrutura.DS_Brigada_Lider;
            txt_DS_Brigada_Brigadista1.Text = estrutura.DS_Brigada_Brigadista1;
            txt_DS_Brigada_Brigadista2.Text = estrutura.DS_Brigada_Brigadista2;
            txt_DS_Transporte_MS.Text = estrutura.DS_Transporte_MS;
            txt_DS_Transporte_FS.Text = estrutura.DS_Transporte_FS;
            txt_DS_Limpeza_Grupo.Text = estrutura.DS_Limpeza_Grupo;
            txt_DS_Limpeza_Dirigente.Text = estrutura.DS_Limpeza_Dirigente;
            txt_DS_Marcador_Tempo.Text = estrutura.DS_Marcador_Tempo;
        }

        private Estrutura LerDoFormulario()
        {
            Estrutura estrutura = new Estrutura();
            estrutura.Mes = n_Mes.Value.ToString();
            estrutura.Data = semana.Inicio.ToString("yyyy-MM-dd");
            estrutura.Sabado = semana.Inicio.AddDays(5.0).ToString("yyyy-MM-dd");
            estrutura.ReuniaoMeioSemana = semana.DataReuniaoMeioSemana().ToString("yyyy-MM-dd");
            estrutura.ReuniaoFimSemana = semana.DataReuniaoFimSemana().ToString("yyyy-MM-dd");
            estrutura.PrimeiraSemana = (chk_PrimeiraSemana.Checked ? "true" : "false");
            estrutura.SalaB = (chk_SalaB.Checked ? "true" : "false");
            estrutura.VisitaSup = (chk_VisitaSup.Checked ? "true" : "false");
            estrutura.Assembleia = (chk_Assembleia.Checked ? "true" : "false");
            estrutura.Congresso = (chk_Congresso.Checked ? "true" : "false");

            estrutura.FormatadoFimSemana = semana.DataFormatada(semana.DataReuniaoFimSemana());
            estrutura.FormatadoMeioSemana = semana.DataFormatada(semana.DataReuniaoMeioSemana());
            estrutura.FormatadoSemana1 = "Semana de " + semana.SemanaPorExtenso();
            estrutura.FormatadoSemana2 = semana.DiaPorExtenso(chk_PrimeiraSemana.Checked);

            estrutura.NVMC_Presidente = ToPrimeiraMaiuscula(txt_NVMC_Presidente.Text);
            estrutura.NVMC_Oracao_Inicial = txt_NVMC_Oracao_Inicial.Text;
            estrutura.NVMC_Oracao_Final = txt_NVMC_Oracao_Final.Text;
            estrutura.NVMC_DiscursoTema = txt_NVMC_DiscursoTema.Text;
            estrutura.NVMC_DiscursoDesignado = ToPrimeiraMaiuscula(txt_NVMC_DiscursoDesignado.Text);
            estrutura.NVMC_Joias = txt_NVMC_Joias.Text;
            estrutura.NVMC_SalaA_Dirigente = ToPrimeiraMaiuscula(txt_NVMC_SalaA_Dirigente.Text);
            estrutura.NVMC_SalaA_Leitura = ToPrimeiraMaiuscula(txt_NVMC_SalaA_Leitura.Text);
            estrutura.NVMC_NomePrimeiraParte = txt_NVMC_NomePrimeiraParte.Text;
            estrutura.NVMC_NomeSegundaParte = txt_NVMC_NomeSegundaParte.Text;
            estrutura.NVMC_NomeTerceiraParte = txt_NVMC_NomeTerceiraParte.Text;
            estrutura.NVMC_NomeQuartaParte = txt_NVMC_NomeQuartaParte.Text;
            estrutura.NVMC_SalaA_PrimeiraParteDesignado = ToPrimeiraMaiuscula(txt_NVMC_SalaA_PrimeiraParteDesignado.Text);
            estrutura.NVMC_SalaA_PrimeiraParteAjudante = ToPrimeiraMaiuscula(txt_NVMC_SalaA_PrimeiraParteAjudante.Text);
            estrutura.NVMC_SalaA_SegundaParteDesignado = ToPrimeiraMaiuscula(txt_NVMC_SalaA_SegundaParteDesignado.Text);
            estrutura.NVMC_SalaA_SegundaParteAjudante = ToPrimeiraMaiuscula(txt_NVMC_SalaA_SegundaParteAjudante.Text);
            estrutura.NVMC_SalaA_TerceiraParteDesignado = ToPrimeiraMaiuscula(txt_NVMC_SalaA_TerceiraParteDesignado.Text);
            estrutura.NVMC_SalaA_TerceiraParteAjudante = ToPrimeiraMaiuscula(txt_NVMC_SalaA_TerceiraParteAjudante.Text);
            estrutura.NVMC_SalaA_QuartaParteDesignado = ToPrimeiraMaiuscula(txt_NVMC_SalaA_QuartaParteDesignado.Text);
            estrutura.NVMC_SalaA_QuartaParteAjudante = ToPrimeiraMaiuscula(txt_NVMC_SalaA_QuartaParteAjudante.Text);
            estrutura.NVMC_SalaB_Dirigente = ToPrimeiraMaiuscula(txt_NVMC_SalaB_Dirigente.Text);
            estrutura.NVMC_SalaB_Leitura = ToPrimeiraMaiuscula(txt_NVMC_SalaB_Leitura.Text);
            estrutura.NVMC_SalaB_PrimeiraParteDesignado = ToPrimeiraMaiuscula(txt_NVMC_SalaB_PrimeiraParteDesignado.Text);
            estrutura.NVMC_SalaB_PrimeiraParteAjudante = ToPrimeiraMaiuscula(txt_NVMC_SalaB_PrimeiraParteAjudante.Text);
            estrutura.NVMC_SalaB_SegundaParteDesignado = ToPrimeiraMaiuscula(txt_NVMC_SalaB_SegundaParteDesignado.Text);
            estrutura.NVMC_SalaB_SegundaParteAjudante = ToPrimeiraMaiuscula(txt_NVMC_SalaB_SegundaParteAjudante.Text);
            estrutura.NVMC_SalaB_TerceiraParteDesignado = ToPrimeiraMaiuscula(txt_NVMC_SalaB_TerceiraParteDesignado.Text);
            estrutura.NVMC_SalaB_TerceiraParteAjudante = ToPrimeiraMaiuscula(txt_NVMC_SalaB_TerceiraParteAjudante.Text);
            estrutura.NVMC_SalaB_QuartaParteDesignado = ToPrimeiraMaiuscula(txt_NVMC_SalaB_QuartaParteDesignado.Text);
            estrutura.NVMC_SalaB_QuartaParteAjudante = ToPrimeiraMaiuscula(txt_NVMC_SalaB_QuartaParteAjudante.Text);
            estrutura.NVMC_Parte1_Dur = txt_NVMC_Parte1_Dur.Text;
            estrutura.NVMC_Parte1_Tema = txt_NVMC_Parte1_Tema.Text;
            estrutura.NVMC_Parte1_Designado = ToPrimeiraMaiuscula(txt_NVMC_Parte1_Designado.Text);
            estrutura.NVMC_Parte2_Dur = txt_NVMC_Parte2_Dur.Text;
            estrutura.NVMC_Parte2_Tema = txt_NVMC_Parte2_Tema.Text;
            estrutura.NVMC_Parte2_Designado = ToPrimeiraMaiuscula(txt_NVMC_Parte2_Designado.Text);
            estrutura.NVMC_Parte3_Dur = txt_NVMC_Parte3_Dur.Text;
            estrutura.NVMC_Parte3_Tema = txt_NVMC_Parte3_Tema.Text;
            estrutura.NVMC_Parte3_Designado = ToPrimeiraMaiuscula(txt_NVMC_Parte3_Designado.Text);
            estrutura.NVMC_EBC_Dirigente = ToPrimeiraMaiuscula(txt_NVMC_EBC_Dirigente.Text);
            estrutura.NVMC_EBC_Leitor = ToPrimeiraMaiuscula(txt_NVMC_EBC_Leitor.Text);
            estrutura.RP_Presidente = ToPrimeiraMaiuscula(txt_RP_Presidente.Text);
            estrutura.RP_Discurso_Tema = txt_RP_Discurso_Tema.Text;
            estrutura.RP_Discurso_Orador = ToPrimeiraMaiuscula(txt_RP_Discurso_Orador.Text);
            estrutura.RP_Discurso_Congregacao = ToPrimeiraMaiuscula(txt_RP_Discurso_Cong.Text);
            estrutura.RP_Sentinela_Leitor = ToPrimeiraMaiuscula(txt_RP_Sentinela_Leitor.Text);
            estrutura.SC_Residencial = ToPrimeiraMaiuscula(txt_SC_Residencial.Text);
            estrutura.SC_Comercial = ToPrimeiraMaiuscula(txt_SC_Comercial.Text);
            estrutura.DS_Indicador_MS = ToPrimeiraMaiuscula(txt_DS_Indicador_MS.Text);
            estrutura.DS_Indicador_FS = ToPrimeiraMaiuscula(txt_DS_Indicador_FS.Text);
            estrutura.DS_Video_MS = ToPrimeiraMaiuscula(txt_DS_Video_MS.Text);
            estrutura.DS_Video_FS = ToPrimeiraMaiuscula(txt_DS_Video_FS.Text);
            estrutura.DS_Audio_MS = ToPrimeiraMaiuscula(txt_DS_Audio_MS.Text);
            estrutura.DS_Audio_FS = ToPrimeiraMaiuscula(txt_DS_Audio_FS.Text);
            estrutura.DS_Brigada_ChefeTurno = ToPrimeiraMaiuscula(txt_DS_Brigada_ChefeTurno.Text);
            estrutura.DS_Brigada_Lider = ToPrimeiraMaiuscula(txt_DS_Brigada_Lider.Text);
            estrutura.DS_Brigada_Brigadista1 = ToPrimeiraMaiuscula(txt_DS_Brigada_Brigadista1.Text);
            estrutura.DS_Brigada_Brigadista2 = ToPrimeiraMaiuscula(txt_DS_Brigada_Brigadista2.Text);
            estrutura.DS_Transporte_MS = ToPrimeiraMaiuscula(txt_DS_Transporte_MS.Text);
            estrutura.DS_Transporte_FS = ToPrimeiraMaiuscula(txt_DS_Transporte_FS.Text);
            estrutura.DS_Limpeza_Grupo = txt_DS_Limpeza_Grupo.Text;
            estrutura.DS_Limpeza_Dirigente = ToPrimeiraMaiuscula(txt_DS_Limpeza_Dirigente.Text);
            estrutura.DS_Marcador_Tempo = txt_DS_Marcador_Tempo.Text;

            return estrutura;
        }

        private void btnProxSemana_Click(object sender, EventArgs e)
        {
            Salvar(true);
            semana.Incrementar(7.0);
            Carregar();
        }

        private void btnSemanaAnt_Click(object sender, EventArgs e)
        {
            Salvar(true);
            semana.Incrementar(-7.0);
            Carregar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarLeitores())
                Salvar(false);
        }
        public bool ValidarLeitores()
        {
            if (txt_RP_Sentinela_Leitor.Text != "" &&
               (txt_RP_Sentinela_Leitor.Text == txt_DS_Indicador_MS.Text ||
                txt_RP_Sentinela_Leitor.Text == txt_DS_Indicador_FS.Text ||
                txt_RP_Sentinela_Leitor.Text == txt_DS_Video_MS.Text ||
                txt_RP_Sentinela_Leitor.Text == txt_DS_Video_FS.Text ||
                txt_RP_Sentinela_Leitor.Text == txt_DS_Audio_MS.Text ||
                txt_RP_Sentinela_Leitor.Text == txt_DS_Audio_FS.Text))
            {
                MessageBox.Show("O leitor do estudo de A Sentinela iválido", "Atenção!");
                return false;
            }
            if (txt_NVMC_EBC_Leitor.Text != "" && 
               (txt_NVMC_EBC_Leitor.Text == txt_DS_Indicador_MS.Text ||
                txt_NVMC_EBC_Leitor.Text == txt_DS_Indicador_FS.Text ||
                txt_NVMC_EBC_Leitor.Text == txt_DS_Video_MS.Text ||
                txt_NVMC_EBC_Leitor.Text == txt_DS_Audio_MS.Text ||
                txt_NVMC_EBC_Leitor.Text == txt_DS_Video_FS.Text ||
                txt_NVMC_EBC_Leitor.Text == txt_DS_Audio_FS.Text))
            {
                MessageBox.Show("O leitor do estudo bíblico inválido", "Atenção!");
                return false;
            }

            if (txt_DS_Indicador_MS.Text != "" && 
               (txt_DS_Indicador_MS.Text == txt_DS_Video_MS.Text ||
                txt_DS_Indicador_MS.Text == txt_DS_Audio_MS.Text ||
                txt_DS_Indicador_MS.Text == txt_DS_Video_FS.Text ||
                txt_DS_Indicador_MS.Text == txt_DS_Audio_FS.Text))
            {
                MessageBox.Show("O indicador de meio de semana iválido.", "Atenção!");
                return false;
            }

            if (txt_DS_Indicador_FS.Text != "" &&
               (txt_DS_Indicador_FS.Text == txt_DS_Video_MS.Text ||
                txt_DS_Indicador_FS.Text == txt_DS_Audio_MS.Text ||
                txt_DS_Indicador_FS.Text == txt_DS_Video_FS.Text ||
                txt_DS_Indicador_FS.Text == txt_DS_Audio_FS.Text))
            {
                MessageBox.Show("O indicador de fim de semana iválido.", "Atenção!");
                return false;
            }
            return true;
        }
        private string ToPrimeiraMaiuscula(string value = "")
        {
            if (value == null || value == "")
                return "";

            value += " ";
            string[] nome = value.Split(Convert.ToChar(' '));
            string nomeFinal = "";
            foreach(var item in nome)
            {
                if (item != "")
                    nomeFinal += item.Substring(0, 1).ToUpper() + item.Substring(1).ToLower() + " ";
            }
            return nomeFinal.Trim();
        }
        private void btnFolhaNvmc_Click(object sender, EventArgs e)
        {
            BLLQuadro.ProcessarFolhaDesignacao(caminhoAplicacao, semana, ColorTranslator.ToHtml(pnlCor1.BackColor), ColorTranslator.ToHtml(pnlCor2.BackColor));
        }
        private void btnGerarQuadro_Click(object sender, EventArgs e)
        {
            BLLQuadro.ProcessarQuadro(caminhoAplicacao, semana, ColorTranslator.ToHtml(pnlCor1.BackColor), ColorTranslator.ToHtml(pnlCor2.BackColor));
        }

        private void pnlCor1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pnlCor1.BackColor = colorDialog1.Color;
        }

        private void pnlCor2_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            pnlCor2.BackColor = colorDialog2.Color;
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}

