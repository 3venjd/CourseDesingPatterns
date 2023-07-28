using DesignPatterns.Repository;
using DesingPatternsASP.Models.ViewModels;

namespace DesingPatternsASP.Strategy
{
	public class BeerContext
	{
		private IBeerStrategy? _strategy;
		public IBeerStrategy Strategy
		{
			set
			{
				_strategy = value;
			}
		}

		public BeerContext(IBeerStrategy? strategy)
		{
			_strategy = strategy;
		}

		public void Add(FormBeerViewModel beerViewModel, IUnitOfWork unitOfWork)
		{
			_strategy?.Add(beerViewModel, unitOfWork);
		}
	}
}
