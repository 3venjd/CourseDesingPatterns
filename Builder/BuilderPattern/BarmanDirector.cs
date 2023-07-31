using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
	public class BarmanDirector
	{
		private IBuilder _builder;

        public BarmanDirector(IBuilder builder)
        {
            _builder = builder;
        }

        public void SetBuilder(IBuilder builder)
        {
            _builder = builder;
        }

        public void PrepareMargarita()
        {
			_builder.Reset();
			_builder.SetAlcohol(9);
			_builder.SetWater(30);
			_builder.AddIngredients("2 lemon");
			_builder.AddIngredients("Pinch of salt");
			_builder.AddIngredients("1/2 bowl of tequila");
			_builder.AddIngredients("3/4 bowl of orange licor");
			_builder.AddIngredients("4 ice");
			_builder.Mix();
			_builder.Rest(1000);
		}

		public void PreparePiñaColada()
		{
			_builder.Reset();
			_builder.SetAlcohol(20);
			_builder.SetWater(10);
			_builder.SetMilk(500);
			_builder.AddIngredients("1/2 bowl of ron");
			_builder.AddIngredients("1/2 coco cream");
			_builder.AddIngredients("3/4 bowl of pinneapple juice");
			_builder.Mix();
			_builder.Rest(2000);
		}

	}
}
