using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeiturBiblia
{
    class Program
    {
        static void Main(string[] args)
        {
            string livro, versiculo;

            string capitulo;
            livro = "apocalipse";
            capitulo = livro + " [" + "12" + "]";
            versiculo = "10";
            ManipuladorArquivo.LerBiblia(livro.ToUpper(), capitulo.ToUpper(), versiculo);
            Console.ReadKey();
        }
    }
}
