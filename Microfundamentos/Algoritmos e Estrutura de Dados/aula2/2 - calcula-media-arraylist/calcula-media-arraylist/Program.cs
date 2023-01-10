//1 - Faça um programa que leia 5 números inteiros, os adicione em um ArrayList
//e calcule a média deles.

//2 - Em seguida, mostre na tela aqueles que forem maiores que a média.

//3 - Seu programa terá duas estruturas de repetição sendo a primeira,
// um FOR, e a segunda, um FOREACH.
using System.Collections;

class Program
{
	public static void Main(string[] args)
	{
		double[] valor;
		double media = 0;
		double soma = 0;
		int tamanhoPadrao = 5;
		valor = new double[tamanhoPadrao];

		ArrayList al = new ArrayList(tamanhoPadrao);
		
		for (int i = 0; i < tamanhoPadrao; i++)
		{
			Console.Write($"Adicione o {i + 1}o valor: ");
			valor[i] = double.Parse(Console.ReadLine());
			al.Add(valor[i]);

			soma += valor[i];
		}

		Console.WriteLine($"\nA soma dos valores é de: {soma}");

		media = soma / tamanhoPadrao;

		Console.WriteLine($"\nO valor da média é de: {media}");
		Console.WriteLine();

		foreach (double elementos in al)
		{
			if (elementos >= media)
			{
				Console.WriteLine($"Valores na média: {elementos}");
			}
		}
		Console.BackgroundColor= ConsoleColor.Red;
		Console.ForegroundColor= ConsoleColor.Black;
		Console.WriteLine("───▄▄▄▄▄▄─────▄▄▄▄▄▄\r\n─▄█▓▓▓▓▓▓█▄─▄█▓▓▓▓▓▓█▄\r\n▐█▓▓▒▒▒▒▒▓▓█▓▓▒▒▒▒▒▓▓█▌\r\n█▓▓▒▒░╔╗╔═╦═╦═╦═╗░▒▒▓▓█\r\n█▓▓▒▒░║╠╣╬╠╗║╔╣╩╣░▒▒▓▓█\r\n▐█▓▓▒▒╚═╩═╝╚═╝╚═╝▒▒▓▓█▌\r\n─▀█▓▓▒▒░░░░░░░░░▒▒▓▓█▀\r\n───▀█▓▓▒▒░░░░░▒▒▓▓█▀\r\n─────▀█▓▓▒▒░▒▒▓▓█▀\r\n──────▀█▓▓▒▓▓█▀\r\n────────▀█▓█▀\r\n──────────▀");
		Console.ReadKey();
	}
}