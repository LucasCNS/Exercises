//2 - Faça o método public void ApagaQueue(Queue<int> origem, int início, int final)
//que apaga todos os elementos no intervalo determinado pelos parâmetros início e final.
//Por exemplo, ApagaQueue(q, 7, 10) => apaga os elementos entre as posições 7 e 10.

using System.Collections;

class Program
{
	static void Main(string[] args)
	{
		int qtdElementos = 10;
		int inicio = 0;
		int final = 0;

		Queue<int> origem = new Queue<int>();
		
		for (int i = 0; i < qtdElementos; i++)
		{
			origem.Enqueue(i + 1);
		}
		Console.WriteLine("Queue:\n");
		Mostrar(origem);

		Console.Write("\nDigite o valor inicial do 'delete': ");
		inicio = int.Parse(Console.ReadLine());
		Console.Write("\nDigite o valor final do 'delete': ");
		final = int.Parse(Console.ReadLine());

		ApagaQueue(origem, inicio,final);
		Mostrar(origem);
	}

	public static void ApagaQueue(Queue<int> origem, int inicio, int final)
	{
		for (int i = inicio; i < final; i++)
		{
			origem.Dequeue();
		}
	}

	static void Mostrar (IEnumerable lista)
	{
		foreach (var item in lista)
		{
			Console.WriteLine(item);
		}
	}
}