using System.Collections;
using System.Security.Cryptography.X509Certificates;

class Program
{
	static void Main(string[] args)
	{
		int n;
		Console.Write("Qual o tamanho da sua lista? ");
		n = int.Parse(Console.ReadLine());
		Console.WriteLine();

		Console.WriteLine("O tamanho da sua lista é de {0} de espaço.\n", n);

		ArrayList valores = new ArrayList(n);
		Console.WriteLine("Itens adicionados:");
		valores.Add("\nADD - Café do bom");
		valores.Add("ADD - Cubo Mágico"); 
		valores.Add("\nADD - Café do bom");
		valores.Add("ADD - Cubo Mágico");

		Console.WriteLine("A capacidade do ArrayList é de {0} elementos.", valores.Capacity);

		foreach (var elementos in valores)
		{
			Console.WriteLine(elementos);
		}

		Console.WriteLine("Número de elementos: " + valores.Count);
	}
}