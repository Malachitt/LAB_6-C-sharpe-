using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	public partial class Person
	{
		partial void DoSomethingElse();

		public void DoSomething()
		{
			Console.WriteLine("Начало первого класса");
			DoSomethingElse();
			Console.WriteLine("Конец первого класса");
		}
	}
}
