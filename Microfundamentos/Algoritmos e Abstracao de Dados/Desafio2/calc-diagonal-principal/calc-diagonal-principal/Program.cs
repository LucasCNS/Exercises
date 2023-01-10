using System;
class Program
{
	public static void Main(string[] args)
	{
		int diagonalPrincipal = 0;
		int[,] Valores = new int[3, 3];

		for (int i = 0; i < 3; i++)
		{
			for (int j = 0; j < 3; j++)
			{
				Console.WriteLine($"Digite o valor da linha {i + 1} da coluna {j + 1}");
				Valores[i, j] = int.Parse(Console.ReadLine());

				if (i == j)
				{
					diagonalPrincipal += Valores[i, j];
				}
			}
		}
		Console.WriteLine($"A soma da diagonal principal da sua matriz é {diagonalPrincipal}.");
	}
}