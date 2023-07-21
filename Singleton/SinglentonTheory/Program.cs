using SingletonTheory;

//we cant use "new" because the law of singlenton says only one singleton object by app
//var singleton =  Singleton.Instance;

var log = Log.Instance;

log.Save("a");
log.Save("b");

var a = Singleton.Instance;
var b = Singleton.Instance;

Console.WriteLine(a == b);