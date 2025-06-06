namespace DesignPatterns.Singleton
{
    public static class SingletonClient
    {
        public static void Run()
        {
            Logger.Instance.Log("This is a singleton logger message.");
        }
    }
}
