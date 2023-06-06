using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Xsl;
using System.Diagnostics;
using Quadro.DTO;

namespace Quadro.BLL
{
    public class BLLQuadro
    {
        public static void ProcessarQuadro(string caminho, BLLSemana semana, string cor1, string cor2)
        {
            //# processar oarquivo XML
            ProcessarXml(caminho, semana, cor1, cor2);

            //# Processar o arquivo xls
            ProcessarXsl(caminho, "QUADRO", "QUADRO", "Quadro-" + semana.Inicio.Month.ToString("00") + "-" + semana.Inicio.Year.ToString("0000"));

        }
        
        public static void ProcessarFolhaDesignacao(string caminho, BLLSemana semana, string cor1, string cor2)
        {
            //# processar oarquivo XML
            ProcessarXml(caminho, semana, cor1, cor2);

            //# Processar o arquivo xls
            ProcessarXsl(caminho, "QUADRO", "NVMC", "NVMC-" + semana.Inicio.Month.ToString("00") + "-" + semana.Inicio.Year.ToString("0000"));

        }

        public static void Salvar(string caminho, BLLSemana semana, Estrutura estrutura)
        {
            string nomeDoArquivo = Path.Combine(caminho, semana.Inicio.ToString("yyyy"), semana.Inicio.ToString("MM"), semana.Inicio.ToString("yyyy-MM-dd") + ".xml");

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Estrutura));
            string value = "";
            using (StringWriter stringWriter = new StringWriter())
            {
                using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter))
                {
                    xmlSerializer.Serialize(xmlWriter, estrutura);
                    value = stringWriter.ToString();
                }
            }
            
            StreamWriter streamWriter = new StreamWriter(nomeDoArquivo);
            streamWriter.WriteLine(value);
            streamWriter.Close();
        }
        public static void CriarCaminho(string caminho, string nomeArquivo, DateTime semanaTratada)
        {
            if (!File.Exists(caminho))
            {
                if (!Directory.Exists(Path.Combine(caminho, semanaTratada.ToString("yyyy"))))
                    Directory.CreateDirectory(Path.Combine(caminho, semanaTratada.ToString("yyyy")));
                if (!Directory.Exists(Path.Combine(caminho, semanaTratada.ToString("yyyy"), semanaTratada.ToString("MM"))))
                    Directory.CreateDirectory(Path.Combine(caminho, semanaTratada.ToString("yyyy"), semanaTratada.ToString("MM")));

                FileStream fileStream = File.Create(nomeArquivo);
                fileStream.Close();
            }
        }
        public static Estrutura CarregarArquivoDados(string nomeArquivo)
        {
            StreamReader streamReader = null;
            Estrutura estrutura = null;
            try
            {
                streamReader = new StreamReader(nomeArquivo);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Estrutura));

                estrutura = (Estrutura)xmlSerializer.Deserialize(streamReader);
            }
            catch
            {

            }
            finally
            {
                streamReader.Close();
            }
            return estrutura;
        }
        private static void ProcessarXsl(string caminho, string nomeArquivoXml, string nomeArquivoXsl, string nomeArquivoHtml)
        {
            XslCompiledTransform xslCompiledTransform = new XslCompiledTransform();
            xslCompiledTransform.Load(Path.Combine(caminho, nomeArquivoXsl + ".xsl"));
            xslCompiledTransform.Transform(Path.Combine(caminho, nomeArquivoXml + ".xml"), Path.Combine(caminho, nomeArquivoHtml + ".html"));

            Process.Start(Path.Combine(caminho, nomeArquivoHtml + ".html"));

        }
        private static void ProcessarXml(string caminho, BLLSemana semana, string cor1, string cor2)
        {
            List<DateTime> listaDeSemanas = semana.ListaDeSemanas();

            List<XmlNode> dadosDasSemanas = new List<XmlNode>();
            foreach (DateTime current in listaDeSemanas)
            {
                try
                {
                    string caminhoDoArquivo = Path.Combine(caminho, current.ToString("yyyy"), current.ToString("MM"), current.ToString("yyyy-MM-dd") + ".xml");

                    //# Lendo arquivo da semana
                    StreamReader streamReader = new StreamReader(caminhoDoArquivo);

                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.LoadXml(streamReader.ReadToEnd());
                    dadosDasSemanas.Add(xmlDocument.LastChild);

                    //# Fechando o arquivo
                    streamReader.Close();
                }
                catch
                {
                }
            }
            XmlDocument xmlDocumentPadroes = CarregarXML(Path.Combine(caminho, "PADROES.xml"));

            XmlDocument xmlDocumentDesignacoes = CarregarXML(Path.Combine(caminho, "QUADRO.xml"));

            XmlNode lastChild = xmlDocumentDesignacoes.LastChild;
            XmlNode firstChild = lastChild.FirstChild;
            XmlNode xmlNode = lastChild.SelectSingleNode("padroes");
            XmlNode lastChild2 = lastChild.LastChild;
            firstChild.SelectSingleNode("mes").InnerText = semana.Inicio.Month.ToString();
            firstChild.SelectSingleNode("ano").InnerText = semana.Inicio.Year.ToString();
            firstChild.SelectSingleNode("cor1").InnerText = cor1;
            firstChild.SelectSingleNode("cor2").InnerText = cor2;
            xmlNode.RemoveAll();
            foreach (XmlNode node in xmlDocumentPadroes.LastChild)
            {
                XmlNode newChild = xmlDocumentDesignacoes.ImportNode(node, true);
                xmlNode.AppendChild(newChild);
            }
            lastChild2.RemoveAll();
            foreach (XmlNode node in dadosDasSemanas)
            {
                XmlNode newChild2 = lastChild.OwnerDocument.ImportNode(node, true);
                lastChild2.AppendChild(newChild2);
            }
            xmlDocumentDesignacoes.Save(Path.Combine(caminho, "QUADRO.xml"));
        }
        private static XmlDocument CarregarXML(string nomeArquivo)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(Path.Combine(nomeArquivo));
            return xmlDocument;
        }
    }
}
