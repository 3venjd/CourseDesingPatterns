using Repository.Models;
using Repository.RepositoryPattern;

//without use Irepository
//using (var context = new DesingPatternsContext())
//{
//	//var lst = context.Beers.ToList();
//	//foreach (var beer in lst)
//	//{
//	//	Console.WriteLine(beer.Name);
//	//}


//	//var beerRepository = new BeerRepository(context);
//	//var beer = new Beer();
//	//beer.Name = "Corona";
//	//beer.Style = "Pilsner";

//	//beerRepository.Add(beer);
//	//beerRepository.Save();

//	//foreach (var b in beerRepository.Get())
//	//{
//	//	Console.WriteLine(b.Name);
//	//}
//}

//using IRepository
using (var context = new DesingPatternsContext())
{
	var beerRepository = new Repository<Beer>(context);
	//var beer = new Beer()
	//{
	//	Name = "Fuller",
	//	Style = "Strong Ale"
	//};
	//beerRepository.Add(beer);
	beerRepository.Delete(7);

	beerRepository.Save();

	foreach (var b in beerRepository.Get())
	{
		Console.WriteLine($"{b.BeerId} {b.Name}");
	}


	var brandRepository = new Repository<Brand>(context);
	var brand = new Brand()
	{
		Name = "InitialBrand",
	};
	brandRepository.Add(brand);
	brandRepository.Save();

	foreach (var b in brandRepository.Get())
	{
		Console.WriteLine($"{b.BrandId} {b.Name}");
	}

}