//13 - Faça o método public ArrayList OcorrenciasDe(ArrayList al, Object elemento) que recebe um ArrayList al e um Object elemento
//e retorna outro ArrayList contendo todas as posições em que o elemento aparece em al.

using System.Collections;

class Program
{
	static void Main(string[] args)
	{
		ArrayList al = new ArrayList();
		
		al.Add(1);
		al.Add(2);
		al.Add(1);
		al.Add(2);
		al.Add(1);
		al.Add(3);
		al.Add(3);
		al.Add(3);

		Console.WriteLine("ArrayList\n");
		Mostra(al);

	
		Object elemento = 2;
		Console.WriteLine();

		//Console.WriteLine($"Posições em que o item {elemento} se encontra.");
		Mostra(OcorrenciasDe(al, elemento));
	}

	public static ArrayList OcorrenciasDe(ArrayList al, Object elemento)
	{
		ArrayList posicao = new ArrayList();

		int i = 0;
		foreach (var item in al)
		{
			if (item.Equals(elemento))
			{
				posicao.Add(i);
			}
			i++;
		}

		//for (int i = 0; i < al.Count; i++)
		//{
		//	if (al[i].Equals(elemento))
		//	{
		//		posicao.Add(i);
		//	}
		//}
		return posicao;
	}

	static void Mostra(ArrayList arraylist)
	{
		foreach (var item in arraylist)
		{
			Console.WriteLine($"{item}");
		}
	}
}