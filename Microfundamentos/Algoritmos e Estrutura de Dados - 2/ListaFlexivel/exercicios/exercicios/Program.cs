class Celula
{
	public int elemento; // Elemento inserido na célula.
	public Celula prox; // Aponta para a célula prox.
	public Celula()
	{
		this.elemento = 0;
		this.prox = null;
	}
	public Celula(int elemento)
	{
		this.elemento = elemento;
		this.prox = null;
	}
}
class Lista
{
	private Celula primeiro;
	private Celula ultimo;


	public Lista()
	{
		primeiro = new Celula();
		ultimo = primeiro;
	}

	//Classe Lista Flexível: InserirFim
	public void InserirFim(int x)
	{
		ultimo.prox = new Celula(x);
		ultimo = ultimo.prox;
	}

	//Classe Lista Flexível: Mostrar
	public void Mostrar()
	{
		Console.Write("[ ");
		for (Celula i = primeiro.prox; i != null; i = i.prox)
		{
			Console.Write(i.elemento + " ");
		}
		Console.Write("]");
	}

	//Classe Lista Flexível: InserirInicio
	public void InserirInicio(int x)
	{
		Celula tmp = new Celula(x);
		tmp.prox = primeiro.prox;
		primeiro.prox = tmp;
		if (primeiro == ultimo)
		{
			ultimo = tmp;
		}
		tmp = null;
	}

	//Classe Lista Flexível: Remover no Fim
	public int RemoverFim()
	{
		if (primeiro == ultimo)
			Environment.Exit(0);
		Celula i;
		for (i = primeiro; i.prox != ultimo; i = i.prox) ;
		int elemento = ultimo.elemento;
		ultimo = i;
		i = ultimo.prox = null;

		return elemento;
	}

	//Classe Lista Flexível: Remover do Início
	public int RemoverInicio()
	{
		if (primeiro == ultimo)
			Environment.Exit(0);
		Celula tmp = primeiro.prox;
		primeiro.prox = primeiro.prox.prox;
		int elemento = tmp.elemento;
		tmp.prox = null;
		tmp = null;
		return elemento;
	}

	public int Tamanho()
	{
		int tamanho = 0;
		if (primeiro != null)
		{
			for (Celula i = primeiro; i != ultimo; i = i.prox, tamanho++) ;
		}
		return tamanho;
	}

	//Classe Lista Flexível: Inserir
	public void Inserir(int x, int pos)
	{
		int tamanho = Tamanho();
		if (pos < 0 || pos > tamanho)
		{
			Environment.Exit(0);
		}
		else if (pos == 0)
		{
			InserirInicio(x);
		}
		else if (pos == tamanho)
		{
			InserirFim(x);
		}
		else
		{
			Celula i = primeiro;
			for (int j = 0; j < pos; j++, i = i.prox) ;
			Celula tmp = new Celula(x);
			tmp.prox = i.prox;
			i.prox = tmp;
			tmp = i = null;
		}
	}

	//Classe Lista Flexível: Remover
	public int Remover(int pos)
	{
		int tamanho = Tamanho();
		int elemento = Tamanho();
		if (primeiro == ultimo || pos < 0 || pos >= tamanho)
		{
			Environment.Exit(0);
		}
		else if (pos == 0)
		{
			elemento = RemoverInicio();
		}
		else if (pos == tamanho - 1)
		{
			elemento = RemoverFim();
		}
		else
		{
			Celula i = primeiro;
			for (int j = 0; j < pos; j++, i = i.prox) ;
			Celula tmp = i.prox;
			elemento = tmp.elemento;
			i.prox = tmp.prox;
			tmp.prox = null;
			i = tmp = null;
		}
		return elemento;
	}

	//1 - Em nossa lista flexível, implemente um método que remove a segunda posição válida.
	public int RemoverSegundaPosicao()
	{
		if (primeiro == ultimo)
			Environment.Exit(0);

		Celula tmp = primeiro.prox.prox;
		primeiro.prox = primeiro.prox.prox;
		int elemento = tmp.elemento;
		tmp.prox = null;
		tmp = null;
		return elemento;
	}

	//2 - Em nossa lista flexível, implemente um método que retorna a soma os elementos contidos na mesma.
	public int Soma()
	{
		int soma = 0;
		for (Celula i = primeiro.prox; i != null; i = i.prox)
		{
			soma += i.elemento;
		}
		return soma;
	}

	public int MaiorElemento()
	{
		int maiorElemento = 0;
		for (Celula i = primeiro.prox; i != null; i = i.prox)
		{
			if (i.elemento > maiorElemento)
				maiorElemento = i.elemento;
		}
		return maiorElemento;
	}
}

class Program
{
	public static void Main(string[] args)
	{
		Lista lista = new Lista();

		lista.InserirInicio(10);
		lista.InserirInicio(20);
		lista.RemoverSegundaPosicao();
		lista.InserirInicio(30);
		lista.Inserir(12, 1);
		lista.Inserir(200, 0);
		lista.InserirFim(100);
		lista.InserirFim(150);
		lista.Mostrar();

		Console.WriteLine($"\n\nSoma dos Elementos: {lista.Soma()}");
		Console.WriteLine($"\nSoma dos Elementos: {lista.MaiorElemento()}");
	}
}