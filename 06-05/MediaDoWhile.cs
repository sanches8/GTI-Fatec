float num, soma = 0, media;
int cont = 0;
//Entrada
do {
    Console.WriteLine("Entre com 0 para terminar o laço");
    num = float.Parse(Console.ReadLine());
    soma += num;
    cont++;

} while (num != 0);
if (cont > 1) {
    media = soma / (cont - 1);
    Console.WriteLine("A média dos valores é " + media + ".");
}
else{
    Console.WriteLine("Quantidade de valores número entrada pelo usuário igual a zero");
}
  
    