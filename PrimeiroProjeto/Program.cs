using System;
using System.Globalization;


namespace PrimeiroProjeto {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Quantos quartos vão ser alugados?");
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Estudante[] arrayEstudantes = new Estudante[10];

            for(int i = 0; i < n; i++) {
                Console.WriteLine("Digite o nome:");
                string name = Console.ReadLine();
                Console.WriteLine("Digite o email:");
                string email = Console.ReadLine();
                Console.WriteLine("Digite o quarto:");
                int room = int.Parse(Console.ReadLine());

                arrayEstudantes[room] = new Estudante(name, email);
            }
            Console.WriteLine("------------------- Quartos ocupados -------------------");
            for(int i = 0; i < arrayEstudantes.Length; i++) {
                if (arrayEstudantes[i] != null) {
                    Console.WriteLine($"{i}: {arrayEstudantes[i]}");
                    Console.WriteLine("----------------------------------");
                }
            }
        }
    }
}