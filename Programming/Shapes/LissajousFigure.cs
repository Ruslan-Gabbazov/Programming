using System;
using System.Drawing;
using Programming.Core;

namespace Programming.Shapes
{
    public class LissajousFigure
    {
        private readonly int _k;
        private readonly double _minAngle;
        private readonly int _pointCount;
        private readonly double _step;

        public LissajousFigure()
        {
            var settings = Settings.GetInstance();

            _k = settings.K;
            _minAngle = settings.MinAngle;
            _pointCount = settings.PointCount;
            _step = (settings.MaxAngle - settings.MinAngle) / _pointCount;

            Points = new Point[_pointCount];
        }

        public Point Center { get; set; }
        public int Radius { get; set; }

        private Point[] Points { get; }

        private Point GetPointValue(double fi, double scale)
        {
            return new Point
            {
                X = (int)(Center.X + scale * Radius * Math.Sin(fi + Math.PI / 2)),
                Y = (int)(Center.Y + scale * Radius * Math.Sin(_k * fi))
            };
        }

        public Point[] GetPoints(double scale)
        {
            var fi = _minAngle;

            for (var i = 0; i < _pointCount; i++)
            {
                Points[i] = GetPointValue(fi, scale);
                fi += _step;
            }

            return Points;
        }
    }
}