//5 - Faça o método public void VaiProFundo<T>(Stack<T> origem, T elemento)
//que empilha o elemento passado como parâmetro no fundo da Stack<T> origem, ao invés de empilhar no topo.

using System.Collections;
class Program
{
	static void Main(string[] args)
	{
		Stack<int> origem = new Stack<int>();
		for (int i = 0; i < 7; i++)
		{
			origem.Push(i);
		}
		Console.WriteLine("Stack origem:\n");
		Mostrar(origem);

		int elemento = 10;

		Console.WriteLine($"\nO valor que será jogado para o fundo da pilha é: {elemento}.\n");
		VaiProFundo(origem, elemento);

	}

	public static void VaiProFundo<T>(Stack<T> origem, T elemento)
	{
		Stack<T> stackAux = new Stack<T>();
		Stack<T> stackAux2 = new Stack<T>();

		for (int i = origem.Count - 1; i >= 0 ; i--)
		{
			stackAux.Push(origem.Pop());
		}

		Console.WriteLine($"\nStack Aux:\n");
		Mostrar(stackAux);

		origem.Push(elemento);

		for (int i = stackAux.Count - 1; i >= 0 ; i--)
		{
			origem.Push(stackAux.Pop());
		}

		Console.WriteLine($"\nStack Origem com elemento:\n");
		Mostrar(origem);

	}


	static void Mostrar(IEnumerable objects)
	{
		foreach (var item in objects)
		{
			Console.WriteLine(item);
		}
	}
}