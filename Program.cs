using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace variaveis
{
    class Program
    {
        private static string nome;
        private static bool cadastrado;

        static void Main(string[] args)
        {
            string nome = "Thaynara Martins de Brito";
            int idade = 17;
            char sexo = 'M';
            double salario = 2.500;
            bool cadastrado = true; //true \\ false

            Console.WriteLine(nome);

            nome = "Thaynara Martins de Brito";
            Console.WriteLine(nome);

            //Console.WriteLine("Meu nome é: " + nome);
            //+ = Concatenação 

            //Console.WriteLine("Meu nome é: " + nome + " e tenho : " + idade + " anos");

            //Console.WriteLine(salario);

            Console.ReadKey();
        }
    }
}
