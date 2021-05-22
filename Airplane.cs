using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
	class Airplane : Transport
	{

		private int fly;
		private int landing;

		public Airplane(string mark, string color, float weight) : base(mark, color, weight)
		{
			
		}
		public void flying()
		{
			Console.WriteLine("летит");
		}
		public void lands()
		{
			Console.WriteLine("посадка");
		}
	}
}
