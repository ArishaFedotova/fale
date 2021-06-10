using System;
using System.Text;

namespace ConsoleApp21
{
	class Program
	{
		static void Main(string[] args)
		{
			MyList<int> spisok = new MyList<int>();

			spisok.Add(new Node<int>(10));
			spisok.Add(new Node<int>(28));
			spisok.Add(new Node<int>(32));
			spisok.Add(new Node<int>(22));
			spisok.Add(new Node<int>(12));
			spisok.Print();
			Console.WriteLine("Вставка после индексом");
			spisok.InsertAfter(new Node<int>(123), 3);
			spisok.Print();
			Console.WriteLine("Вставка перед индексом");
			spisok.InsertBefore(new Node<int>(123), 3);
			spisok.Print();
			Console.WriteLine("Удаление с выводом");
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine(spisok.Remove(2));
			Console.WriteLine();
			Console.WriteLine();
			spisok.Print();
			Console.WriteLine("Удаление с начала");
			Console.WriteLine();
			Console.WriteLine(spisok.PopFront());
			Console.WriteLine();
			Console.WriteLine();
			spisok.Print();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Удаление с конца");
			Console.WriteLine();
			Console.WriteLine(spisok.PopBack());
			Console.WriteLine();
			Console.WriteLine();
			spisok.Print();


			Console.WriteLine("Id of your passed value: ");
			Console.WriteLine(spisok.Search(22));
		}
	}
}







