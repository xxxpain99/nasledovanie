using System;

namespace ConsoleApp10
{
	class Program
	{
		static void Main(string[] args)
		{

			Car transport = new Car("mark", "red", 1400);
			transport.drives();
			transport.honk();

			Motorcycle transport1 = new Motorcycle("mark", "blue", 890);
			transport1.drives();
			transport1.honk();

			Airplane transport3 = new Airplane("mark", "white", 60000);
			transport3.flying();
			transport3.lands();

			Train transport4 = new Train("mark", "black", 80000);
			transport.drives();
			transport.honk();

			Boat transport5 = new Boat("mark", "red", 14000);
			transport.drives();
			transport.honk();
		}


	}
}
