class Program
{
	public static void Main(string[] args)
	{
		int soma = 0;
		var qntdImpar = 0;
		int[] Valores = new int[5];

		for (int i = 0; i < 5; i++)
		{
			Console.Write($"Digite o valor {i + 1}: ");
			Valores[i] = int.Parse(Console.ReadLine());

			if (Valores[i] % 2 == 0)
			{
				soma += Valores[i];
			} else
			{
				qntdImpar = qntdImpar + 1; 
				//Mais resumido: qntdImpar += 1;
			}
		}
		Console.WriteLine("A soma dos números pares é: {0}. A quantidade de números ímpares é de {1} números.", soma, qntdImpar);
		//Outro exemplo
	  //Console.WriteLine($"A soma dos números pares é: {soma}. A quantidade de números ímpares é de {qntdImpar} números.");

	}
}