//Desenvolva uma classe que, por meio de métodos, realize as seguintes operações dentro de um vetor de números inteiros:

// OK OBJETIVO 1 - Criação de um vetor de dimensões fornecidas pelo usuário segundo um método construtor. Se não for fornecido pelo usuário o tamanho deverá ser, por padrão, 10;
// OK OBJETIVO 2 - Criação de um vetor de dimensões fornecidas pelo usuário e inserção automática de valores aleatórios nesse vetor, segundo um método construtor, fornecidos os limites mínimo e máximo; Se não fornecido o tamanho do vetor pelo usuário o tamanho deverá ser 10;
// OBJETIVO 3 - Listagem de todos os elementos do vetor;
// OBJETIVO 4 - Inserção de um valor em uma dada posição do vetor;
// OBJETIVO 5 - Recuperação de um valor indicado por uma posição fornecida pelo usuário;
// OBJETIVO 6 - Localização do Maior e do Menor número dentro do vetor.
// Teste as rotinas no programa principal(main).

class Vetor                       //Criação da Classe
{
	private int [] ID;            //Criação dos Atributos 'ID' sendo um Vetor.
	private int TamanhoVetorID;

	public Vetor()						
	{
		TamanhoVetorID = 10;            //Construtor com 'TamanhoVetorID' sendo 10.
		ID = new int[TamanhoVetorID];
	}

	//OBJETIVO 1
	public Vetor(int TamVetUser)    		
	{
		TamanhoVetorID = TamVetUser;    //Construtor com 'TamanhoVetorID' dado pelo usuário.
		ID = new int[TamanhoVetorID];
	}

	// OBJETIVO 2
	public Vetor(int p1, int p2)	//Construtor com dois parâmetros.
	{
		TamanhoVetorID = 10;			//Vetor com 10 posições.
		ID = new int[TamanhoVetorID];	//Vetor aleatório.
		Random random = new Random();   //Deixa o valor randômico.

		for(int i = 0; i < 10; i++)
		{
			ID[i] = random.Next(p1, p2 + 1);
		}
	}

	// OBJETIVO 2
	public Vetor(int TamVetUser, int p1, int p2) //Construtor com três parâmetros.
	{
		TamanhoVetorID = TamVetUser;
		ID = new int[TamanhoVetorID];
		Random random = new Random();

		for (int i = 0; i < TamanhoVetorID; i++)
		{
			ID[i] = random.Next(p1, p2 + 1);
		}
	}

	//Métodos
	public void Inserir (int Pos, int Valor)
	{
		ID[Pos] = Valor;
	}

	public int Recupera(int Pos)
	{
		return ID[Pos];
	}

	public int AchaMaior()
	{
		int Maior = ID[0];

		for (int i = 1; i < TamanhoVetorID; i++)
		{
			if (ID[i] > Maior)
				Maior = ID[i];
		}

		return Maior;
	}

	public int AchaMenor()
	{
		int Menor = ID[0];
		
		for(int i = 1; i < TamanhoVetorID; i++)
		{
			if (ID[i] > Menor)
				Menor = ID[i];
		}
		return Menor;
	}

	public void ListarVetores()
	{
		Console.WriteLine();

		foreach (int x in ID)
		{
			Console.Write($"{x,5}");
		}

		Console.WriteLine();
		Console.ReadKey();
	}
}

class Program
{
	static void Main(string[] args)
	{
		Vetor xVet1 = new Vetor();

		xVet1.ListarVetores();

		xVet1.Inserir(0, 92);
		xVet1.Inserir(2, 45);
		xVet1.Inserir(3, 21);
		xVet1.Inserir(7, 89);

		xVet1.ListarVetores();

		Vetor xVet2 = new Vetor(5);

		xVet2.Inserir(0, 76);
		xVet2.Inserir(2, 12);
		xVet2.Inserir(3, 65);

		xVet2.ListarVetores();

		Vetor xVet3 = new Vetor(8, 1, 50);

		xVet3.ListarVetores();

		Console.WriteLine($"\n   O Elemento da Posição 3 do Vetor é {xVet3.Recupera(3)}");

		Console.ReadKey();
	}
}