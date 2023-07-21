namespace Tools
{

    //sealed is use to denied inheritance
    public sealed class Log
    {
        private static Log _instance = null!;
        private string _path = "log.txt";
        private static object _protect = new object();

        public static Log GetInstance(string path)
        {
            //lock is to while a thread is working with the attribute _protect leave the others threads waiting, when the first thread ends, the instance is not null
            lock(_protect)
            {
                if (_instance == null)
                {
                    _instance = new Log(path);
                }
            }
            

            return _instance;
        }

        private Log(string path)
        {
            _path = path;
        }

        public void Save(string message)
        {
            File.AppendAllTextAsync(_path, message + Environment.NewLine);
        }
    }
}