// 1 - Em nossa lista linear, implemente um método que retorna a soma dos elementos contidos na mesma.

using System.Collections;

class Lista
{
	private int[] array;
	private int n;

	/**
	 * Construtor da classe.
	 */
	public Lista()
	{
		array = new int[6];
		n = 0;
	}

	/**
	 * Construtor da classe.
	 * @param tamanho Tamanho da lista.
	 */
	public Lista(int tamanho)
	{
		array = new int[tamanho];
		n = 0;
	}

	/**
	 * Insere um elemento na primeira posicao da lista e move os demais
	 * elementos para o fim da lista.
	 * @param x int elemento a ser inserido.
	 */
	public void InserirInicio(int x)
	{

		//validar insercao
		if (n >= array.Length)
		{
			Console.WriteLine("Erro ao inserir!");
			Environment.Exit(0);
		}

		//levar elementos para o fim do array
		for (int i = n; i > 0; i--)
		{
			array[i] = array[i - 1];
		}

		array[0] = x;
		n++;
	}

	/**
	 * Insere um elemento na ultima posicao da lista.
	 * @param x int elemento a ser inserido.
	 */
	public void InserirFim(int x)
	{

		//validar insercao
		if (n >= array.Length)
		{
			Console.WriteLine("Erro ao inserir!");
			Environment.Exit(0);
		}

		array[n] = x;
		n++;
	}

	/**
	 * Insere um elemento em uma posicao especifica e move os demais
	 * elementos para o fim da lista.
	 * @param x int elemento a ser inserido.
	 * @param pos Posicao de insercao.
	 */
	public void Inserir(int x, int pos)
	{

		//validar insercao
		if (n >= array.Length || pos < 0 || pos > n)
		{
			Console.WriteLine("Erro ao inserir!");
			Environment.Exit(0);
		}

		//levar elementos para o fim do array
		for (int i = n; i > pos; i--)
		{
			array[i] = array[i - 1];
		}

		array[pos] = x;
		n++;
	}

	/**
	 * Remove um elemento da primeira posicao da lista e movimenta 
	 * os demais elementos para o inicio da mesma.
	 * @return resp int elemento a ser removido.
	 */
	public int RemoverInicio()
	{

		//validar remocao
		if (n == 0)
		{
			Console.WriteLine("Erro ao remover!");
			Environment.Exit(0);
		}

		int resp = array[0];
		n--;

		for (int i = 0; i < n; i++)
		{
			array[i] = array[i + 1];
		}

		return resp;
	}

	/**
	 * Remove um elemento da ultima posicao da lista.
	 * @return resp int elemento a ser removido.
	 */
	public int RemoverFim()
	{

		//validar remocao
		if (n == 0)
		{
			Console.WriteLine("Erro ao remover!");
			Environment.Exit(0);
		}

		return array[--n];
	}

	/**
	 * Remove um elemento de uma posicao especifica da lista e 
	 * movimenta os demais elementos para o inicio da mesma.
	 * @param pos Posicao de remocao.
	 * @return resp int elemento a ser removido.
	 */
	public int Remover(int pos)
	{

		//validar remocao
		if (n == 0 || pos < 0 || pos >= n)
		{
			Console.WriteLine("Erro ao remover!");
			Environment.Exit(0);
		}

		int resp = array[pos];
		n--;

		for (int i = pos; i < n; i++)
		{
			array[i] = array[i + 1];
		}

		return resp;
	}

	/**
	 * Mostra os elementos da lista separados por espacos.
	 */
	public void Mostrar()
	{
		Console.Write("[ ");
		for (int i = 0; i < n; i++)
		{
			Console.Write(array[i] + " ");
		}
		Console.WriteLine("]");
	}

	/**
	 * Procura um elemento e retorna se ele existe.
	 * @param x int elemento a ser pesquisado.
	 * @return <code>true</code> se o array existir,
	 * <code>false</code> em caso contrario.
	 */
	public bool Pesquisar(int x)
	{
		bool retorno = false;
		for (int i = 0; i < n && retorno == false; i++)
		{
			retorno = (array[i] == x);
		}
		return retorno;
	}

	public int Soma()
	{
		int soma = 0;
		for (int i = 0; i < array.Length; i++)
		{
			soma += array[i];
		}
		return soma;
	}
}

class Program
{
	
	static void Main(string[] args)
	{
		Console.WriteLine("==== LISTA SEQUENCIAL ====");
		Lista lista = new Lista();
		int x1, x2, x3;

		lista.InserirInicio(1);
		lista.InserirInicio(0);
		lista.InserirFim(2);
		lista.InserirFim(3);
		lista.Inserir(4, 3);
		lista.Inserir(5, 2);

		lista.Mostrar();

		lista.Soma();
	}
}
