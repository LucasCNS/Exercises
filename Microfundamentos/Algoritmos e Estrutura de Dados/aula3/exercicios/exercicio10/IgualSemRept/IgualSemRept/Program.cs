using System.Collections;
using System.Globalization;

//10 - Faça o método public ArrayList Intersecao(ArrayList al1, ArrayList al2) que recebe dois ArrayLists
//e retorna outro contendo os elementos em comum armazenados em al1 e al2, sem repetição.

class Program
{
	static void Main(string[] args)
	{
		int qntdAl1 = 10;
		int qntdAl2 = 20;

		ArrayList al1 = new ArrayList();
		for (int i = 0; i < qntdAl1; i++)
		{
			al1.Add($"Item {i}");
		}

		Console.WriteLine("ArrayList 1\n");
		Mostra(al1);

		ArrayList al2 = new ArrayList();
		for (int i = 0; i < qntdAl2; i++)
		{
			int j = i + 1;
			al2.Add($"Item {j+j}");
		}

		Console.WriteLine("\nArrayList 2\n");
		Mostra(al2);

		Console.WriteLine("\nArrayList Intersecao\n");
		Mostra(Intersecao(al1, al2));

		Console.ReadKey();
	}

	public static ArrayList Intersecao(ArrayList al1, ArrayList al2)
	{
		ArrayList iguais = new ArrayList();
		
		foreach (var elemento in al2)
		{
			if (al1.Contains(elemento))
			{
				iguais.Add(elemento);
			}
		}

		al1.Clear();
		al1.AddRange(iguais);
		return al1;
	}

	static void Mostra(ArrayList arraylist)
	{
		foreach (var item in arraylist)
		{
			Console.WriteLine($"{item}");
		}
	}
}