using Repository.Models;
using Repository.RepositoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWorkPattern
{
	public class UnitOfWork : IUnitOfWork
	{
		private DesingPatternsContext _context;
		IRepository<Beer>? _beers;
		IRepository<Brand>? _brands;

		public UnitOfWork(DesingPatternsContext context)
		{
			_context = context;
		}

		public IRepository<Beer> Beers 
		{
			get 
			{ 
				return _beers == null ? _beers = new Repository<Beer>(_context) : _beers;
			}
		}
		public IRepository<Brand> Brands
		{
			get
			{
				return _brands == null ? _brands = new Repository<Brand>(_context) : _brands;
			}
		}
		public void Save()
		{
			_context.SaveChanges();
		}
	}
}
