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
            livro = "EXODO";
            capitulo = livro + " [" + "3" + "]";
            versiculo = "10";
            ManipuladorArquivo.LerBiblia(livro.ToUpper(), capitulo, versiculo);
            Console.ReadKey();
        }
    }
}
