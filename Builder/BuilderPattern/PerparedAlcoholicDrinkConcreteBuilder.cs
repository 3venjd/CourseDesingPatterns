using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
	public class PerparedAlcoholicDrinkConcreteBuilder : IBuilder
	{
		private PreparedDrink? _preparedDrink;

		public PerparedAlcoholicDrinkConcreteBuilder()
		{
			Reset();
		}

		public void AddIngredients(string ingredients)
		{
			if (_preparedDrink?.Ingredients == null)
			{
				_preparedDrink!.Ingredients = new List<string>();
			}

			_preparedDrink.Ingredients.Add(ingredients);
		}

		public void Mix()
		{
			string ingredients = _preparedDrink!.Ingredients!.Aggregate((i,j) => i + "," + j);
			_preparedDrink.Result = $"Prepared drink with {_preparedDrink.Alcohol} of alcohol con los siguientes ingredientes {ingredients}";

			Console.WriteLine("We mixed the ingredientes");
		}

		public void Reset()
		{
			_preparedDrink = new PreparedDrink();
		}

		public void Rest(int time)
		{
			Thread.Sleep(time);
			Console.WriteLine("Ready to drink");
		}

		public void SetAlcohol(decimal alcohol)
		{
			_preparedDrink!.Alcohol = alcohol;
		}

		public void SetMilk(int milk)
		{
			_preparedDrink!.Milk = milk;
		}

		public void SetWater(int water)
		{
			_preparedDrink!.Water = water;
		}

		public PreparedDrink GetPreparedDrink() => _preparedDrink!;
	}
}
