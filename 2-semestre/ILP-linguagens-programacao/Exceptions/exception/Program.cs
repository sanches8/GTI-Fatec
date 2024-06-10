/*
Exceções

- sao eventos anomalos ou condicoes de erro que ocorrem durante a 
execução de um programação.

- Quando uma excessao ocorre, o fluxo normal do program é interrompido
e o controle é passado para um manipulador de exceções.

- Bloco try: contem o codigo que pode gerar uma exceção. Se uma exceção ocorrer, a execução será transferida para o catch

- Bloco catch: usado para capturar o erro e lidar com a exceção.

- Bloco finally: contém um códifo que sempre será executado, caso o código seja ou não verdadeiro.
*/

try
{
    int divisor = 0;
    int resultado = 10;

}catch(DivideByZeroException ex)
{
    Console.WriteLine("Erro: divisão por zero não é permitida");
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Bloco finally executado");
}