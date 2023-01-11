using System.Collections;

//4 - Faça o método public ArrayList CopiarArrayList(ArrayList origem)
//que copia todos os elementos do ArrayList origem e retorna um novo ArrayList.
//Neste exercício não é permitido o uso dos métodos Clone() nem CopyTo().

//Mais duas formas de fazer

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
		ArrayList origem = new ArrayList();

		Console.WriteLine("ArrayList ORIGEM");
		origem.Add("Elemento1");
		origem.Add("Elemento2");
		origem.Add("Elemento3");

		Mostra(origem);
		CopiarArrayList(origem);
	}

	static ArrayList CopiarArrayList(ArrayList origem)
	{
		ArrayList copia = new ArrayList(origem);
		Console.WriteLine("\nArrayList COPIA");
		copia.Add("Elemento4");
		copia.Add("Elementozinho");
		
		Mostra(copia);

		return copia;
	}

	static void Mostra(ArrayList AL)
	{
		Console.WriteLine();

		foreach (var elemento in AL)
		{
			Console.WriteLine($"{elemento}");
		}
	}	
}