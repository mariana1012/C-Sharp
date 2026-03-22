using System;
using System.Globalization;

namespace Programa1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade1 = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine($"{produto1}, cujo o preço é R$ {preco1}");
            Console.WriteLine($"`{produto2}, cuo o preço é R$ {preco2}");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Registro: {idade1} anos de idade, código {codigo} e genero {genero}");

            Console.WriteLine( $"Medida com oito casas decimais {medida:F8}");
            Console.WriteLine($"Medida de forma arredondada {medida:F2} ");
            Console.WriteLine("Medida com sinalização através de ponto da forma globalizada:" + medida.ToString("F2", CultureInfo.InvariantCulture));

            //----------------------- Operadores de atibuição ------------------------

            int a = 10;
                Console.WriteLine(a);
            a += 2;
                Console.WriteLine(a);
            a *= 3;
                Console.WriteLine(a);

            // += também serve para concatenação:

            string g = "ABC";
            Console.WriteLine(g);

            g += "DEF";

            Console.WriteLine(g);
            //----------------------- Operadores aritmético ------------------------
            int b = 10;
            b++; //soma um valor simples

            int c = ++b; //adiciona mais 1 ao B e depois concatena este valor para a veriável

            Console.WriteLine(c);

            //----------------------- Conversão implicita de tipos: colocando uma variável menor float de 4 bytes em uma maior de 8 bytes ------------------------

            float x = 4.5f;

            double y = x;

            //----------------------- Casting: colocando de uma váriável double 8 bytes em uma variável menor float 4 bytes ------------------------

            double d;
            float e;

            d = 5.1;
            e = (float)a;
            Console.WriteLine(e);

            //----------------------- Entrada de dados: ------------------------

            string frase = Console.ReadLine();

            Console.WriteLine(frase);

            //----------------------- Split: ------------------------
          
            string[] vet = Console.ReadLine().split(" ");

            string posicao1 = vet[0];
            string posicao2 = vet[1];
            string posicao3 = vet[2];

            //----------------------- Entrada de dados números e strings + Split: ------------------------
            // variávies na sequencia: nome, sexo, altura, sexo

            double[] variavelMista = double.Parse(Console.ReadLine()).split(" ");

            string nome = vet[0];
            char sexo = char.Parse(vet[1]); // É  nessessácio declarar o tipo do dado novamente " char.Parse "
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3]);




            Console.ReadKey();
        }
    }
}
