using System;
using System.Drawing;

namespace Programming.Core
{
    public class FigureSettings
    {
        public const int K = 3;
        public const double MaxAngle = Math.PI;
        public const double MinAngle = 0;
        public const int PointCount = 1000;

        public static readonly Point[] MovingFigureCharacteristicPoints =
        {
            new Point { X = -40, Y = -40 },
            new Point { X = -40, Y = -20 },
            new Point { X = -20, Y = -20 },
            new Point { X = -20, Y = 20 },
            new Point { X = -40, Y = 20 },
            new Point { X = -40, Y = 40 },
            new Point { X = 40, Y = 40 },
            new Point { X = 40, Y = 20 },
            new Point { X = 20, Y = 20 },
            new Point { X = 20, Y = -20 },
            new Point { X = 40, Y = -20 },
            new Point { X = 40, Y = -40 }
        };
    }
}