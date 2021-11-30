using System;

namespace validação_de_cpf
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cpf = new int[11];

            //leitura do cpf vai ser de fomra sequencial
            Console.WriteLine("Digite seu cpf: ");
            
            for(int i = 0; i < cpf.Length; i++)
            {
                cpf[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();
            
            for(int i = 0; i < cpf.Length; i++)
            {
                Console.Write(cpf[i] + " ");
            }

            Console.WriteLine("");
            Console.WriteLine("---------------------");

            
            //calculo do Primeiro digito
            int mult1 = 10;
            int soma1 = 0;
            int rest1 = 0;
            for (int i = 0; i <= 8; i++)
            {
                soma1 += cpf[i] * mult1;
                mult1--;
            }
            rest1 = soma1 % 11;
            rest1 = 11 - rest1;


            //calculo do Segundo digito
            if(rest1 < 10 && rest1 != 0)
            {
                int mult2 = 11;
                int soma2 = 0;
                int rest2 = 0;
                for (int i = 0; i <= 9; i++)
                {
                    soma2 += cpf[i] * mult2;
                    mult2--;
                }
                rest2 = soma2 % 11;
                rest2 = 11 - rest2;

                //verificando a validação
                if (cpf[9] == rest1 && cpf[10] == rest2)
                {
                    Console.WriteLine("CPF Valido!!!");
                }
                else
                {
                    Console.WriteLine("CPF Invalido!!!");
                }
            }
            else
            {
                Console.WriteLine("CPF Valido!!");    
            }
        }
    }
}
