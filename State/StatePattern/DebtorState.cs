using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
	public class DebtorState : IState
	{
		public void Action(CustomerContext customerContext, decimal amount)
		{
			Console.WriteLine("you can't buy");
		}
	}
}
