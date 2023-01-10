using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace DesafioFinal 
{
	class VetorTunado
	{
		private const int TamanhoPadrao = 10;
		private int[] _vetor;
		//Construtor, constrói o objeto.
		
		public VetorTunado(int tamanho)
		{
			_vetor = new int[tamanho];
		}
		
		public VetorTunado()
		{
			_vetor = new int[TamanhoPadrao];
		}
		
		public VetorTunado(int tamanho, int valorAleatorioMin, int valorAleatorioMax)
		{
			_vetor = new int[tamanho];

			Random geradorValoresAleatorios = new Random();
			
			for (int i = 0; i < _vetor.Length; i++)
			{
				int valorAleatorioMaxInclusivo = valorAleatorioMax + 1;
				int valorAleatorio = geradorValoresAleatorios.Next(valorAleatorioMin, valorAleatorioMaxInclusivo);

				_vetor[i] = valorAleatorio;
			}
		}
		
		public VetorTunado(int valorAleatorioMin, int valorAleatorioMax)
		{
			_vetor = new int[TamanhoPadrao];

			
		}

		private int[] CriarVetorValoresAleatorios(int tamanho, int valorAleatorioMin, int valorAleatorioMax)
		{
			int[] vetorValoresAleatorios = new int[tamanho];

			Random geradorValoresAleatorios = new Random();
			int valorAleatorioMaxInclusivo = valorAleatorioMax + 1;

			for (int i = 0; i < _vetor.Length; i++)
			{
				int valorAleatorio = geradorValoresAleatorios.Next(valorAleatorioMin, valorAleatorioMaxInclusivo);

				_vetor[i] = valorAleatorio;
			}
		}

		public void ListarElementos()
		{
			int ultimaPos = _vetor.Length - 1;
			for (int i = 0; i < _vetor.Length; i++)
			{
				bool ultimoElemento = i == ultimaPos;

				Console.Write(_vetor[i]);

				if (!ultimoElemento)
				{
					Console.Write(", ");
				}
			}
		}

		public void InserirElementos(int posicao, int valor)
		{
			_vetor[posicao] = valor;
		}

		public int RecuperarElemento(int posicao)
		{
			return _vetor[posicao];
		}

		public int RecuperarMaiorElemento()
		{
			int maiorValor = 0;
			foreach (var valor in _vetor)
			{
				if (valor > maiorValor)
				{
					maiorValor = valor;
				}
			}
			return maiorValor;
		}
		public int RecuperarMenorElemento()
		{
			int menorValor = _vetor[0];
			//foreach (var valor in _vetor) PASSAVA DUAS VEZES PELA POSIÇÃO [0]
			//{
			//	if (valor < menorValor)
			//	{
			//		menorValor = valor;
			//	}
			//}
			for (int i = 0; i < _vetor.Length; i++)
			{
				if (_vetor[i] < menorValor)
				{
					menorValor = _vetor[i];
				}
				
			}
			return menorValor;
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Digite o tamanho do vetor: ");
			int tamanho = int.Parse(Console.ReadLine());
			VetorTunado vetorTunado = new VetorTunado(tamanho);
			VetorTamanhoInformado();
			VetorTamanhoPadrao();
			VetorTamanhoInformadoAleatorio();
			VetorTamanhoPadraoAleatorio();
			;
			; 
			;


			//int tamanhoDigitado = 5;
			//VetorTunado vetorA = new VetorTunado(tamanhoDigitado);
			//VetorTunado vetorB = new VetorTunado();

			//int valorMin = 1;
			//int valorMax = 10;

			//VetorTunado vetorC = new VetorTunado(tamanhoDigitado, valorMin, valorMax);

			//vetorC.ListarElementos();

			//int posicao = 2;
			//int valor = 125;

			//vetorC.InserirElementos(posicao, valor);
			//vetorC.ListarElementos();

			//int valorRecuperado = vetorC.RecuperarElemento(posicao);
			//Console.WriteLine($"O valor recuperado da posição {posicao} foi: {valorRecuperado}");


			//int maiorValor = vetorC.RecuperarMaiorElemento();
			//VetorTunado vetorD = new VetorTunado(valorMin, valorMax);

		}

		static void VetorTamanhoInformado()
		{
			Console.Write("-------------------------------------\n");
			Console.Write("Vetor tamanho informado pelo usuário.");
			Console.Write("-------------------------------------\n");

			Console.Write("Digite o tamanho do vetor: ");
			
			int tamanho = int.Parse(Console.ReadLine());
			VetorTunado vetorTunado = new VetorTunado(tamanho);
			vetorTunado.ListarElementos();
		}
		static void VetorTamanhoPadrao()
		{
			Console.Write("-------------------------------------\n");
			Console.Write("Vetor tamanho padrão.");
			Console.Write("-------------------------------------\n");
	
			VetorTunado vetorTunado = new VetorTunado();
			vetorTunado.ListarElementos();
		}
		static void VetorTamanhoInformadoAleatorio()
		{
			Console.Write("-------------------------------------\n");
			Console.Write("Vetor tamanho informado pelo usuário e valor aleatório.");
			Console.Write("-------------------------------------\n");

			Console.Write("Digite o tamanho do vetor: ");
			int tamanho = int.Parse(Console.ReadLine());

			Console.Write("Digite o tamanho do vetor: ");
			int valorAleatorioMin = int.Parse(Console.ReadLine());

			Console.Write("Digite o tamanho do vetor: ");
			int valorAleatorioMax = int.Parse(Console.ReadLine());

			VetorTunado vetorTunado = new VetorTunado(tamanho, valorAleatorioMin, valorAleatorioMax);
			vetorTunado.ListarElementos();
		}
		static void VetorTamanhoPadraoAleatorio()
		{
			Console.Write("-------------------------------------\n");
			Console.Write("Vetor tamanho informado pelo usuário e valor aleatório.");
			Console.Write("-------------------------------------\n");

			Console.Write("Digite o tamanho do vetor: ");
			int valorAleatorioMin = int.Parse(Console.ReadLine());

			Console.Write("Digite o tamanho do vetor: ");
			int valorAleatorioMax = int.Parse(Console.ReadLine());

			VetorTunado vetorTunado = new VetorTunado(valorAleatorioMin, valorAleatorioMax);
			vetorTunado.ListarElementos();
		}
		static void ExibirMaiorMenor(int menorValor, int maiorValor)
		{
			Console.WriteLine($"O maior valor do vetor é: {maiorValor}");
			Console.WriteLine($"O maior valor do vetor é: {menorValor}");
		}
	}
}
