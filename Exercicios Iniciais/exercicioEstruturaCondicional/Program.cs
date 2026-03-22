using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Numerics;
using System.Xml.Schema;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicios Estruturação de Dados 2

            //01


                int num1 = int.Parse(Console.ReadLine());

                if (num1 < 0){
                    Console.WriteLine("NEGATIVO");
                }
                else
                   {
                    Console.WriteLine("Positivo");
                   }

            //02

                int num2 = int.Parse(Console.ReadLine());

                if (num2 % 2 == 00){
                Console.WriteLine("PAR");
                }
                else {
                Console.WriteLine(" IMPAR ");
                }

            //03

                int A = int.Parse(Console.ReadLine());
                int B = int.Parse(Console.ReadLine());

                    if ( A % B == 0 || B % A == 0)
                    {
                        Console.WriteLine("SÃO MULTIPLOS");
                    }
                    else
                    {
                        Console.WriteLine("NÃO SÃO MULTIPLOS");
                    }


            //04 - Cálculo de horas jogadas do usuário, com horário de inicio e horário final

                    string[] valor = Console.ReadLine().Split(' ');
                    int horaInicial = int.Parse(valor[0]);
                    int horaFinal = int.Parse(valor[1]);

                    int duracao;
                    if (horaInicial < horaFinal)
                    {       
                        duracao = horaFinal - horaInicial;
                    }
                    else
                    {
                        duracao = 24 - horaInicial + horaFinal;
                    }

                    Console.WriteLine(" O JOGO DUROU "+ duracao + "HORAS");

            
            //05 - Ler um item e sua quantidade

            Console.WriteLine(
                "1 -->  Cachorro quente = R$4,00" +
                "2 -->  X-Salada = R$4,50"+
                "3 -->  X-Bacon = R$5,00"+
                "4 -->  Torrada Simples = R$2,00"+
                "5 -->  Refrigerante = R$1,50");
            Console.WriteLine(" Digite o produto desejado e a quantidade desejada respectivamente");


            string[] valores = Console.ReadLine().Split(' ');
                int produto = int.Parse(valores[0]);
                int quantidade = int.Parse(valores[1]);

                double total = 0;
                if (produto == 1)
                {
                    total = quantidade * 4;
                }
                else if (produto == 2)
                {
                    total = quantidade * 4.50;
                }
                else if (produto == 3)
                {
                    total = quantidade * 5;
                }
                else if (produto == 4)
                {
                    total = quantidade * 2;
                }
                else if (produto == 5)
                {
                    total = quantidade * 1.50;
                }

                Console.WriteLine("O valor total: R$ "+ total.ToString("F2", CultureInfo.InvariantCulture));

            //06 

            Console.WriteLine("Digite um valor que esteja entre 0 - 100 para que seja indicado seu intervalo: ");

            double N = double.Parse(Console.ReadLine());

            if (0 > N || N > 100) {
                Console.WriteLine("Fora de Intervalo");
            }
            else if ( N <= 25.0)
            {
                Console.WriteLine("Intervalo [0 - 25] ");
            }
            else if ( N <= 50.0) {
                Console.WriteLine("Intervalo [25 - 50]");
            }
            else if (N <= 75.0)
            {
                Console.WriteLine("Intervalo [50 - 100]");
            }
            else
            {
                Console.WriteLine("Intervalo 75 - 100");
            }

            //07
            string[] coordenadas = Console.ReadLine().Split(" ");
            double coo1= double.Parse(coordenadas[0]);
            double coo2 = double.Parse(coordenadas[1]);

            if (coo1 == 0 || coo2 == 0)
            {
                Console.WriteLine("origem");
            }
            else if (coo1 > 0 || coo2 > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (coo1 < 0 || coo2 > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (coo1 < 0 || coo2 < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (coo1 > 0 ||coo2 < 0)
            {
                Console.WriteLine("Q4");
            }

            //08

            int salario = int.Parse(Console.ReadLine());

            int imposto;
            if (salario <= 2000)
            {
                imposto = (int)0.0;
            }
            else if (salario <= 3000)
            {
                imposto = (int)((salario - 2000.0) * 0.08);
            }
            else if (salario <= 4500)
            {
                imposto = (int)((salario - 3000.0) * 0.018 + 1000.0 *0.08);
            }
            else (imposto > 4500.0){
                imposto = (int)((salario - 4.500)  * 0.028 + 1500.0 * 0.18+ 1000.0 * 0.08)
            }

            if (imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$" + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }

    }
}