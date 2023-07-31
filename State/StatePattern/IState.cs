using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
	public interface IState
	{
		//Handle
		public void Action(CustomerContext customerContext , decimal amount);
	}
}
