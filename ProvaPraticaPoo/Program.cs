using System;

namespace Prova
{
    internal static class Program
    {
        
        private static void Main(string[] args)
        {
            var caminhao = new Caminhao("C-01", 12000, "Diesel", 4);
            var van = new Van("V-10", 1500, "Gasolina", true);

            Console.WriteLine(caminhao.RegistrarEntrega());
            Console.WriteLine(caminhao.RealizarManutencao());

            Console.WriteLine(van.RegistrarEntrega());
            Console.WriteLine(van.RealizarManutencao());

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
