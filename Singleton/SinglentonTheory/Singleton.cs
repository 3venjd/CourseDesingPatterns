namespace SingletonTheory
{
    // this use to create objects, this create only one existing object in our app that allows one conection
    public class Singleton
    {
        private readonly static Singleton _instance = new Singleton();

        public static Singleton Instance
        {
            get { return _instance; }
        }

        private Singleton()
        {

        }
    }
}
