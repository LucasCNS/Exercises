//Faça um programa que leia a nota e o nome de N alunos
//e mostrar na tela o nome daqueles que ficaram acima da média do grupo,
//sendo N um número inteiro lido do teclado.
class Aluno
{
	private string _Nome;
	public string? Nome
	{
		get { return _Nome; }
		set { _Nome = value; }
	}

	private int _Nota;
	public int? Nota
	{
		get { return _Nota; }
		set { _Nota = (int)value; }
	}
}
class Program
{
	static void Main(string[] args)
	{
		CadastraAlunos();
	}

	public static void CadastraAlunos()
	{
		Console.WriteLine("Quantos alunos são?");
		int NumAlunos = int.Parse(Console.ReadLine());
		Console.WriteLine();

		Aluno[] xAlunos = new Aluno[NumAlunos];

		for (int i = 0; i < xAlunos.Length; i++)
		{
			Aluno aluno = new Aluno();

			Console.Write("Nome do Aluno: ");
			aluno.Nome = Console.ReadLine();

			Console.Write("Nota.........: ");
			aluno.Nota = int.Parse(Console.ReadLine());

			xAlunos[i] = aluno;
			Console.WriteLine();
		}

		MostraAlunos(xAlunos);

		bool Passou;
		Passou = AlunosAprovados(xAlunos);

		Console.ReadKey();
	}
	static void MostraAlunos(Aluno[] A) //Método
	{
		Console.Clear();
		Console.WriteLine("Essa é a lista de alunos que foram cadastrados.");

		foreach (Aluno a in A)
		{
			Console.WriteLine($"\nNome do Aluno(a): {a.Nome} \nNota............: {a.Nota}");
		}
		Console.ReadKey();
	}

	static bool AlunosAprovados(Aluno[] A)
	{
		Console.Clear();
		Console.WriteLine("Essa é a lista dos alunos que estão na média, ou acima da média:\n░░░░░░░░░░░░░░░░░░░░░░█████████░░░░░░░░░\r\n░░███████░░░░░░░░░░███▒▒▒▒▒▒▒▒███░░░░░░░\r\n░░█▒▒▒▒▒▒█░░░░░░░███▒▒▒▒▒▒▒▒▒▒▒▒▒███░░░░\r\n░░░█▒▒▒▒▒▒█░░░░██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░\r\n░░░░█▒▒▒▒▒█░░░██▒▒▒▒▒██▒▒▒▒▒▒██▒▒▒▒▒███░\r\n░░░░░█▒▒▒█░░░█▒▒▒▒▒▒████▒▒▒▒████▒▒▒▒▒▒██\r\n░░░█████████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██\r\n░░░█▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒██\r\n░██▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒██▒▒▒▒▒▒▒▒▒▒██▒▒▒▒██\r\n██▒▒▒███████████▒▒▒▒▒██▒▒▒▒▒▒▒▒██▒▒▒▒▒██\r\n█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒████████▒▒▒▒▒▒▒██\r\n██▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░\r\n░█▒▒▒███████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░░\r\n░██▒▒▒▒▒▒▒▒▒▒████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█░░░░░\r\n░░████████████░░░█████████████████░░░░░░");

		bool Passou = false;

		foreach (Aluno a in A)
		{
			if (a.Nota >= 7)
			{
				Console.WriteLine($"\nNome do Aluno(a): {a.Nome} \nNota............: {a.Nota}");
				Passou = true;
			}
		}
		return Passou;
	}

}
