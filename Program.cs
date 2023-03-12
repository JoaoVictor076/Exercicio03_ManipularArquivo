using ManipularArquivo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class program
{
    public static void Main()
    {
        manipulacaoArquivo manipulador = new manipulacaoArquivo();
        manipulador.Conteudo = "joao victor";
        manipulador.EnderecoNomeArquivo = @"C:\Users\joaok\Desktop\arquivo\manipular.txt";
        if (manipulador.SalvarDadosEArquivo())
        {
            Console.WriteLine("arquivo salvo com sucesso!");
        }
        Console.WriteLine(manipulador.PesquisarConteudoArquivo(manipulador.EnderecoNomeArquivo));
    }
}