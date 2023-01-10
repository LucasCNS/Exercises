//Desafio: Cadastrar objetos em um vetor usando uma classe.
class Program
{
	static void Main(string[] args)
	{
		Pessoa[] xPessoa = new Pessoa[2];

		for (int i = 0; i < xPessoa.Length; i++)
		{
			Pessoa pessoa = new Pessoa();

			Console.WriteLine("Nome da pessoa: ");
			pessoa.Nome = Console.ReadLine();

			Console.WriteLine("Idade da pessoa: ");
			pessoa.Idade = Console.ReadLine();

			Console.WriteLine("CPF da pessoa: ");
			pessoa.CPF = Console.ReadLine();

			pessoa.dataNascimento = new Data();

			Console.WriteLine("Data de Nascimento - Dia: ");
			pessoa.dataNascimento.Dia = Console.ReadLine();

			Console.WriteLine("Data de Nascimento - Mês: ");
			pessoa.dataNascimento.Mes = Console.ReadLine();

			Console.WriteLine("Data de Nascimento - Ano: ");
			pessoa.dataNascimento.Ano = Console.ReadLine();

			xPessoa[i] = pessoa;

		}
		ListarPessoas(xPessoa);
	}
	static void ListarPessoas(Pessoa[] P)
	{
		Console.Clear();
		Console.WriteLine("Essa é a lista de pessoas que você cadastrou.");
		foreach (Pessoa x in P)
		{
			Console.WriteLine($"\n{x.Nome} - (CPF: {x.CPF})");
			Console.WriteLine($"Data de Nascimento:{x.dataNascimento.Dia}{x.dataNascimento.Mes}{x.dataNascimento.Ano}");
		}
		Console.ReadKey();
	}
}
class Pessoa
{
	public string? Nome;
	public string? Idade;
	public string? CPF;
	//public string? dataNascimento;
	public Data? dataNascimento;
}
class Data
{
	public string? Dia;
	public string? Mes;
	public string? Ano;
}