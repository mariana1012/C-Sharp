using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {


        // FUNÇÂO 
        Console.WriteLine("Digite tres números: ");
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());

        double resultado = Maior(n1, n2, n3);

        Console.WriteLine("Maior = " + resultado);

        // Etrutura de repetição WHILE 
        Console.WriteLine("Digite um número para entrar na condição: ");
        double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        while (y >= 0)
        {

            double raiz = Math.Sqrt(y);
            Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Digite um outro número: ");
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        }
        Console.WriteLine("Este é um número negativo");


        // Estrutura de repetição FOR
        // Para quando souber a quantidade de repetições || contagens
        // for (inico, condição, incremento){}

        Console.WriteLine("Quantos número voce quer digitar? ");

        int numRepeticao = int.Parse(Console.ReadLine());

        int soma = 0;
        for (int i = 1; i <= numRepeticao; i++)
        {
            Console.WriteLine("Valor: #{0}", i);
            int valor = int.Parse(Console.ReadLine());
            soma += valor;
        }

        Console.WriteLine("soma:" +soma);
    }
    static int Maior(int a, int b, int c)
        {

            int m = 0;

            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c && b > a)
            {
                m = b;
            }
            else
            {
                m = c;
            }

            return m;


            


        
    }

}