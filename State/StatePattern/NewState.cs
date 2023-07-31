using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
	//New Client
	public class NewState : IState
	{
		public void Action(CustomerContext customerContext, decimal amount)
		{
			Console.WriteLine($"we add to your balance {amount}");
			customerContext.Residue = amount;
			customerContext.SetState(new NotDebtorState());
		}
	}
}
