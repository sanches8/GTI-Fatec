string pNome, sNome;
//Cria o objeto "alu" que é a instancia da classe "Aluno"

Console.WriteLine("Insira o primeiro nome do aluno: ");
pNome = Console.ReadLine();
Console.WriteLine("Insira o segundo nome do aluno: ");
sNome = Console.ReadLine();

//Usa o new para instanciar ma classe, criando uma variavel de referencia daquela classe que é  chamada de obejto da clase.
Aluno alu = new Aluno(pNome + " " + sNome);

Console.WriteLine("O nome do aluno é: " + alu.getNome());
//Seta o nome do aluno ao obejto (p.Nome é passado aqui)
alu.setNome(pNome);
Console.WriteLine("O primeiro nome do aluno é: " + alu.getNome());
