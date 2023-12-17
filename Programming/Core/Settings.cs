namespace Programming.Core
{
    public class Settings
    {
        private static Settings _instance;

        public static Settings Instance => _instance ?? (_instance = new Settings());
    }
}