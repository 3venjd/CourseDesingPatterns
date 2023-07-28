using DesignPatterns.Models.Data;
using DesignPatterns.Repository;
using DesingPatternsASP.Models.ViewModels;

namespace DesingPatternsASP.Strategy
{
	public class BeerWithBrandStategy : IBeerStrategy
	{
		public void Add(FormBeerViewModel beerViewModel, IUnitOfWork unitOfWork)
		{
			var beer = new Beer();
			beer.Name = beerViewModel.Name;
			beer.Style = beerViewModel.Style;

			var brand = new Brand();
			brand.Name = beerViewModel.Name;
			brand.BrandId = Guid.NewGuid();
			beer.BrandId = brand.BrandId;

			unitOfWork.Brands.Add(brand);
			unitOfWork.Beers.Add(beer);

			unitOfWork.Save();
		}
	}
}
