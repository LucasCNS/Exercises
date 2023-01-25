using System.Collections;

//1 - Faça o método public ArrayList CopiarQueueParaArrayList(Queue origem)
//que copia todos os elementos do Queue origem e retorna um novo ArrayList.
//Neste exercício não é permitido o uso dos métodos Clone() nem CopyTo().

class Program
{
	static void Main(string[] args)
	{
		Queue origem = new Queue();

		for (int i = 0; i < 5; i++)
		{
			origem.Enqueue(i + 1);
		}
		Console.WriteLine("Queue:");
		Mostrar(origem);

		Console.WriteLine("ArrayList:");
		Mostrar(CopiarQueueParaArrayList(origem));	
	}

	static ArrayList CopiarQueueParaArrayList(Queue origem)
	{
		ArrayList list = new ArrayList();

		foreach (var item in origem)
		{
			list.Add(item);
		}
		return list;
	}

	static void Mostrar(IEnumerable origem)
	{
		Console.WriteLine();
		foreach (var item in origem)
		{
			Console.WriteLine($"{item}");
		}
	}

	
}
