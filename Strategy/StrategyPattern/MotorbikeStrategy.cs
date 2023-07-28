using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
	public class MotorbikeStrategy : IStrategy
	{
		public void Run()
		{
			Console.WriteLine("I'm a motorbike and i move with two wheels");
		}
	}

}
