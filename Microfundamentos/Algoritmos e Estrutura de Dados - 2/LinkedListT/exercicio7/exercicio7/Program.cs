// 7 - Faça o método public void InverteStack<T> (Stack<T>  s)
// que inverte a ordem dos elementos do Stack<T> s, no próprio Stack.
// Nesse exercício, você não deve utilizar o método Reverse.

using System.Collections;

class Program
{
	static void Main(string[] args)
	{
		Stack<int> s = new Stack<int>();

		for (int i = 0; i < 5; i++)
		{
			s.Push(i);
		}

		Console.WriteLine("Stack original:\n");
		Mostrar(s);

		Console.WriteLine("\nStack original invertida:\n");
		InverteStack(s);
	}

	public static void InverteStack<T>(Stack<T> s)
	{
		Queue<T> qAux = new Queue<T>();

		for (int i = s.Count - 1; i >= 0; i--)
		{
			qAux.Enqueue(s.Pop());
		}

		s.Clear();

		for (int i = qAux.Count - 1; i >= 0; i--)
		{
			s.Push(qAux.Dequeue());
		}

		Mostrar(s);
	}

	static void Mostrar(ICollection objeto)
	{
		foreach (var item in objeto)
		{
			Console.WriteLine(item);
		}
	}

}
