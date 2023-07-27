using Repository.Models;
using UnitOfWorkPattern;

using (var context = new DesingPatternsContext())
{
	var unitOfWork = new UnitOfWork(context);

	var beers = unitOfWork.Beers;

	var beer = new Beer()
	{
		Name = "Fuller",
		Style = "Porter"
	};

	beers.Add(beer);

	var brands = unitOfWork.Brands;

	var brand = new Brand()
	{
		Name = "Fuller",
	};

	brands.Add(brand);


	//save all objects in a one save implementation, this helps to concurrency(eficienty)
	unitOfWork.Save();
}