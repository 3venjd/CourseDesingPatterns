using DesignPatterns.Models.Data;
using DesignPatterns.Repository;
using DesingPatternsASP.Models.ViewModels;
using DesingPatternsASP.Strategy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DesingPatternsASP.Controllers
{
	public class BeerController : Controller
	{
		private readonly IUnitOfWork? _unitOfWork;

		public BeerController(IUnitOfWork? unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		public IActionResult Index()
		{
			IEnumerable<BeerViewModel> beers = from d in _unitOfWork?.Beers.Get()
											   select new BeerViewModel
											   {
												   Id = d.BeerId,
												   Name = d.Name,
												   Style = d.Style
											   };
			return View("Index", beers);
		}

		[HttpGet]
		public IActionResult Add()
		{
			// Unit of Work
			//var brands = _unitOfWork?.Brands.Get();
			//ViewBag.Brands = new SelectList(brands, "BrandId", "Name");
			//return View();

			GetBrandsData();
			return View();
		}

		[HttpPost]
		public IActionResult Add(FormBeerViewModel beerViewModel)
		{
			if (!ModelState.IsValid)
			{
				GetBrandsData();
				return View("Add", beerViewModel);
			}

			var context = beerViewModel.BrandId == null ?
							new BeerContext(new BeerWithBrandStategy()) :
							new BeerContext(new BeerStrategy());

			context.Add(beerViewModel,_unitOfWork!);

			return RedirectToAction("Index");
		}

		#region HELPERS
		private void GetBrandsData()
		{
			var brands = _unitOfWork?.Brands.Get();
			ViewBag.Brands = new SelectList(brands, "BrandId", "Name");
		}
		#endregion

	}
}
