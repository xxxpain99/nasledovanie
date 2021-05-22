using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
	class Transport
	{
		protected string mark;
		protected string color;
		protected float weight;

		public Transport(string mark, string color, float weight) 
		{ 
			this.color = color;
			this.mark = mark;
			this.weight = weight;
		}

	}
}
