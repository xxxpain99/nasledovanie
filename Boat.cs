using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
	class Boat : Transport
	{

		private int drive;
		private int signal;

		public Boat(string mark, string color, float weight) : base(mark, color, weight)
		{
	
		}
		public void drives()
		{
			Console.WriteLine("ходит");
		}
		public void honk()
		{
			Console.WriteLine("сигнал");
		}
	}
}
