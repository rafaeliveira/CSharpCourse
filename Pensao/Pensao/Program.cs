using System;

namespace Pensao
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNumReserva = 0;
            int iTotalReservas = 0;
            string sNome = "";
            string sEmail = "";
            Aluguel[] aluguel = new Aluguel[10];

            Console.WriteLine("-----* Bem vindo a Pensão Família! *-----");

            Console.WriteLine("Quantos quartos deseja reservar?");
            iTotalReservas = int.Parse(Console.ReadLine());

            if(iTotalReservas > 0)
            {
                if(iTotalReservas <= 10)
                {
                    for (int i = 0; i < iTotalReservas; i++)
                    {
                        Console.Write("Entre com o nome do cliente: ");
                        sNome = Console.ReadLine();
                        Console.Write("Entre com o email do cliente: ");
                        sEmail = Console.ReadLine();
                        Console.Write("Entre com o número do quarto desejado (Quartos numerados de 1 - 10): ");
                        Console.WriteLine();
                        iNumReserva = int.Parse(Console.ReadLine());

                        if (iNumReserva > 0 && iNumReserva <= 10)
                        {
                            if (QuartoDisponivel(iNumReserva, aluguel))
                            {
                                aluguel[iNumReserva] = new Aluguel { NumQuarto = iNumReserva, Nome = sNome, Email = sEmail };
                            }
                        }
                        else
                        {
                            Console.WriteLine("Número do quarto inválido! \nPor favor selecione somente quartos numerados de 1 a 10.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Temos no máximo 10 quartos. \nPor favor escolha outro número!");
                }
            }
            else
            {
                Console.WriteLine("Para realizar uma reserva é necessário inserir uma quantidade válida de quartos a serem reservados!");
            }

            for (int i = 0; i < aluguel.Length; i++)
            {
                if(!QuartoDisponivel(i, aluguel))
                {
                    Console.WriteLine(aluguel[i]);
                    Console.WriteLine();
                }
            }
            
        }

        public static bool QuartoDisponivel(int iNumQUarto, Aluguel[] aluguel)
        {
            if (aluguel[iNumQUarto] == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
