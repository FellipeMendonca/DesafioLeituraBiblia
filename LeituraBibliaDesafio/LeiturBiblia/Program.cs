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
            string livro, versiculo, capitulo;
            string resp;
            do
            {
                Console.WriteLine("Encontre o versículo bíblico desejado!");
                Console.WriteLine("Informe o livro: ");
                livro = Console.ReadLine();
                Console.WriteLine("Informe o capítulo:");
                capitulo = livro + " [" + Console.ReadLine() + "]";
                Console.WriteLine("Informe o versículo:");
                versiculo = Console.ReadLine();
                ManipuladorArquivo.LerBiblia(livro.ToUpper(), capitulo.ToUpper(), versiculo);
                Console.WriteLine("Deseja continuar?informe a respectiva letra: Sim(S) ou Não(N)?");
                resp = Console.ReadLine().ToUpper();
                if(resp == "N")
                {
                    Console.WriteLine("Finalizano programa!!");
                    break;
                }
            } while (true);
        }
    }
}
