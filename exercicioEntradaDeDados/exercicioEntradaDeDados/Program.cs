namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio Fixação entrada de dados --> ");
            Console.WriteLine("Entre com o seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double precoProduto = double.Parse(Console.ReadLine());


            Console.WriteLine("Entre com o seu último nome, idade e altura (mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');

            string nome2 = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);
            Console.WriteLine(nome2);
            Console.WriteLine(idade);
            Console.WriteLine(altura);

            double preco = double.Parse(Console.ReadLine());

            double desconto = 0;

            if (preco > 100.0)
            {
                desconto = preco * 0.1;
            }

            Console.WriteLine(desconto);









        }
    }
}
