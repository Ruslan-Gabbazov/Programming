using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Core;

namespace Programming.Shapes
{
    public class MovingFigureTrajectory : MovingPointTrajectory
    {
        private Point[] CharacteristicPoints { get; set; }
        private Point[] AbsolutePoints { get; set; } = new Point[12 + 1];
        public double FigureScale { get; set; }

        public double FigureBreathSpeed { get; set; }
        private double _fi;


        public MovingFigureTrajectory(Point[] characteristicPoints = null)
        {
            CharacteristicPoints = characteristicPoints ?? FigureSettings.MovingFigureCharacteristicPoints;
        }

        private void SetAbsolutePoints(double fi)
        {
            for (var i = 0; i < CharacteristicPoints.Length; i++)
            {
                AbsolutePoints[i].X = (int)(FigureScale * CharacteristicPoints[i].X * Math.Cos(fi)) + MovingPoint.X;
                AbsolutePoints[i].Y = (int)(FigureScale * CharacteristicPoints[i].Y * Math.Cos(fi)) + MovingPoint.Y;
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

            e.Graphics.DrawLines(new Pen(Color.Green, 5), AbsolutePoints);
        }
    }
}