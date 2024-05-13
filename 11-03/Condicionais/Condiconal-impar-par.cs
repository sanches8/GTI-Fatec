namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Forneça um número inteiro: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("O número " + num + " é par ");
            }
            else
            {
                Console.WriteLine("O número " + num + " é ímpar");
            }
        }
    }
}
