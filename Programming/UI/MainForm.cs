using System;
using System.ComponentModel;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;
using Programming.Shapes;
using Timer = System.Timers.Timer;

namespace Programming.UI
{
    public partial class MainForm : Form
    {
        private readonly MovingPointTrajectory _movingPoint = new MovingPointTrajectory();
        private readonly MovingFigureTrajectory _movingFigure = new MovingFigureTrajectory();
        private readonly Trajectory _trajectory = new Trajectory();

        private Label AuthorLabel;
        private Button ColorSwichButton;

        private Label ConfigLabel;
        private Panel ControlPanel;
        private Label FigureBreathingSpeedLabel;
        private TrackBar FigureBreathSpeed;
        private Label FigureMoveSpeedLabel;
        private TrackBar FigureSize;
        private Label FigureSizeLabel;
        private Button FigureSwichButton;

        private Timer MovingPointTimer;
        private PictureBox PaintBox;

        private TrackBar TrajectorySize;
        private Label TrajectorySizeLabel;
        private TrackBar TrajectorySpeed;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TrajectorySize = new TrackBar();
            TrajectorySizeLabel = new Label();
            TrajectorySpeed = new TrackBar();
            FigureMoveSpeedLabel = new Label();
            FigureSizeLabel = new Label();
            FigureSize = new TrackBar();
            FigureBreathingSpeedLabel = new Label();
            FigureBreathSpeed = new TrackBar();
            ColorSwichButton = new Button();
            FigureSwichButton = new Button();
            ControlPanel = new Panel();
            AuthorLabel = new Label();
            ConfigLabel = new Label();
            PaintBox = new PictureBox();
            MovingPointTimer = new Timer();
            ((ISupportInitialize)TrajectorySize).BeginInit();
            ((ISupportInitialize)TrajectorySpeed).BeginInit();
            ((ISupportInitialize)FigureSize).BeginInit();
            ((ISupportInitialize)FigureBreathSpeed).BeginInit();
            ControlPanel.SuspendLayout();
            ((ISupportInitialize)PaintBox).BeginInit();
            ((ISupportInitialize)MovingPointTimer).BeginInit();
            SuspendLayout();
            // 
            // TrajectorySize
            // 
            TrajectorySize.Location = new Point(25, 100);
            TrajectorySize.Margin = new Padding(4);
            TrajectorySize.Maximum = 20;
            TrajectorySize.Name = "TrajectorySize";
            TrajectorySize.Size = new Size(350, 56);
            TrajectorySize.TabIndex = 0;
            TrajectorySize.Value = 10;
            TrajectorySize.Scroll += new EventHandler(TrajectorySize_Scroll);
            // 
            // TrajectorySizeLabel
            // 
            TrajectorySizeLabel.AutoSize = true;
            TrajectorySizeLabel.Location = new Point(130, 64);
            TrajectorySizeLabel.Margin = new Padding(4, 0, 4, 0);
            TrajectorySizeLabel.Name = "TrajectorySizeLabel";
            TrajectorySizeLabel.Size = new Size(138, 17);
            TrajectorySizeLabel.TabIndex = 1;
            TrajectorySizeLabel.Text = "Размер траектории";
            // 
            // TrajectorySpeed
            // 
            TrajectorySpeed.Location = new Point(25, 200);
            TrajectorySpeed.Margin = new Padding(3, 2, 3, 2);
            TrajectorySpeed.Maximum = 20;
            TrajectorySpeed.Name = "TrajectorySpeed";
            TrajectorySpeed.Size = new Size(350, 56);
            TrajectorySpeed.TabIndex = 2;
            TrajectorySpeed.Value = 10;
            TrajectorySpeed.Scroll += new EventHandler(TrajectorySpeed_Scroll);
            // 
            // FigureMoveSpeedLabel
            // 
            FigureMoveSpeedLabel.AutoSize = true;
            FigureMoveSpeedLabel.Location = new Point(40, 160);
            FigureMoveSpeedLabel.Margin = new Padding(4, 0, 4, 0);
            FigureMoveSpeedLabel.Name = "FigureMoveSpeedLabel";
            FigureMoveSpeedLabel.Size = new Size(319, 17);
            FigureMoveSpeedLabel.TabIndex = 3;
            FigureMoveSpeedLabel.Text = "Скорость перемещения фигуры по траектории";
            // 
            // FigureSizeLabel
            // 
            FigureSizeLabel.AutoSize = true;
            FigureSizeLabel.Location = new Point(143, 258);
            FigureSizeLabel.Name = "FigureSizeLabel";
            FigureSizeLabel.Size = new Size(110, 17);
            FigureSizeLabel.TabIndex = 4;
            FigureSizeLabel.Text = "Размер фигуры";
            // 
            // FigureSize
            // 
            FigureSize.Location = new Point(25, 300);
            FigureSize.Margin = new Padding(3, 2, 3, 2);
            FigureSize.Maximum = 20;
            FigureSize.Name = "FigureSize";
            FigureSize.Size = new Size(350, 56);
            FigureSize.TabIndex = 5;
            FigureSize.Value = 10;
            FigureSize.Scroll += new EventHandler(FigureSize_Scroll);
            // 
            // FigureBreathingSpeedLabel
            // 
            FigureBreathingSpeedLabel.AutoSize = true;
            FigureBreathingSpeedLabel.Location = new Point(110, 358);
            FigureBreathingSpeedLabel.Margin = new Padding(4, 0, 4, 0);
            FigureBreathingSpeedLabel.Name = "FigureBreathingSpeedLabel";
            FigureBreathingSpeedLabel.Size = new Size(182, 17);
            FigureBreathingSpeedLabel.TabIndex = 6;
            FigureBreathingSpeedLabel.Text = "Скорость дыхания фигуры";
            // 
            // FigureBreathSpeed
            // 
            FigureBreathSpeed.Location = new Point(25, 400);
            FigureBreathSpeed.Margin = new Padding(4);
            FigureBreathSpeed.Name = "FigureBreathSpeed";
            FigureBreathSpeed.Size = new Size(350, 56);
            FigureBreathSpeed.TabIndex = 7;
            FigureBreathSpeed.Value = 1;
            // 
            // ColorSwichButton
            // 
            ColorSwichButton.Location = new Point(99, 476);
            ColorSwichButton.Margin = new Padding(3, 2, 3, 2);
            ColorSwichButton.Name = "ColorSwichButton";
            ColorSwichButton.Size = new Size(210, 25);
            ColorSwichButton.TabIndex = 8;
            ColorSwichButton.Text = "Изменить цвета";
            ColorSwichButton.UseVisualStyleBackColor = true;
            // 
            // FigureSwichButton
            // 
            FigureSwichButton.Location = new Point(99, 516);
            FigureSwichButton.Margin = new Padding(3, 2, 3, 2);
            FigureSwichButton.Name = "FigureSwichButton";
            FigureSwichButton.Size = new Size(210, 26);
            FigureSwichButton.TabIndex = 9;
            FigureSwichButton.Text = "Изменить фигуру";
            FigureSwichButton.UseVisualStyleBackColor = true;
            // 
            // ControlPanel
            // 
            ControlPanel.Controls.Add(AuthorLabel);
            ControlPanel.Controls.Add(ConfigLabel);
            ControlPanel.Controls.Add(FigureSwichButton);
            ControlPanel.Controls.Add(ColorSwichButton);
            ControlPanel.Controls.Add(FigureBreathSpeed);
            ControlPanel.Controls.Add(FigureBreathingSpeedLabel);
            ControlPanel.Controls.Add(FigureSize);
            ControlPanel.Controls.Add(FigureSizeLabel);
            ControlPanel.Controls.Add(FigureMoveSpeedLabel);
            ControlPanel.Controls.Add(TrajectorySpeed);
            ControlPanel.Controls.Add(TrajectorySizeLabel);
            ControlPanel.Controls.Add(TrajectorySize);
            ControlPanel.Dock = DockStyle.Right;
            ControlPanel.Location = new Point(782, 0);
            ControlPanel.Margin = new Padding(4);
            ControlPanel.Name = "ControlPanel";
            ControlPanel.Size = new Size(400, 628);
            ControlPanel.TabIndex = 2;
            // 
            // AuthorLabel
            // 
            AuthorLabel.Anchor = (AnchorStyles)(AnchorStyles.Bottom | AnchorStyles.Right);
            AuthorLabel.AutoSize = true;
            AuthorLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic, GraphicsUnit.Point, (byte)204);
            AuthorLabel.Location = new Point(224, 579);
            AuthorLabel.Margin = new Padding(4, 0, 4, 0);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(151, 40);
            AuthorLabel.TabIndex = 11;
            AuthorLabel.Text = "Габбазов Руслан\r\nГруппа 4197";
            // 
            // ConfigLabel
            // 
            ConfigLabel.Anchor = AnchorStyles.Top;
            ConfigLabel.AutoSize = true;
            ConfigLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, (byte)204);
            ConfigLabel.Location = new Point(124, 21);
            ConfigLabel.Margin = new Padding(4, 0, 4, 0);
            ConfigLabel.Name = "ConfigLabel";
            ConfigLabel.Size = new Size(144, 20);
            ConfigLabel.TabIndex = 10;
            ConfigLabel.Text = "Конфигурация";
            // 
            // PaintBox
            // 
            PaintBox.Anchor =
                (AnchorStyles)(AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            PaintBox.BackColor = Color.FloralWhite;
            PaintBox.Location = new Point(0, 0);
            PaintBox.Margin = new Padding(4);
            PaintBox.Name = "PaintBox";
            PaintBox.Size = new Size(774, 628);
            PaintBox.SizeMode = PictureBoxSizeMode.CenterImage;
            PaintBox.TabIndex = 3;
            PaintBox.TabStop = false;
            PaintBox.Paint += new PaintEventHandler(PaintBox_Paint);
            // 
            // MovingPointTimer
            // 
            MovingPointTimer.Enabled = true;
            MovingPointTimer.Interval = 40D;
            MovingPointTimer.SynchronizingObject = this;
            MovingPointTimer.Elapsed += new ElapsedEventHandler(MovingPointTimer_Elapsed);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1182, 628);
            Controls.Add(PaintBox);
            Controls.Add(ControlPanel);
            MinimumSize = new Size(1200, 675);
            Name = "MainForm";
            Text = "Programming";
            Paint += new PaintEventHandler(MainForm_Paint);
            Resize += new EventHandler(MainForm_Resize);
            ((ISupportInitialize)TrajectorySize).EndInit();
            ((ISupportInitialize)TrajectorySpeed).EndInit();
            ((ISupportInitialize)FigureSize).EndInit();
            ((ISupportInitialize)FigureBreathSpeed).EndInit();
            ControlPanel.ResumeLayout(false);
            ControlPanel.PerformLayout();
            ((ISupportInitialize)PaintBox).EndInit();
            ((ISupportInitialize)MovingPointTimer).EndInit();
            ResumeLayout(false);
        }


        private void PaintBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            _trajectory.Scale = TrajectorySize.Value / (double)(TrajectorySize.Maximum - TrajectorySize.Minimum);
            _trajectory.Draw(PaintBox, e);

            _movingPoint.Scale = TrajectorySize.Value / (double)(TrajectorySize.Maximum - TrajectorySize.Minimum);
            _movingPoint.PointSpeed = TrajectorySpeed.Value / 100d;
            _movingPoint.Draw(PaintBox, e);

            _movingFigure.Scale = TrajectorySize.Value / (double)(TrajectorySize.Maximum - TrajectorySize.Minimum);
            _movingFigure.FigureScale = FigureSize.Value / (double)(FigureSize.Maximum - FigureSize.Minimum);
            _movingFigure.PointSpeed = TrajectorySpeed.Value / 100d;
            _movingFigure.Draw(PaintBox, e);
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
    }
}