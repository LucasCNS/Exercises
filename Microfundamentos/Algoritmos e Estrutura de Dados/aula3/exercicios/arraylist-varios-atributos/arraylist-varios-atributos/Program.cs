using System.Collections;

class Aluno
{
	public string Nome { get; set; }
	public double Nota { get; set; }

	//private string _Nome;

	//public string Nome
	//{
	//	get { return _Nome.ToUpper(); }
	//	set { _Nome = value; }
	//}

	public Aluno()
	{
		Nome = "";
		Nota = 0;
	}

	public Aluno(string nome, double nota)
	{
		Nome = nome;
		Nota = nota;
	}
}

class Program
{
	public static void Main(string[] args)
	{
		string nome = null;
		double nota = 0;

		ArrayList aluno = new ArrayList();

		Console.WriteLine($"Capacidade: {aluno.Capacity}");
		Console.WriteLine();

		Console.WriteLine("Digite o nome do aluno.");
		nome = Console.ReadLine();

		Console.WriteLine("Digite a nota do aluno.");
		nota = double.Parse(Console.ReadLine());

		aluno.Add(new Aluno(nome, nota));

		mostrarAlunos(aluno);
		Console.WriteLine($"\nCapacidade: {aluno.Capacity}");

		Console.ReadKey();
	}
	static void mostrarAlunos(ArrayList AL)
	{
		foreach (Aluno a in AL)
		{
			Console.Write($"Aluno:{a.Nome}. Nota: {a.Nota}");
		}
	}
}