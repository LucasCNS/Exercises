using System.Collections;

class Program
{
	static void Main(string[] args)
	{
		int n;
		int adiciona;
		int total;

		Console.WriteLine("Qual o tamanho da sua lista?");
		n = int.Parse(Console.ReadLine());

		ArrayList valores = new ArrayList(n);
		Console.WriteLine("Aqui está o tamanho da sua lista: {0}", n);

		Console.WriteLine("Quantos itens você quer adicionar?");
		adiciona = int.Parse(Console.ReadLine());

		total = adiciona += n;
		Console.WriteLine("Aqui está o tamanho da sua lista: {0}", total);
	}
}