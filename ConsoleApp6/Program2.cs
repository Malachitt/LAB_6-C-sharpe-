using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	public partial class Person
	{
		partial void DoSomethingElse()
		{
			Console.WriteLine("Содержимое второго класса");
		}
	}
}
