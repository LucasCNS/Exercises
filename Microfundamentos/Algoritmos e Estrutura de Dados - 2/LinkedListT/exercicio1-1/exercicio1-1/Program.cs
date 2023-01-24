//Faça o método public int QtdeOcorrencias(List<String> origem, String elemento)
//que retorna a quantidade de vezes que o elemento passado como parâmetro está armazenado no List<String> origem.

using System.Collections;

class Program
{
	static void Main(string[] args)
	{
		List<string> origem = new List<string>();
		for (int i = 0; i < 5; i++)
		{
			origem.Add("Item" + i);
		}
		origem.Add("Item1");
		origem.Add("Item1");

		Console.WriteLine("List:\n");
		Mostrar(origem);

		string elemento = null;
		Console.Write("\nDigite o item que procura: ");
		elemento = Console.ReadLine();

		QtdeOcorrencias(origem, elemento);
	}

	public static int QtdeOcorrencias(List<String> origem, String elemento)
	{
		int qtdAparece = 0;

		for (int i = 0; i < origem.Count; i++)
		{
			if (origem[i].Equals(elemento)) qtdAparece ++;
		}
		
		Console.WriteLine($"O número de vezes que o '{elemento}' aparece, é de {qtdAparece} vezes.");
		return qtdAparece;
	}

	static void Mostrar(IEnumerable origem)
	{
		foreach (var item in origem)
		{
			Console.WriteLine($"{item}");
		}
	}
}