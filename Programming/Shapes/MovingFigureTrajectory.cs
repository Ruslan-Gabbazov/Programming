using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Core;

namespace Programming.Shapes
{
    public class MovingFigureTrajectory : MovingPointTrajectory
    {
        public Point[] CharacteristicPoints { get; set; }
        private Point[] AbsolutePoints { get; set; }
        public double FigureScale { get; set; }

        public double FigureBreathSpeed { get; set; }
        private double _fi;

        public new static Color Color = Color.Green;


        public MovingFigureTrajectory(Point[] characteristicPoints = null)
        {
            CharacteristicPoints = characteristicPoints ?? DefaultSettings.MovingFigureCharacteristicPoints;
            AbsolutePoints = new Point[CharacteristicPoints.Length + 1];
        }

        private void SetAbsolutePoints(double fi)
        {
            for (var i = 0; i < CharacteristicPoints.Length; i++)
            {
                AbsolutePoints[i].X = (int)(FigureScale * CharacteristicPoints[i].X * Math.Abs(Math.Cos(fi))) +
                                      MovingPoint.X;
                AbsolutePoints[i].Y = (int)(FigureScale * CharacteristicPoints[i].Y * Math.Abs(Math.Cos(fi))) +
                                      MovingPoint.Y;
            }

            AbsolutePoints[AbsolutePoints.Length - 1] = AbsolutePoints[0];
        }

        private void Breathe()
        {
            _fi += FigureBreathSpeed;

            SetAbsolutePoints(_fi);
        }

        public new void Draw(PictureBox paintBox, PaintEventArgs e)
        {
            SetFigure(paintBox);

            MovingPoint = Figure.GetNextPoint(PointSpeed);
            Breathe();

            e.Graphics.DrawLines(new Pen(Color, 5), AbsolutePoints);
        }
    }
}