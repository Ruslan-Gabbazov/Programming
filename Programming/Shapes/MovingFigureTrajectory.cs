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


        public MovingFigureTrajectory(Point[] characteristicPoints = null)
        {
            CharacteristicPoints = characteristicPoints ?? FigureSettings.MovingFigureCharacteristicPoints;
        }

        private void SetAbsolutePoints()
        {
            for (var i = 0; i < CharacteristicPoints.Length; i++)
            {
                AbsolutePoints[i].X = (int)(FigureScale * CharacteristicPoints[i].X) + MovingPoint.X;
                AbsolutePoints[i].Y = (int)(FigureScale * CharacteristicPoints[i].Y) + MovingPoint.Y;
            }

            AbsolutePoints[AbsolutePoints.Length - 1] = AbsolutePoints[0];
        }

        public new void Draw(PictureBox paintBox, PaintEventArgs e)
        {
            SetFigure(paintBox);

            MovingPoint = Figure.GetNextPoint(PointSpeed);
            SetAbsolutePoints();

            e.Graphics.DrawLines(new Pen(Color.Green, 5), AbsolutePoints);
        }
    }
}