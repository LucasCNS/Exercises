//2 - Faça o método public Queue CopiarQueue(Queue origem)
//que retorna uma cópia da Queue origem passada como parâmetro.
//Os elementos da Queue origem devem permanecer na mesma ordem original.
//Neste exercício é permitido o uso dos métodos Clone() e CopyTo() da classe Queue.

using System.Collections;
using System.Reflection.Metadata.Ecma335;

class Program 
{ 
	static void Main(string[] args)
	{
		Queue origem = new Queue();
		
		for (int i = 0; i < 5; i++)
		{
			origem.Enqueue(i + 1);
		}

		Console.WriteLine("Queue origem");
		Mostrar(origem);

		Console.WriteLine("Queue copia da origem");
		Mostrar(CopiarQueue(origem));
	}

	public static Queue CopiarQueue(Queue origem)
	{
		Queue copiaQueue = new Queue(origem);
		return copiaQueue;
	}

	static void Mostrar(IEnumerable colecao)
	{
		foreach (var item in colecao)
		{
			Console.WriteLine($"{item}");
		}
	}
	
}