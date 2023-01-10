using System;
using System.Collections;
class MainClass
{
	public static void Main(string[] args)
	{
		ArrayList al = new ArrayList();
		Console.Write("AL.Capacity({0}) / AL.Count({1})\n", al.Capacity, al.Count);
		al.Add(1);
		Console.Write("AL.Capacity({0}) / AL.Count({1})\n", al.Capacity, al.Count);
	}
}