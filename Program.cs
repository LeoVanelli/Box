using System;

namespace Box
{
    class Program
    {
        static void construirBox(string name){
            // Constroi a Box contendo o nome do usuário.

            // Constroi a parte de cima.
            Console.Write("+");
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");

            // Constroi os lados e insere o nome do usuário no centro.
            Console.WriteLine("|{0}|",name);

            // Constroi a parte de baixo.
            Console.Write("+");
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
        static void Main(string[] args)
        {
            // Exercício 7 - Exiba seu nome enquadrado em uma caixa.

            // Armazena o nome do usuário para usar no método "construirBox()", e depois limpa a tela.
            Console.Write("Digite seu nome: ");
            string name = Console.ReadLine(); 
            Console.Clear();

            // Escreve o nome do usuário.
            Console.ForegroundColor=ConsoleColor.DarkCyan;
            Console.WriteLine(" Olá, ");
            construirBox(name);

            // Resolução do exercício
            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.WriteLine("Meu nome é:");
            construirBox("Leandro");

            Console.ResetColor();

            Console.Write("Pressione qualquer tecla para fechar o programa. . . ");
            Console.ReadKey();
        }
    }
}
