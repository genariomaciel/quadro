using System;

namespace Quadro.DTO
{
    public class Estrutura
    {
        public Estrutura()
        {
            this.ReuniaoMeioSemana = DateTime.Now.ToString("yyyy-MM-dd");
            this.ReuniaoFimSemana = DateTime.Now.ToString("yyyy-MM-dd");
        }
        public Estrutura(DateTime semana)
        {
            this.ReuniaoMeioSemana = semana.ToString("yyyy-MM-dd");
            this.ReuniaoFimSemana = semana.ToString("yyyy-MM-dd");
        }

        public string Mes { get; set; }

        public string Data { get; set; }
        public string Sabado { get; set; }
        public string ReuniaoMeioSemana { get; set; }
        public string ReuniaoFimSemana { get; set; }
        public string FormatadoMeioSemana { get; set; }
        public string FormatadoFimSemana { get; set; }
        public string FormatadoSemana1 { get; set; }
        public string FormatadoSemana2 { get; set; }
        public string PrimeiraSemana { get; set; }
        public string SalaB { get; set; }
        public string VisitaSup { get; set; }
        public string Assembleia { get; set; }
        public string Congresso { get; set; }
        public string NVMC_Presidente { get; set; }
        public string NVMC_DiscursoTema { get; set; }
        public string NVMC_DiscursoDesignado { get; set; }
        public string NVMC_Joias { get; set; }
        public string NVMC_SalaA_Dirigente { get; set; }
        public string NVMC_SalaA_Leitura { get; set; }
        public string NVMC_NomePrimeiraParte { get; set; }
        public string NVMC_SalaA_PrimeiraParteDesignado { get; set; }
        public string NVMC_SalaA_PrimeiraParteAjudante { get; set; }
        public string NVMC_NomeSegundaParte { get; set; }
        public string NVMC_SalaA_SegundaParteDesignado { get; set; }
        public string NVMC_SalaA_SegundaParteAjudante { get; set; }
        public string NVMC_NomeTerceiraParte { get; set; }
        public string NVMC_SalaA_TerceiraParteDesignado { get; set; }
        public string NVMC_SalaA_TerceiraParteAjudante { get; set; }
        public string NVMC_NomeQuartaParte { get; set; }
        public string NVMC_SalaA_QuartaParteDesignado { get; set; }
        public string NVMC_SalaA_QuartaParteAjudante { get; set; }
        public string NVMC_SalaB_Dirigente { get; set; }
        public string NVMC_SalaB_Leitura { get; set; }
        public string NVMC_SalaB_PrimeiraParteDesignado { get; set; }
        public string NVMC_SalaB_PrimeiraParteAjudante { get; set; }
        public string NVMC_SalaB_SegundaParteDesignado { get; set; }
        public string NVMC_SalaB_SegundaParteAjudante { get; set; }
        public string NVMC_SalaB_TerceiraParteDesignado { get; set; }
        public string NVMC_SalaB_TerceiraParteAjudante { get; set; }
        public string NVMC_SalaB_QuartaParteDesignado { get; set; }
        public string NVMC_SalaB_QuartaParteAjudante { get; set; }
        public string NVMC_Parte1_Dur { get; set; }
        public string NVMC_Parte1_Tema { get; set; }
        public string NVMC_Parte1_Designado { get; set; }
        public string NVMC_Parte2_Dur { get; set; }
        public string NVMC_Parte2_Tema { get; set; }
        public string NVMC_Parte2_Designado { get; set; }
        public string NVMC_Parte3_Dur { get; set; }
        public string NVMC_Parte3_Tema { get; set; }
        public string NVMC_Parte3_Designado { get; set; }
        public string NVMC_EBC_Dirigente { get; set; }
        public string NVMC_EBC_Leitor { get; set; }
        public string RP_Presidente { get; set; }
        public string RP_Discurso_Tema { get; set; }
        public string RP_Discurso_Orador { get; set; }
        public string RP_Discurso_Congregacao { get; set; }
        public string RP_Sentinela_Leitor { get; set; }
        public string SC_Residencial { get; set; }
        public string SC_Comercial { get; set; }
        public string DS_Indicador_MS { get; set; }
        public string DS_Indicador_FS { get; set; }
        public string DS_Audio_MS { get; set; }
        public string DS_Audio_FS { get; set; }
        public string DS_Video_MS { get; set; }
        public string DS_Video_FS { get; set; }
        public string DS_Brigada_ChefeTurno { get; set; }
        public string DS_Brigada_Lider { get; set; }
        public string DS_Brigada_Brigadista1 { get; set; }
        public string DS_Brigada_Brigadista2 { get; set; }
        public string DS_Transporte_MS { get; set; }
        public string DS_Transporte_FS { get; set; }
        public string DS_Marcador_Tempo { get; set; }
        public string DS_Limpeza_Grupo { get; set; }
        public string DS_Limpeza_Dirigente { get; set; }
        public string NVMC_Oracao_Inicial { get; set; }
        public string NVMC_Oracao_Final { get; set; }
    }
}
