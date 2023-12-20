using System;
using System.Drawing;

namespace Programming.Core
{
    public static class DefaultSettings
    {
        public const int K = 3;
        public const double MaxAngle = Math.PI;
        public const double MinAngle = 0;
        public const int PointCount = 1000;

        public static Color TrajectoryColor = Color.Black;
        public static Color FigureColor = Color.Green;
        public static Color FieldColor = Color.White;

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