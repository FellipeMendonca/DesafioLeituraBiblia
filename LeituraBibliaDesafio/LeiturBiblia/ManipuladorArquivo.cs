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

        public static void LerBiblia(string livro, string capitulo, string versiculo)
        {
            string frase;
            bool acheiLivro = false;
            bool acheiCapitulo = false;


            if (File.Exists(EnderecoArquivo))

            {
                StreamReader leitor = new StreamReader(EnderecoArquivo, Encoding.GetEncoding("iso-8859-1"));
                using (leitor = File.OpenText(EnderecoArquivo))
                {
                    while (leitor.Peek() >= 0)
                    {
                        frase = leitor.ReadLine();
                        if (frase != "")
                        {
                            if (frase.Contains(livro))
                            {
                                Console.WriteLine("Livro: {0}", frase);
                                Console.ReadKey();
                                acheiLivro = true;

                            }
                            if (frase.Contains(capitulo) && acheiLivro)
                            {
                                Console.WriteLine("Capitulo: {0}", frase);
                                Console.ReadKey();
                                acheiCapitulo = true;
                            }
                            if (frase.Contains(versiculo) && acheiLivro && acheiCapitulo)
                            {
                                Console.WriteLine("Versiculo: {0}", frase);
                                Console.ReadKey();
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
