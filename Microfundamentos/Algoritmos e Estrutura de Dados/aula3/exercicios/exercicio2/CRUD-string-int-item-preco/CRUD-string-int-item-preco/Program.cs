//1 - A maioria dos sistemas computacionais que você terá a oportunidade de desenvolver ou trabalhar em sua vida profissional terá um cadastro de elementos.
//Em outras palavras, uma lista contendo as operações de inserir, ler, atualizar e apagar elementos.
//Na área de programação de computadores, esse minicadastro é chamado de CRUD,
//sigla em inglês para as palavras Create, Read, Update e Delete. Traduzindo, temos: criar, ler, atualizar e apagar, respectivamente.
//Neste exercício, faça um programa contendo um ArrayList que armazena números inteiros e mostra as seguintes opções de escolha para o usuário:
//1 - inserir elemento;
//2 - remover elemento;
//3 - listar elementos;
//4 - pesquisar elemento;
//5 - ordenar elementos; e
//6 - sair.Quando o usuário escolher uma das opções,
//o programa realiza a operação escolhida no ArrayList.

using System.Collections;
class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Bem vindo à Loja de Móveis!\n");
		ArrayList moveis = new ArrayList();
		
		moveis.Add("Cadeira Gamer");

		Mostrar(moveis);

		Opcoes(moveis);

		Console.ReadLine();
	}

	static void Mostrar(ArrayList AL)
	{
		Console.WriteLine($"Esses são os itens que estão no seu carrinho de compras: \n");

		foreach (var elemento in AL)
		{
			Console.WriteLine($"{elemento}");
		}

	}

	static void Opcoes(ArrayList carrinho)
	{
		int inserir = 1;
		int remover = 2;
		int listar = 3;
		int pesquisar = 4;
		int ordenar = 5;
		int sair = 6;
		int resposta = 0;

		Console.WriteLine(" \nO que deseja fazer?\n\n1 - Inserir \n2 - Remover\n3 - Listar\n4 - Pesquisar\n5 - Ordenar\n6 - Sair\n");
		resposta = int.Parse(Console.ReadLine());

		if (resposta == inserir)
		{
			Inserir(carrinho);
		}
		else if (resposta == remover)
		{
			Remover(carrinho);
		}
		else if (resposta == listar)
		{
			Listar(carrinho);
		}
		else if (resposta == pesquisar)
		{
			Pesquisar(carrinho);
		}
		else if (resposta == ordenar)
		{
			Ordenar(carrinho);
		}
		else if (resposta == sair)
		{
			Sair(carrinho);
		}
	}

	static void Inserir(ArrayList carrinho)
	{
		string nome = null;
		Console.WriteLine("Você escolheu inserir.");

		Console.Write("Digite o nome do item: ");
		nome = Console.ReadLine();

		carrinho.Add(nome);
		Console.WriteLine($"\nVoce inseriu {nome} ao carrinho.\n");

		Mostrar(carrinho);

		Console.ReadKey();
		Opcoes(carrinho);
	}

	static void Remover(ArrayList carrinho)
	{
		string nome = null;
		Console.WriteLine("Você escolheu remover.");

		Console.Write("Digite o nome do item que deseja remover do carrinho: ");
		Console.WriteLine();

		nome = Console.ReadLine();

		if (carrinho.Contains(nome))
		{
			Console.WriteLine($"\nVoce removeu {nome} ao carrinho.\n");
			carrinho.Remove(nome);
			Opcoes(carrinho);
		}
		else
		{
			Console.WriteLine($"\nO item {nome} não foi encontrado.");
			Opcoes(carrinho);
		}
	}

	static void Listar(ArrayList carrinho)
	{
		Console.WriteLine("Você escolheu listar.");
		if (carrinho.Count == 0)
		{
			Console.WriteLine("Não há itens no carrinho.");
		}
		else
		{
			Mostrar(carrinho);
		}

		Console.ReadKey();
		Opcoes(carrinho);
	}

	static void Pesquisar(ArrayList carrinho)
	{
		string nome = null;
		Console.WriteLine("Você escolheu pesquisar.");

		Console.Write("Digite o nome do item que deseja procurar no carrinho: \n");
		Console.WriteLine();

		nome = Console.ReadLine();
		if (carrinho.Contains(nome) == true)
		{
			Console.WriteLine($"\nO item {nome}, está no seu carrinho.");
			Opcoes(carrinho);
		}
		else
		{
			Console.WriteLine($"\nO item {nome}, não está no seu carrinho.");
			Opcoes(carrinho);
		}
	}

	static void Ordenar(ArrayList carrinho)
	{
		string deseja = null;

		Console.WriteLine("Você escolheu ordenar.");

		carrinho.Sort();

		Console.WriteLine("Deseja ver o carrinho? (S/N)\n");
		deseja = Console.ReadLine();
		if (deseja == "s" || deseja == "S")
		{
			Console.WriteLine();
			Mostrar(carrinho);
		}
		else
		{
			Console.WriteLine("\nTa bom então, né...");
		}
		Opcoes(carrinho);
	}

	static void Sair(ArrayList carrinho)
	{
		Console.WriteLine("Você escolheu sair.\n");

		Console.WriteLine("Até mais! <3");
		Console.ReadKey();
	}
}