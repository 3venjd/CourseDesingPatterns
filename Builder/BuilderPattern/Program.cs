using BuilderPattern;

var builder = new PerparedAlcoholicDrinkConcreteBuilder();

var barmanDirector = new BarmanDirector(builder);

//barmanDirector.PrepareMargarita();

barmanDirector.PreparePiñaColada();

var preparedDrink = builder.GetPreparedDrink();

Console.WriteLine(preparedDrink.Result);