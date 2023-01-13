//8 - Faça o método public ArrayList ConcatenaArrayList(ArrayList al1, ArrayList al2)
//que recebe dois objetos ArrayList al1 e al2 e retorna outro ArrayList concatenando todos os elementos de al1 e al2.
//Por exemplo, se os valores dos dois ArrayLists passados por parâmetro forem [19, 33, 2, 4] e[1, 2, 3, 4, 5], o ArrayList retornado será [19, 33, 2, 4, 1, 2, 3, 4, 5]. 
using System.Collections;

class Program
{
	static void Main(string[] args)
	{
		int qtdElementosAl1 = 2;
		int qtdElementosAl2 = 3;
		int condicao = 0;

		ArrayList al1 = new ArrayList();
		Console.WriteLine("ArrayList 1\n");

		for (int i = 0; i < qtdElementosAl1; i++)
		{
			al1.Add($"Item {i}");
		}

		Mostra(al1);
		Console.ReadKey();

		ArrayList al2 = new ArrayList();
		Console.WriteLine("\nArrayList 2\n");

		for (int i = 0; i < qtdElementosAl2; i++)
		{
			al2.Add($"Item {al1.Count + i}");
		}

		Mostra(al2);
		Console.ReadKey();

		Console.WriteLine("\nEscolha qual método usar:\n\n1 - Usar FOR\n2 - Usar FOREACH");
		condicao = int.Parse(Console.ReadLine());
		Console.WriteLine("\nArrayLists concatenados:");
		Condicao(condicao, al1, al2);

		Console.ReadKey();
	}

	public static ArrayList ConcatenaArrayListFor(ArrayList al1, ArrayList al2)
	{
		Console.WriteLine("\n===Usando FOR===\n");
		for (int i = 0; i < al2.Count; i++)
		{
			al1.Add(al2[i]);
		}
		Mostra(al1);
		return al1;
	}

	public static ArrayList ConcatenaArrayListForEach(ArrayList al1, ArrayList al2)
	{
		Console.WriteLine("\n===Usando FOREACH===\n");
		foreach (var item in al2)
		{
			al1.Add(item);
		}
		Mostra(al1);
		return al1;
	}

	static void Condicao(int condicao, ArrayList al1, ArrayList al2)
	{
		if (condicao == 1)
		{
			ConcatenaArrayListFor(al1, al2);
		} else if (condicao == 2)
		{
			ConcatenaArrayListForEach(al1, al2);
		} else if (condicao != 1 || condicao != 2)
		{
			Console.WriteLine("Dado inválido.");
		}
	}

	static void Mostra(ArrayList arraylist)
	{
		foreach(var item in arraylist)
		{
			Console.WriteLine($"{item}");
		}
	}
}