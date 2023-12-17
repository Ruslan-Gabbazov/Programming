using System.Drawing;
using System.Windows.Forms;

namespace Programming.Shapes
{
    public class MovingPointTrajectory : Trajectory
    {
        public double PointSpeed { get; set; }

        private Point MovingPoint { get; set; }


        public new void Draw(PictureBox paintBox, PaintEventArgs e)
        {
            SetFigure(paintBox);

            MovingPoint = Figure.GetNextPoint(PointSpeed);

            e.Graphics.DrawEllipse(new Pen(Color.Red, 10), MovingPoint.X, MovingPoint.Y, 1, 1);
        }
    }
}