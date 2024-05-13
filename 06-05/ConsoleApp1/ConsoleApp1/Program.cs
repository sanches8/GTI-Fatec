int cand1 = 0, cand2 = 0, cand3 = 0, nulo = 0, branco = 0, total = 0, voto;
float pnulo, pbranco;

do
{
    Console.Clear();
    Console.WriteLine("1. Candidato Asteiróide");
    Console.WriteLine("2. Candidato Céu Azul");
    Console.WriteLine("3. Candidato Marciano Verdinho");
    Console.WriteLine("4. Nulo");
    Console.WriteLine("5. Sair");
    Console.WriteLine("Digite a sua opção e voto: ");
    voto = int.Parse(Console.ReadLine());
    switch (voto)
    {
        case 1:
            cand1++;
            total++;
            break;
        case 2:
            cand2++;
            total++; 
            break;
        case 3:
            cand3++;
            total++;
            break;
        case 4:
            nulo++;
            total++;
            break;
        case 5:
            branco++;
            total++; 
            break;
        case 6:
            Console.WriteLine("Você optou por sair do sistema de opção");
            break;
        default:
            Console.WriteLine("Você optou por sair do sistema de votacão");
            break;
    }
} while (voto != 6);
pnulo = (float) nulo / total;
pbranco = (float)(branco * 100) / total;
Console.WriteLine("O candidato Candidato Asteiróide teve " + cand1 + " votos");
Console.WriteLine("O candidato Candidato Céu Azul teve " + cand2 + " votos");
Console.WriteLine("O candidato Candidato Marciano Verdinho " + cand3 + " votos");
Console.WriteLine("A porcentagem de votos em branco foi " + pbranco + ".");
Console.WriteLine("A porcentagem de votos nulos foi " + pnulo + ".");
