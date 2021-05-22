using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
	class Motorcycle : Transport
	{

		private int drive;
		private int signal;

		public Motorcycle(string mark, string color, float weight) : base (mark, color, weight)
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
