//3 - Faça o método public Stack CopiarStack(Stack origem) que retorna uma cópia da Stack origem passada como parâmetro.
//Os elementos da Stack origem devem permanecer na mesma ordem original.
//Neste exercício não é permitido o uso dos métodos Clone() e CopyTo() da classe Stack.

using System.Collections;
class Program
{
	static void Main(string[] args)
	{
		Stack origem = new Stack();
		int qtdElementos = 5;

		for (int i = 0; i < qtdElementos; i++)
		{
			origem.Push(i + 1);
		}
		Console.WriteLine("Stack origem");
		Mostrar(origem);

		Console.WriteLine("Stack copia da origem");
		Mostrar(CopiarStack(origem));
	}

	public static Stack CopiarStack(Stack origem)
	{
		Stack copiarStack = new Stack(origem);
		return copiarStack;
	}

	static void Mostrar(IEnumerable colecao)
	{
		Console.WriteLine();
		foreach (var item in colecao)
		{
			Console.WriteLine($"{item}");
		}
		Console.WriteLine();
	}
}