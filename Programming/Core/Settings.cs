using System;

namespace Programming.Core
{
    public class Settings
    {
        private static Settings _instance;
        
        public readonly int K = 3;
        public readonly double MaxAngle = Math.PI;
        public readonly double MinAngle = 0;
        public readonly int PointCount = 1000;

        public static Settings GetInstance()
        {
            return _instance ?? (_instance = new Settings());
        }
    }
}