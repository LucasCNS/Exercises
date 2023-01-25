// 6 - Faça o método public void InverteQueue<T> (Queue<T> q) que inverte a ordem dos elementos da Queue<T> q, no próprio Queue.
// Fique à vontade para utilizar outras estruturas que julgar necessárias. Nesse exercício, você não deve utilizar o método Reverse.

using System.Collections;

class Program
{
	static void Main(string[] args)
	{
		Queue<int> q = new Queue<int>();

		for (int i = 0; i < 5; i++)
		{
			q.Enqueue(i);
		}

		Console.WriteLine("Queue original:\n");
		Mostrar(q);

		Console.WriteLine("\nQueue original invertida:\n");
		InverteQueue(q);
	}

	public static void InverteQueue<T>(Queue<T> q)
	{
		Stack<T> qAux = new Stack<T>();
		
		
		for (int i = q.Count - 1; i >= 0; i--)
		{
			qAux.Push(q.Dequeue());
		}

		q.Clear();

		for (int i = qAux.Count - 1; i >= 0; i--)
		{
			q.Enqueue(qAux.Pop());
		}

		Mostrar(q);

	}

	static void Mostrar (ICollection objeto)
	{
		foreach (var item in objeto)
		{
			Console.WriteLine(item);
		}
	}

}