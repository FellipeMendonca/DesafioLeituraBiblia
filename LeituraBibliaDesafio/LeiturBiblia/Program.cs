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
            string livro;
            int capitulo, versiculo;
            ManipuladorArquivo.LerBiblia(livro,capitulo,versiculo);
        }
    }
}
