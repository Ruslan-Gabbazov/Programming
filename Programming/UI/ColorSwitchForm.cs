using System;
using System.Windows.Forms;
using Programming.Core;
using Programming.Shapes;

namespace Programming.UI
{
    public partial class ColorSwitchForm : Form
    {
        public ColorSwitchForm()
        {
            InitializeComponent();
        }

        private void ColorSwitchTrajectoryButton_Click(object sender, EventArgs e)
        {
            var trajectoryColorDialog = new ColorDialog();
            trajectoryColorDialog.FullOpen = true;
            trajectoryColorDialog.Color = Trajectory.Color;

            if (trajectoryColorDialog.ShowDialog() == DialogResult.OK)
                Trajectory.Color = trajectoryColorDialog.Color;
        }

        private void ColorSwitchFigureButton_Click(object sender, EventArgs e)
        {
            var figureColorDialog = new ColorDialog();
            figureColorDialog.FullOpen = true;
            figureColorDialog.Color = MovingFigureTrajectory.Color;

            if (figureColorDialog.ShowDialog() == DialogResult.OK)
                MovingFigureTrajectory.Color = figureColorDialog.Color;
        }

        private void ColorSwitchFieldButton_Click(object sender, EventArgs e)
        {
            var fieldColorDialog = new ColorDialog();
            fieldColorDialog.FullOpen = true;
            fieldColorDialog.Color = MainForm.Color;

            if (fieldColorDialog.ShowDialog() == DialogResult.OK)
                MainForm.Color = fieldColorDialog.Color;
        }

        private void ResetColorsButton_Click(object sender, EventArgs e)
        {
            MainForm.Color = DefaultSettings.FieldColor;
            Trajectory.Color = DefaultSettings.TrajectoryColor;
            MovingFigureTrajectory.Color = DefaultSettings.FigureColor;
        }
    }
}