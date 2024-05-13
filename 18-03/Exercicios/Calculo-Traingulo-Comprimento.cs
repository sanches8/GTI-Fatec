float a, b, c;

Console.WriteLine("Entre com o comprimento do primeiro seguimento da reta: ");
a = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Entre com o comprimento do segunda seguimento da reta: ");
b = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Entre com o comprimento do terceiro seguimento da reta: ");
c = Convert.ToSingle(Console.ReadLine());
if(a < b + c && b < c + a && c < a + b){
    Console.WriteLine("Os segmentos de comprimentos: " + a + " e " + b + " e " + c);
}