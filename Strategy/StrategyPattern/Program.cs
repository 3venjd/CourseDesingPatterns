using StrategyPattern;

var context = new Context(new CarStrategy());
context.Run();

context.Strategy= new MotorbikeStrategy();
context.Run();

context.Strategy = new BicycleStrategy();
context.Run();