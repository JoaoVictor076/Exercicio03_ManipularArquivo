using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipularArquivo
{
    public class manipulacaoArquivo
    {
        public string Arquivo;
        public string DiretorioArquivo;

        public bool SalvarDadosEArquivo()
        {
            try
            {
                if (!File.Exists(DiretorioArquivo))
                    File.Create(DiretorioArquivo).Close();

                StreamWriter write = new StreamWriter(DiretorioArquivo);
                write.Write(Arquivo);
                write.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public string PesquisarConteudoArquivo(string diretorio)
        {
            if (!File.Exists(diretorio))
                return "";

            StreamReader sr = new StreamReader(diretorio);
            string arquivo = sr.ReadToEnd();
            sr.Close();
            return arquivo;

        }


    }
}

