using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;
using Programming.Core;
using Programming.Shapes;
using Timer = System.Timers.Timer;

namespace Programming.UI
{
    public partial class MainForm : Form
    {
        public static Color Color = Color.White;

        public static readonly Config Config = new Config();

        private readonly Trajectory _trajectory = new Trajectory();

        public static MovingFigureTrajectory MovingFigure =
            new MovingFigureTrajectory(Config.CharacteristicPoints);

        private Label AuthorLabel;
        private Button ColorSwitchButton;

        private Label ConfigLabel;
        private Panel ControlPanel;
        private Label FigureBreathingSpeedLabel;
        private TrackBar FigureBreathSpeed;
        private Label FigureMoveSpeedLabel;
        private TrackBar FigureSize;
        private Label FigureSizeLabel;
        private Button FigureSwitchButton;

        private Timer MovingPointTimer;
        private PictureBox PaintBox;

        private TrackBar TrajectorySize;
        private Label TrajectorySizeLabel;
        private TrackBar TrajectorySpeed;

        public MainForm()
        {
            InitializeComponent();
        }
        
        private void PaintBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color);

            _trajectory.Scale = TrajectorySize.Value / (double)(TrajectorySize.Maximum - TrajectorySize.Minimum);
            _trajectory.Draw(PaintBox, e);

            MovingFigure.Scale = TrajectorySize.Value / (double)(TrajectorySize.Maximum - TrajectorySize.Minimum);
            MovingFigure.FigureScale = FigureSize.Value / (double)(FigureSize.Maximum - FigureSize.Minimum);
            MovingFigure.FigureBreathSpeed = FigureBreathSpeed.Value / 100d;
            MovingFigure.PointSpeed = TrajectorySpeed.Value / 100d;
            MovingFigure.Draw(PaintBox, e);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            PaintBox.Invalidate();
        }

        private void TrajectorySize_Scroll(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void TrajectorySpeed_Scroll(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void MovingPointTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Invalidate();
        }

        private void FigureSize_Scroll(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void FigureBreathSpeed_Scroll(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void ColorSwitchButton_Click(object sender, EventArgs e)
        {
            var colorSwitchForm = new ColorSwitchForm();
            colorSwitchForm.Show();

            Invalidate();
        }

        private void FigureSwitchButton_Click(object sender, EventArgs e)
        {
            var figureSwitchForm = new FigureSwitchForm();
            figureSwitchForm.Show();

            Invalidate();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            TrajectorySize.Value = Config.TrajectorySize;
            TrajectorySpeed.Value = Config.FigureSpeed;
            FigureSize.Value = Config.FigureSize;
            FigureBreathSpeed.Value = Config.FigureBreathingSpeed;

            Color = Config.FieldColor;
            Trajectory.Color = Config.TrajectoryColor;
            MovingFigureTrajectory.Color = Config.FigureColor;

            MovingFigure.CharacteristicPoints = Config.CharacteristicPoints;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Config.TrajectorySize = TrajectorySize.Value;
            Config.FigureSpeed = TrajectorySpeed.Value;
            Config.FigureSize = FigureSize.Value;
            Config.FigureBreathingSpeed = FigureBreathSpeed.Value;

            Config.FieldColor = Color;
            Config.TrajectoryColor = Trajectory.Color;
            Config.FigureColor = MovingFigureTrajectory.Color;

            Config.CharacteristicPoints = MovingFigure.CharacteristicPoints;

            Config.SaveConfigToIni();
        }
    }
}