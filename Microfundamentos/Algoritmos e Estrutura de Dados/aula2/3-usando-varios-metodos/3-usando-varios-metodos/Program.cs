//Use os métodos:
// OK 1:  Add - Insere um objeto e retorna sua posição.
// OK 2:  Insert - Insere um objeto na posição especificada. Ocorre uma exceção se a posição não existir.
// OK 3:  Remove - remove a primeira ocorrência no objeto especificado.
// OK 4:  RemoveAt - remove um objeto no índice especificado.
// OK 5:  RemoveRange - Remove uma determinada quantidade de elementos à partir do índice espeficiado.
// OK 6:  Clear - Remove todos os elementos sem alterar a capacidade.
// OK 7:  Contains - Retorna se a estrutura contém um objeto.
// OK ? 8:  IndexOf - Retorna o índice da primeira ocorrência de um dado objeto.
// OK ? 9:  LastIndexOf - Retorna o índice da última ocorrência de um dado objeto.
// OK 10: Reverse - Inverte a ordem dos elementos.
// OK 11: Sort - Ordena os objetos.
// OK 12: ToArray - Copia os objetos para um array.
// OK 13: TrimToSize - Altera a Capacity para a quantidade de elementos.
// OK 14: BinarySearch - Realiza uma busca binária e retorna a posição do elemento ou número negativo se não for encontrado.


using System.Collections;

class Program
{
	public static void Main(string[] args)
	{
		ArrayList al = new ArrayList();
		// Add
		al.Add("Elemento 1");
		al.Add("Elemento 2");
		al.Add("Elemento 3");
		al.Add("Elemento 4");
		al.Add("Elemento 5");
		al.Add("Elemento 6");
		al.Add("Elemento 7");
		al.Add("Elemento 8");
		al.Add("Elemento 9");
		al.Add("Elemento 10");
		Console.WriteLine($"Usando o método 'Add', os elementos foram adicionados.\n");
		MostrarElementos(al);
		
		//Insert
		al.Insert(0, "Elemento Insert");
		Console.WriteLine($"\nUsando o método 'Insert', o elemento foi inserido na posição [0] do ArrayList.\n");
		MostrarElementos(al);
		
		//Remove
		al.Remove("Elemento Insert");
		Console.WriteLine($"\nUsando o método 'Remove', o 'Elemento Insert' foi removido.\n");
		MostrarElementos(al);
		
		//RemoveAt
		al.RemoveAt(4);
		Console.WriteLine($"\nUsando o método 'RemoveAt', o 'Elemento 5' da posição [4] foi removido.\n");
		MostrarElementos(al);

		//RemoveRange
		al.RemoveRange(6,3);
		Console.WriteLine($"\nUsando o método 'RemoveRange', os elementos 'Elemento 8,9 e 10', da posição [6,7,8] foram removidos.\n");
		MostrarElementos(al);

		//Contains
		if(al.Contains("Elemento 1") == true)
		{
			Console.Write("\nUsando o método 'Contains', o 'Elemento 1', foi encontrado.\n");
		};

		//Reverse
		al.Reverse();
		Console.Write("\nUsando o método 'Reverse', a ordem dos elementos foi invertida.\n\n");
		MostrarElementos(al);

		//IndexOf e LastIndexOf
		int primeiraPosElem = al.IndexOf("Elemento 3");
		int ultimaPosElem = al.LastIndexOf("Elemento 3");

		Console.Write("\nUsando o método 'IndexOf' e LastIndexOf, sabemos a primeira e última posição do 'Elemento 3'.\n\n");
		Console.WriteLine($"A primeira posição do 'Elemento 3' foi: {primeiraPosElem}");
		Console.WriteLine($"A última posição do 'Elemento 3' é: {ultimaPosElem}");

		//Sort
		al.Sort();
		Console.Write("\nUsando o método 'Sort', a ordem dos elementos foi estabelecida.\n\n");
		MostrarElementos(al);

		//ToArray
		Object[] outroVetor = al.ToArray();
		Console.Write("\nUsando o método 'ToArray', o ArrayList foi convertido à um Array.\n\n");

		//TrimToSize
		Console.Write($"Usando o método 'Capacity', vemos que a capacidade atual do Array é de: {al.Capacity} elementos.\n");
		al.TrimToSize();
		Console.Write("\nUsando o método 'TrimToSize', a capacidade de elementos foi alterada para a quantidade de elementos.\n\n");
		Console.Write($"A capacidade atual do Array é de: {al.Capacity} elementos.\n");

		//BinarySearch
		int saberPosicaoDoElemento = al.BinarySearch("Elemento 7");
		Console.Write($"\nUsando o método 'BinarySearch', sabemos que a posição do 'Elemento 7' é: {saberPosicaoDoElemento}.\n\n");
		MostrarElementos(al);

		//Clear e Count
		al.Clear();
		Console.WriteLine("\nUsando o método 'Clear', os elementos do array foram deletados.");
		MostrarElementos(al);
		
		Console.ReadKey();
	}

	static void MostrarElementos(ArrayList A)
	{
		if(A.Count >= 1)
		{
			foreach (var elemento in A)
			{
				Console.WriteLine($"{elemento}");
			}
		} else {
			Console.Write("\nNão há elementos no Array.");
		}
	}
}