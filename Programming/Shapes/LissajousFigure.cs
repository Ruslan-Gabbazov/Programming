using System;
using System.Drawing;
using Programming.Core;

namespace Programming.Shapes
{
    public class LissajousFigure
    {
        private readonly int _k;
        private readonly double _maxAngle;
        private readonly double _minAngle;
        private readonly int _pointCount;
        private readonly double _step;
        private double _fi;

        public LissajousFigure()
        {
            _k = DefaultSettings.K;
            _fi = DefaultSettings.MinAngle;
            _minAngle = DefaultSettings.MinAngle;
            _maxAngle = DefaultSettings.MaxAngle;
            _pointCount = DefaultSettings.PointCount;
            _step = (DefaultSettings.MaxAngle - DefaultSettings.MinAngle) / _pointCount;

            Points = new Point[_pointCount];
        }

        public Point Center { get; set; }
        public int Radius { get; set; }
        public double Scale { get; set; }

        private Point[] Points { get; }

        private Point GetPointValue(double fi)
        {
            return new Point
            {
                X = (int)(Center.X + Scale * Radius * Math.Sin(fi + Math.PI / 2)),
                Y = (int)(Center.Y + Scale * Radius * Math.Sin(_k * fi))
            };
        }

        public Point[] GetPoints()
        {
            var fi = _minAngle;

            for (var i = 0; i < _pointCount; i++)
            {
                Points[i] = GetPointValue(fi);
                fi += _step;
            }

            return Points;
        }

        public Point GetNextPoint(double step)
        {
            _fi += step;

            if (_fi < _maxAngle)
                return GetPointValue(_fi);
            if (_fi < 2 * _maxAngle)
                return new Point
                {
                    X = (int)(Center.X + Scale * Radius * Math.Sin(_fi + Math.PI / 2)),
                    Y = (int)(Center.Y + Scale * Radius * Math.Sin(_k * 2 * _maxAngle))
                };
            _fi = _minAngle;
            return GetPointValue(_fi);
        }
    }
}