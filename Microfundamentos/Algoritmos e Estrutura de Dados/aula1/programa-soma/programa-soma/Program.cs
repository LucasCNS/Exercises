class SomaDoisNumeros
{
	public static void Main()
	{
		int num1, num2, soma;
		Console.WriteLine("Digite um número:");
		num1 = int.Parse(Console.ReadLine());

		Console.WriteLine("Digite outro número:");
		num2 = int.Parse(Console.ReadLine());

		soma = num1 + num2;

		Console.WriteLine("Soma:" + soma);
	}
}