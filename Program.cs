using System;
using System.IO;
namespace StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o Nome do Arquivo:");
            string filename = Console.ReadLine();
            FileInfo file = new FileInfo(filename);
            if(file.Exists)
            {
                Console.WriteLine("Tamanho: "+file.Length+"kb");
                Console.WriteLine("Extensão: "+file.Extension);
                Console.WriteLine("Path: "+file.FullName);
            }
            else
            {
                Console.WriteLine("Arquivo não existe!");
            }
            StreamWriter sw = new StreamWriter(filename,true);
            Console.Write("Digite o seu Nome:");
            string nome = Console.ReadLine();
            Console.Write("Digite o seu Idade:");
            string idade = Console.ReadLine();
            sw.WriteLine(nome+";"+idade);
            sw.Close();
        }
    }
}
