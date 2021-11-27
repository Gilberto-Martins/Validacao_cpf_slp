using System;

namespace validação_de_cpf
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cpf = new string[11];
            string cpfR;

            Console.WriteLine("Digite seu cpf");
            cpfR = Console.ReadLine();

            for(int i = 0; i < cpfR.Length; i++)
            {
                cpf[i] (cpfR[(cpfR.Length - i - 1)]);
            }

            Console.WriteLine(cpf);
            Console.ReadKey();
        }
    }
}
