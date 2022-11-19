using System;

struct book
{
	public string title;
	public string author;
	public string type;
	public int Price;
}
public class program
{
	public static void Main()
	{
		int nobook = 1000;
		book[] books = new book[nobook];
		int i, j, n = 1, k = 1;
		Console.Write("Insert the information of two books :");
		for (j = 0; j <= n; j++)
		{
			Console.WriteLine("Information of book {0} :", k);

			Console.Write("Input name of the book : ");
			books[j].title = Console.ReadLine();


			Console.Write("Input the author : ");
			books[j].author = Console.ReadLine();
			k++;

			Console.Write("Input Type of the book : ");
			books[j].type = Console.ReadLine();

			Console.Write("Input Price of the book : ");
			books[j].Price = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine();
		}

		for (i = 0; i <= n; i++)
		{
			Console.WriteLine("{0}: Title = {1},  Author = {2}, Type = {3}, Price = {4}", i + 1, books[i].title, books[i].author, books[i].type, books[i].Price);
			Console.WriteLine();
		}

	}
}