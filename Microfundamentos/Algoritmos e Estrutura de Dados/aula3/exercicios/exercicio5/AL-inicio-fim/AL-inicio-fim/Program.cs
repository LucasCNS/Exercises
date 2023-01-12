using System.Collections;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System;

//5 - Faça o método public ArrayList CopiarParteArrayList
//(ArrayList origem, int início, int final)
//que recebe um ArrayList origem e os inteiros início e final e retorna outro ArrayList
//contendo todos os elementos dentro do intervalo determinado pelos parâmetros início e final.
//Se o ArrayList origem tiver menos posições do que determinado pelo parâmetro final, copie até a sua última posição.
//Se o parâmetro início for maior que a quantidade de elementos do ArrayList origem, retorne um ArrayList vazio.
//Por fim, se o parâmetro início for maior que o parâmetro final, indique que o usuário deseja copiar os dados na ordem invertida.
//Neste exercício não é permitido o uso dos métodos Clone() nem CopyTo().

//Mais duas maneiras de fazer:

//Formula 2

//ArrayList copia = new ArrayList();
//copia.AddRange(origem);

//Forumla 3

//ArrayList copia = new ArrayList();
//foreach (var itemOrigem in origem)
//{
//	copia.Add(itemOrigem)
//}

class Objeto
{
	public string Item { get; set; }
	private const int qntElementos = 5;

	
	public Objeto() 
	{
		Item = "";
	}
	
	public Objeto(string item)
	{
		Item = item;
	}
}
class Program
{
	static void Main(string[] args)
	{
		int inicio = 0;
		int final = 0;
		string item = null;
		int inicia = 1;
		int qntElementos = 6;
		ArrayList origem = new ArrayList();

		for (int i = inicia; i < qntElementos; i++)
		{
			Console.Write($"Preencha valor na posição {i} o item: ");
			item = Console.ReadLine();
			
			origem.Add(new Objeto(item));
		}
		
		Console.WriteLine("ArrayList ORIGEM");
		Mostra(origem);

		CopiarParteArrayList(origem, inicio, final);
	}

	static ArrayList CopiarParteArrayList(ArrayList origem, int inicio, int final)
	{
		int qntElementos = 6;

		Console.WriteLine();
		Console.WriteLine("Quais fones você deseja pegar?");
		Console.WriteLine();
		Console.WriteLine("Digite o número que inicia o intervalo dos que você quer:");
		inicio = int.Parse(Console.ReadLine());
		inicio = inicio - 1;
		
		Console.WriteLine("Digite o número que finaliza o intervalo dos que você quer:");
		final = int.Parse(Console.ReadLine());
		final = final - 1;

		do
		{
			
			ArrayList copia = new ArrayList();
			Console.WriteLine("\nArrayList COPIA");


			for (int i = inicio; i <= final; i++)
			{
				copia.Add(origem[i]);
			}

			if (inicio > qntElementos)
			//Se o parâmetro início for maior que a quantidade de elementos do ArrayList origem, retorne um ArrayList vazio.
			{
				copia.Clear();
				Console.WriteLine("O ArrayList está vazio.");

			}
			else if (inicio > final)
			//Se o parâmetro início for maior que o parâmetro final, indique que o usuário deseja copiar os dados na ordem invertida.
			{
				Console.WriteLine("Você optou por inverter as posições do Array.");
				Console.WriteLine("Você optou por inverter as posições do Array.");
				for (int i = final; i <= inicio; i++)
				{
					copia.Add(origem[i]);
					copia.Reverse();
				}
				Mostra(copia);
			}
			else if (origem.Count < final)
			//Se o ArrayList origem tiver menos posições do que determinado pelo parâmetro final, copie até a sua última posição.
			{
				Console.WriteLine("Valores de inicio e fim são inválidos.");
				copia.AddRange(origem);
				Mostra(copia);
			}
			Mostra(copia);
			return copia;
		} while (inicio<final);
	}

	static void Mostra(ArrayList arraylist)
	{
		Console.WriteLine();

		foreach (Objeto a in arraylist)
		{
			Console.WriteLine($"{a.Item}");
		}
		Console.ReadKey();
	}
}