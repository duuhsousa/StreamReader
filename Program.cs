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
                Console.WriteLine("Tamanho: "+file.FullName);
            }
            else
            {
                Console.WriteLine("Arquivo não existe!");
            }
            StreamWriter sw = new StreamWriter(filename,true);
            Console.Write("Digite o Conteúdo:");
            string text = Console.ReadLine();
            sw.WriteLine(text);
            sw.Close();
        }
    }
}
