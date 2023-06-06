using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Quadro.BLL
{
    public class BLLSemana
    {
        public BLLSemana()
        {
            

            this.Inicio = ObterInicioSemana(DateTime.Now);
            this.Final = this.Inicio.AddDays(6.0);
        }
        public BLLSemana(DateTime value)
        {
            
            this.Inicio = ObterInicioSemana(value);
            this.Final = this.Inicio.AddDays(6.0);
        }
        public void Incrementar(double value)
        {
            this.Inicio = this.Inicio.AddDays(value);
            this.Final = this.Final.AddDays(value);

        }
        public DateTime Inicio { get; set; }
        public DateTime Final { get; set; }

        public DateTime ObterInicioSemana(DateTime value)
        {
            DateTime inicio = value;
            while (inicio.DayOfWeek != DayOfWeek.Monday)
            {
                inicio = inicio.AddDays(-1.0);
            }
            return inicio;
        }
        public string DiaPorExtenso(Boolean primeiraSemana)
        {
            StringBuilder sb = new StringBuilder();
            if (primeiraSemana)
            {
                sb.Append("Dia ");
                sb.Append(Inicio.ToString("dd"));
                sb.Append("/");
                sb.Append(Inicio.ToString("MM"));
                sb.Append(" a ");
                sb.Append(Final.ToString("dd"));
            }
            else
            {
                sb.Append("Dia ");
                sb.Append(Inicio.ToString("dd"));
                sb.Append(" a ");
                sb.Append(Final.ToString("dd"));
                sb.Append("/");
                sb.Append(Final.ToString("MM"));
            }
            return sb.ToString();
        }
        public string SemanaPorExtenso()
        {
            StringBuilder sb = new StringBuilder();
            if (this.Inicio.Month == this.Final.Month)
            {
                sb.Append(this.Inicio.ToString("dd"));
                sb.Append(" a ");
                sb.Append(this.Final.ToString("dd"));
                sb.Append(" de ");
                sb.Append(this.NomeDoMes(this.Inicio));
                sb.Append(" de ");
                sb.Append(this.Inicio.Year);
            }
            else
            {
                sb.Append(this.Inicio.ToString("dd"));
                sb.Append(" de ");
                sb.Append(this.NomeDoMes(Inicio));
                sb.Append(" a ");
                sb.Append(this.Final.ToString("dd"));
                sb.Append(" de ");
                sb.Append(this.NomeDoMes(this.Final));
                sb.Append(" de ");
                sb.Append(this.Final.Year);

            }

            return sb.ToString();
        }

        public DateTime DataReuniaoMeioSemana()
        {
            return Inicio.AddDays(Convert.ToInt32(ConfigurationManager.AppSettings["ReuniaoMeioSemana"]));
        }
        public DateTime DataReuniaoFimSemana()
        {
            return Inicio.AddDays(Convert.ToInt32(ConfigurationManager.AppSettings["ReuniaoFimSemana"]));
        }
        public string NomeFinalSemana()
        {
            return "";
        }

        public string NomeDoMes(DateTime dataValue)
        {
            return dataValue.ToString("MMMM");
        }

        public string DiaSemana(DateTime dataValue)
        {
            return dataValue.ToString("dddd");
        }
        public DateTime PrimeiraSegundaFeiraMes()
        {
            DateTime segundaFeira = new DateTime(Inicio.Year, Inicio.Month, 1);
            while (segundaFeira.DayOfWeek != DayOfWeek.Monday)
            {
                segundaFeira = segundaFeira.AddDays(1.0);
            }
            return segundaFeira;
        }
        public DateTime UltimaSegundaFeiraMes()
        {
            DateTime dataTratada = new DateTime(Inicio.Year, Inicio.Month, 1).AddMonths(1);
            while (dataTratada.DayOfWeek != DayOfWeek.Monday)
            {
                dataTratada = dataTratada.AddDays(-1.0);
            }
            return dataTratada;
        }
        public List<DateTime> ListaDeSemanas()
        {
            List<DateTime> listaDeSemanas = new List<DateTime>();
            DateTime itemInicio = PrimeiraSegundaFeiraMes();
            DateTime itemFinal = UltimaSegundaFeiraMes();
            listaDeSemanas.Add(itemInicio);

            while (itemInicio != itemFinal)
            {
                itemInicio = itemInicio.AddDays(7.0);
                listaDeSemanas.Add(itemInicio);
            }
            return listaDeSemanas;
        }
        public string DataFormatada(DateTime dataValue)
        {
            return string.Format("{0}, {1} de {2}", DiaSemana(dataValue), dataValue.ToString("dd"), NomeDoMes(dataValue));
            //estrutura.FormatadoFimSemana = string.Format("{0}, {1} de {2}", semana.DiaSemana(dt_ReuniaoFimSemana.Value.DayOfWeek), dt_ReuniaoFimSemana.Value.ToString("dd"), semana.NomeDoMes(dt_ReuniaoFimSemana.Value.Month));

        }
    }
}
