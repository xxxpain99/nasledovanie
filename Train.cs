using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
	class Train : Transport
	{

		private int drive;
		private int signal;


		public Train(string mark, string color, float weight) : base(mark, color, weight)
		{
		
		}
		public void drives()
		{
			Console.WriteLine("едет");
		}
		public void honk()
		{
			Console.WriteLine("сигнал");
		}
	}
}
