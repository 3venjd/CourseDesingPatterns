using StatePattern;

var customerContext = new CustomerContext();

Console.WriteLine(customerContext.GetState() + " at " + DateTime.Now);

customerContext.Request(100);
Console.WriteLine(customerContext.GetState() + " at " + DateTime.Now);

customerContext.Request(50);
Console.WriteLine(customerContext.GetState() + " at " + DateTime.Now);


customerContext.Request(100);
Console.WriteLine(customerContext.GetState() + " at " + DateTime.Now);

customerContext.Request(50);
Console.WriteLine(customerContext.GetState() + " at " + DateTime.Now);

customerContext.Request(1);
Console.WriteLine(customerContext.GetState() + " at " + DateTime.Now);