// 8 - Faça o método public Dictionary <TKey,TValue> ConcatenaDictionary(Dictionary<TKey,TValue> d1, Dictionary<TKey,TValue> d2)
// que retorna um novo Dictionary<TKey,TValue> como todos os elementos de d1 e d2.

using System.Collections;

class Program
{
	static void Main(string[] args)
	{
		Dictionary<string,string> d1 = new Dictionary<string,string>();

		for (int i = 0; i < 2; i++)
		{
			d1.Add($"Chave {i + 1}", $"Valor {i + 1}");
		}
		Console.WriteLine("Dictionary 1\n");
		Mostrar(d1);

		Dictionary<string, string> d2 = new Dictionary<string, string>();

		for (int i = 2; i < 4; i++)
		{
			d2.Add($"Chave {i + 1}", $"Valor {i + 1}");
		}
		Console.WriteLine("\nDictionary 2\n");
		Mostrar(d2);

		Console.WriteLine("\nDictionary Concatenado\n");
		ConcatenaDictionary(d1, d2);
	}

	public static Dictionary<string, string> ConcatenaDictionary(Dictionary<string, string> d1, Dictionary<string, string> d2)
	{
		Dictionary<string, string> dConcatenado = new Dictionary<string, string>(d1);

		foreach (var item in d2)
		{
			dConcatenado.Add(item.Key, item.Value);
		}
		Mostrar(dConcatenado);
		return dConcatenado;
	}

	static void Mostrar(ICollection collection)
	{
		foreach (KeyValuePair<string, string> item in collection)
		{
			Console.WriteLine($"{item.Key} , {item.Value}");
		}
	}

	//static void Mostrar(ICollection collection)
	//{
	//	foreach (var item in collection)
	//	{
	//		Console.WriteLine(item);
	//	}
	//}
}
