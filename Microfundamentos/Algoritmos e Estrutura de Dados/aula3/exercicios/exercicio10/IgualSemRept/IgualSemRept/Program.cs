using System.Collections;

//10 - Faça o método public ArrayList Intersecao(ArrayList al1, ArrayList al2) que recebe dois ArrayLists
//e retorna outro contendo os elementos em comum armazenados em al1 e al2, sem repetição.

class Program
{
	static void Main(string[] args)
	{
		int qntdAl1 = 6;
		int qntdAl2 = 10;

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

		Mostra(Intersecao(al1, al2));

		Console.ReadKey();
	}
	

	public static ArrayList Intersecao(ArrayList al1, ArrayList al2)
	{
		ArrayList iguais = new ArrayList();
		int condicao = 0;
		Console.Write("\nDeseja usar o método '1-ForEach', '2-For' ou '3-Sair'? ");
		condicao=int.Parse(Console.ReadLine());
		
		if (condicao == 1)
		{
			Console.WriteLine("\nArrayList Intersecao - ForEach\n");
			IntersecaoForEach(al1, al2);

		} else if (condicao == 2)
		{
			Console.WriteLine("\nArrayList Intersecao - For\n");
			IntersecaoFor(al1, al2);

		} else if(condicao == 3)
		{
			Console.WriteLine("Você escolheu sair.");
			Console.ReadKey();
		}
		else if (condicao < 1 || condicao > 3)
		{
			Console.WriteLine("Valor inserido inválido!");
		}

		return al1;
	}

	static void IntersecaoForEach(ArrayList al1, ArrayList al2)
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
	}

	static void IntersecaoFor(ArrayList al1, ArrayList al2)
	{
		ArrayList iguais = new ArrayList();
		for (int i = 0; i < al2.Count; i++)
		{
			if (al1.Contains(al2[i]))
			{
				iguais.Add(al2[i]);
			}
		}
		al1.Clear();
		al1.AddRange(iguais);
	}

	static void Mostra(ArrayList arraylist)
	{
		foreach (var item in arraylist)
		{
			Console.WriteLine($"{item}");
		}
	}
}