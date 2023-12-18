using System.Drawing;
using System.Windows.Forms;

namespace Programming.Shapes
{
    public class Trajectory
    {
        private protected LissajousFigure Figure { get; } = new LissajousFigure();
        public double Scale { get; set; }
        public static Color Color { get; set; } = Color.Black;

        private protected void SetFigure(Control paintBox)
        {
            Figure.Center = new Point { X = paintBox.Width / 2, Y = paintBox.Height / 2 };
            Figure.Radius = paintBox.Width < paintBox.Height
                ? paintBox.Width / 2
                : paintBox.Height / 2;
            Figure.Scale = Scale;
        }

        public void Draw(PictureBox paintBox, PaintEventArgs e)
        {
            SetFigure(paintBox);

            var points = Figure.GetPoints();

            e.Graphics.DrawPolygon(new Pen(Color, 4), points);
        }
    }
}