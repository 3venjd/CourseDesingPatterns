using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
	public class NotDebtorState : IState
	{
		public void Action(CustomerContext customerContext, decimal amount)
		{
			if (amount <= customerContext.Residue)
			{
				customerContext.Discount(amount);
				Console.WriteLine($"the request is allow, spend {amount} and your new balance is {customerContext.Residue} ");
				if (customerContext.Residue <= 0)
				{
					customerContext.SetState(new DebtorState());
				}
			}
            else
            {
                
            }
        }
	}
}
