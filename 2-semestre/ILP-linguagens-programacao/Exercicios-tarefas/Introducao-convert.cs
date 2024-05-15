namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float precoOriginal, percentualDesconto, valorDesconto, precoComDesconto;

            Console.Write("Insira o preço original do item: ");
            precoOriginal = Convert.ToSingle(Console.ReadLine());

            Console.Write("Insira a porcentagem de desconto (%): ");
            percentualDesconto = Convert.ToSingle(Console.ReadLine());

            valorDesconto = precoOriginal * (percentualDesconto / 100);

            precoComDesconto = precoOriginal - valorDesconto;

            Console.WriteLine("O preço com desconto é:" + precoComDesconto);
        }
    }
}
