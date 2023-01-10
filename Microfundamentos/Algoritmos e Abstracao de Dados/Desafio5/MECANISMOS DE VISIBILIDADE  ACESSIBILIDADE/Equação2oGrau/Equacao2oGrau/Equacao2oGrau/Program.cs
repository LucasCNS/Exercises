using System.Runtime.CompilerServices;

class Eq2Grau
{
	private double _a;   //Atributo

	public double a     //Propriedade
	{
		get { return _a; }
		set { _a = value; }
	}

	private double _b;   //Atributo

	public double b     //Propriedade
	{
		get { return _b; }
		set { _b = value; }
	}

	private double _c;   //Atributo

	public double c     //Propriedade
	{
		get { return _c; }
		set { _c = value; }
	}

	private double _Delta;

	public double Delta
	{
		get { return _Delta; }
		//set { _Delta = value; }
	}

	private double _Raiz1;

	public double Raiz1
	{
		get { return _Raiz1; }
		//set { _Raiz1 = value; }
	}

	private double _Raiz2;

	public double Raiz2
	{
		get { return _Raiz2; }
		//set { _Raiz2 = value; }
	}

	private void CalcDelta()   //Método Privado. Restringe o método à classe que ele está dentro.
	{
		_Delta = Math.Pow(b, 2) - 4 * a * c;
	}
	public bool CalcRaizes()   //Método Público. Dentro e fora da classe, é possível "ver" o método "CalcRaizes()".
	{
		CalcDelta();

		if (TestaDelta())
		{
			_Raiz1 = (-b + Math.Sqrt(Delta)) / (2 * a);
			_Raiz2 = (-b - Math.Sqrt(Delta)) / (2 * a);

			return true;
		}
		else
		{
			return false;
		}

	}

	private bool TestaDelta()
	{
		if (_Delta < 0)
			return false;
		else
			return true;
	}
}

class Program
{
	static void Main(string[] args)
	{
		Eq2Grau Equacao = new Eq2Grau();

		Console.Write("a = ");
		Equacao.a = double.Parse(Console.ReadLine());

		Console.Write("b = ");
		Equacao.b = double.Parse(Console.ReadLine());

		Console.Write("c = ");
		Equacao.c = double.Parse(Console.ReadLine());

		if (Equacao.CalcRaizes())
		{
			Console.WriteLine($"\nDelta = {Equacao.Delta:F2}\n");
			Console.WriteLine($"Raiz 1 = {Equacao.Raiz1:F2}");
			Console.WriteLine($"Raiz 2 = {Equacao.Raiz2:F2}");
		}
		else
		{
			Console.WriteLine("Essa equação não possui raízes reais.");
		}
		Console.ReadKey();
	}
}