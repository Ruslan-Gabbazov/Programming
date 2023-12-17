using System.Drawing;
using System.Windows.Forms;

namespace Programming.Shapes
{
    public class Trajectory
    {
        private LissajousFigure Figure { get; } = new LissajousFigure();
        public double Scale { get; set; }


        public void Draw(PictureBox paintBox, PaintEventArgs e)
        {
            Figure.Center = new Point { X = paintBox.Width / 2, Y = paintBox.Height / 2 };
            Figure.Radius = paintBox.Width < paintBox.Height
                ? paintBox.Width / 2
                : paintBox.Height / 2;

            var points = Figure.GetPoints(Scale);

            e.Graphics.Clear(Color.White);
            e.Graphics.DrawPolygon(new Pen(Color.Black, 4), points);
        }
    }
}