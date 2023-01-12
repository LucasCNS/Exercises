using System.Collections;

//6 - Faça o método public void ApagarArrayList(ArrayList origem, int início, int final)
//que apaga todos os elementos no intervalo determinado pelos parâmetros início e final.
//Neste exercício não é permitido o uso do método RemoveRange();
//use somente os métodos Remove() e RemoveAt().
//Por exemplo, a chamada ApagarArrayList(al, 7, 10) apaga os elementos entre as posições 7 e 10.

//Mais duas maneiras de fazer:

//Formula 2

//ArrayList copia = new ArrayList();
//copia.AddRange(origem);

//Forumla 3

//ArrayList copia = new ArrayList();
//foreach (var itemOrigem in origem)
//{
//	copia.Add(itemOrigem)
//}
class Program
{
	static void Main(string[] args)
	{
		int inicio = 0;
		int final = 0;
		int qntElementos = 5;
		ArrayList origem = new ArrayList();

		for (int i = 0; i < qntElementos; i++)
		{
			origem.Add($"Item {i + 1} - A posição do item é: {i}.");
		}

		Console.WriteLine("ArrayList ORIGEM");
		Mostra(origem);

		ApagarArrayList(origem, inicio, final);
	}

	static ArrayList ApagarArrayList(ArrayList origem, int inicio, int final)
	{
		Console.WriteLine();
		Console.WriteLine("Quais itens deseja apagar?");
		Console.WriteLine();
		Console.WriteLine("Digite o número que inicia o intervalo dos que você quer apagar:");
		inicio = int.Parse(Console.ReadLine());
		inicio = inicio - 1;

		Console.WriteLine("Digite o número que finaliza o intervalo dos que você quer:");
		final = int.Parse(Console.ReadLine());
		final = final - 1;

		ArrayList copia = new ArrayList();
		Console.WriteLine("\nArrayList COPIA");

		copia.AddRange(origem);

		for (int i = inicio; i <= final; i++)
		{
			copia.Remove(origem[i]);
		}
		Mostra(copia);
		return copia;
	}

	static void Mostra(ArrayList arraylist)
	{
		Console.WriteLine();

		foreach (var a in arraylist)
		{
			Console.WriteLine($"{a}");
		}
		Console.ReadKey();
	}
}