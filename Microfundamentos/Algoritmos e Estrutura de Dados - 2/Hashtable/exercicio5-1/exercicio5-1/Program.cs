//4 - Faça o método public void VaiProFundo(Stack origem, Object elemento)
//que empilha o elemento passado como parâmetro no fundo da Stack, ao invés de no topo.

using System.Collections;
class Program
{
	static void Main(string[] args)
	{
		int qtdElementos = 5;
		Stack origem = new Stack();
		for (int i = 0; i < qtdElementos; i++)
		{
			origem.Push(i + 1);
		}

		Console.WriteLine();
		Mostrar(origem);


		Object elemento = 10;
		
		for (int i = 0; i < 10; i++)
		{
			VaiProFundo(origem, i);
		}

		while (origem.Count > 0)
		{
			Console.WriteLine(origem.Pop());
		}


	}

	public static void VaiProFundo(Stack origem, Object elemento)
	{
		Stack passaElemento = new Stack(origem.Count);
		int qtd = origem.Count;
		
		// transferindo dados da pilha original para a pilha auxiliar
		for (int i = 0; i < qtd; i++)
		{
			passaElemento.Push(origem.Pop());
		}

		//Adicionando o elemento na pilha original vazia
				origem.Push(elemento);
		
		// voltando com os dados da pilha auxiliar para a pilha original
		for (int i = 0; i < qtd; i++)
		{
			origem.Push(passaElemento.Pop());
		}
	}

	static void Mostrar(IEnumerable colecoes)
	{
		Console.WriteLine();
		foreach (var item in colecoes)
		{
			Console.WriteLine($"{item}");
		}
	}
}