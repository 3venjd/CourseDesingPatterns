using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
	public class PreparedDrink
	{
        public List<string>? Ingredients = new List<string> ();

		public int Milk;

		public int Water;

		public decimal Alcohol;

		public string? Result;

   //     public PreparedDrink(List<string> ingredients,
			//int milk,
			//int water,
			//decimal alchohol)
   //     {
			//Ingredients = ingredients;
			//Milk = milk;
			//Water = water;
			//Alcohol = alchohol;
			
   //     }

    }
}
