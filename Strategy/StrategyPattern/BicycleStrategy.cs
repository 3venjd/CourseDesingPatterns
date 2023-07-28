using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
	internal class BicycleStrategy : IStrategy
	{
		public void Run()
		{
			Console.WriteLine("I'm a bicycle and i pedal to move");
		}
	}
}
