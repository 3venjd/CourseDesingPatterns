using DesignPatterns.Repository;
using DesingPatternsASP.Models.ViewModels;

namespace DesingPatternsASP.Strategy
{
	public interface IBeerStrategy
	{
		public void Add(FormBeerViewModel beerViewModel,IUnitOfWork unitOfWork);
	}
}
