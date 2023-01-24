//3 - Faça o método public Queue CopiaQueue(Queue<int> origem)
//que copia todos os dados do Queue<int> origem e retorna o novo Queue (não genérico) criado.

using System.Collections;

class Program
{
	static void Main(string[] args)
	{
		Queue<int> origem = new Queue<int>();
		for (int i = 0; i < 7; i++)
		{
			origem.Enqueue(i);
		}
		Console.WriteLine("Queue origem:\n");
		Mostrar(origem);

		Console.WriteLine("\nQueue origem:\n");
		Mostrar(CopiaQueue(origem));
	}

	public static Queue CopiaQueue(Queue<int> origem)
	{
		Queue copiaQueue = new Queue(origem);
		copiaQueue.Enqueue(8); //Teste se está copiada, colocando outro item e comparando.
		return copiaQueue;
	}

	static void Mostrar(IEnumerable objects)
	{
		foreach (var item in objects)
		{
			Console.WriteLine(item);
		}		
	}
}