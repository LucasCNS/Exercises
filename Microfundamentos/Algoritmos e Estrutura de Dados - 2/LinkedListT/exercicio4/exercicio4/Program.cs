//4 - Faça o método public Stack<T> CopiaStack<T>(Stack<T> origem)
//que retorna uma cópia da Stack<T> origem passada como parâmetro.
//Os elementos da Stack origem devem permanecer na mesma ordem original.

using System.Collections;
class Program
{
	static void Main(string[] args)
	{
		Stack<int> origem = new Stack<int>();
		for (int i = 0; i < 7; i++)
		{
			origem.Push(i + 1);
		}

		Console.WriteLine("Stack origem:\n");
		Mostrar(origem);

		Console.WriteLine("\nCopia da Stack origem:\n");
		CopiaStack(origem);
	}

	public static Stack<T> CopiaStack<T>(Stack<T> origem)
	{
		Stack<T> copiaStack = new Stack<T>(origem);
		Mostrar(copiaStack);
		return copiaStack;
	}

	static void Mostrar(IEnumerable objects)
	{
		foreach (var item in objects)
		{
			Console.WriteLine(item);
		}
	}
}