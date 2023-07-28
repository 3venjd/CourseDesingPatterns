using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
	public class CarStrategy : IStrategy
	{
		public void Run()
		{
			Console.WriteLine("I'm a Car and i move with four wheels");
		}
	}
}
