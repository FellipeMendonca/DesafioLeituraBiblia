using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LeiturBiblia
{
    class ManipuladorArquivo
    {
        private static string EnderecoArquivo = AppDomain.CurrentDomain.BaseDirectory + "Biblia.txt";

        public static void LerBiblia(string livro, int capitulo, int versiculo)
        {
            if (File.Exists(EnderecoArquivo))
            {
                using (StreamReader leitor = File.OpenText(EnderecoArquivo))
                {
                    while (leitor.Peek() >= 0)
                    {
                        Console.WriteLine(leitor.ReadLine());

                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
