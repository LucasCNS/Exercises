//Faça um programa que defina de forma completa uma classe de nome “Veículo”
//com os atributos “Nome”, “Marca”, “Ano de Fabricação” e “Placa”.
//Crie métodos capazes de ler os dados de um veículo e mostrar uma listagem de todos os veículos.

//Passo a passo:
// 1 - Criar class Veiculo.
// 2 - Criar atributos Nome,AnoFabricacao e Placa
// 3 - Criar método para ler os dados.
// 4 - Criar método para listar os dados.
// OBS - Cadastre em um vetor de 30.

// BONUS - Criar método para encontrar veículo da lista pelo nome.


//Passo 1
using System.Security.Cryptography.X509Certificates;

class Veiculo 
{
	//Passo 2
	private string? _Nome; //Campo da classe = Atributo

	public string? Nome //Encapsulamento = Propriedade
	{
		get { return _Nome; }
		set { _Nome = value; }
	}

	private string? _AnoFabricacao;

	public string? AnoFabricacao
	{
		get { return _AnoFabricacao; }
		set { _AnoFabricacao = value; }
	}

	private string? _Placa;

	public string? Placa
	{
		get { return _Placa; }
		set { _Placa = value; }
	}
}

class Program
{
	static void Main(string[] args)
	{
		CadastraVeiculos();
	}

	//Passo 3
	static void CadastraVeiculos()
	{
		Veiculo[] xVeiculos = new Veiculo[2];

		for (int i = 0; i < xVeiculos.Length; i++)
		{
			Veiculo veiculo = new Veiculo();

			Console.Write("Nome do Veículo: ");
			veiculo.Nome = Console.ReadLine();

			Console.Write("Qual o ano de fabricação? ");
			veiculo.AnoFabricacao = Console.ReadLine();

			Console.Write("Digite a placa do veículo: ");
			veiculo.Placa = Console.ReadLine();
			Console.WriteLine();

			xVeiculos[i] = veiculo;
		}

		MostraVeiculos(xVeiculos);

		string Nome;
		bool Achou;

		Console.WriteLine("\nDigite o Nome de um Veículo:");

		Nome = Console.ReadLine();

		Achou = ProcuraNaLista(xVeiculos, Nome);

		if (!Achou)
		{
			Console.WriteLine("Este Veículo não existe no cadastro.");
		}
		Console.ReadKey();
	}

	//Passo 4
	static void MostraVeiculos(Veiculo[] L) //Método
	{
		Console.Clear();
		Console.WriteLine("Essa é a lista de veículos que foram cadastrados.");
		
		foreach (Veiculo l in L)
		{
			Console.WriteLine($"\n{l.Nome} - {l.AnoFabricacao}");
			Console.WriteLine($"Placa do veículo: {l.Placa}");
		}
		Console.ReadKey();
	}

	//Passo BONUS
	static bool ProcuraNaLista(Veiculo[] V, string Nome)
	{
		Console.Clear();
		bool Achou = false;

		foreach (Veiculo v in V)
		{
			if (v.Nome == Nome)
			{
				Console.WriteLine($"\n{v.Nome} - Ano de Fabricação: {v.AnoFabricacao}");
				Console.WriteLine($"Placa: {v.Placa}");

				Achou = true;
			}
		}
		return Achou;
	}
}
