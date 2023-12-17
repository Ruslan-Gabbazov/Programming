using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Programming.Shapes;

namespace Programming.UI
{
    public partial class MainForm : Form
    {
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
        private System.Windows.Forms.PictureBox PaintBox;

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
            this.TrajectorySize = new System.Windows.Forms.TrackBar();
            this.TrajectorySizeLabel = new System.Windows.Forms.Label();
            this.TrajectorySpeed = new System.Windows.Forms.TrackBar();
            this.FigureMoveSpeedLabel = new System.Windows.Forms.Label();
            this.FigureSizeLabel = new System.Windows.Forms.Label();
            this.FigureSize = new System.Windows.Forms.TrackBar();
            this.FigureBreathingSpeedLabel = new System.Windows.Forms.Label();
            this.FigureBreathSpeed = new System.Windows.Forms.TrackBar();
            this.ColorSwichButton = new System.Windows.Forms.Button();
            this.FigureSwichButton = new System.Windows.Forms.Button();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.ConfigLabel = new System.Windows.Forms.Label();
            this.PaintBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TrajectorySize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrajectorySpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FigureSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FigureBreathSpeed)).BeginInit();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaintBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TrajectorySize
            // 
            this.TrajectorySize.Location = new System.Drawing.Point(25, 100);
            this.TrajectorySize.Margin = new System.Windows.Forms.Padding(4);
            this.TrajectorySize.Maximum = 20;
            this.TrajectorySize.Name = "TrajectorySize";
            this.TrajectorySize.Size = new System.Drawing.Size(350, 56);
            this.TrajectorySize.TabIndex = 0;
            this.TrajectorySize.Value = 10;
            this.TrajectorySize.Scroll += new System.EventHandler(this.TrajectorySize_Scroll);
            // 
            // TrajectorySizeLabel
            // 
            this.TrajectorySizeLabel.AutoSize = true;
            this.TrajectorySizeLabel.Location = new System.Drawing.Point(130, 64);
            this.TrajectorySizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TrajectorySizeLabel.Name = "TrajectorySizeLabel";
            this.TrajectorySizeLabel.Size = new System.Drawing.Size(138, 17);
            this.TrajectorySizeLabel.TabIndex = 1;
            this.TrajectorySizeLabel.Text = "Размер траектории";
            // 
            // TrajectorySpeed
            // 
            this.TrajectorySpeed.Location = new System.Drawing.Point(25, 200);
            this.TrajectorySpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TrajectorySpeed.Maximum = 20;
            this.TrajectorySpeed.Name = "TrajectorySpeed";
            this.TrajectorySpeed.Size = new System.Drawing.Size(350, 56);
            this.TrajectorySpeed.TabIndex = 2;
            this.TrajectorySpeed.Value = 1;
            // 
            // FigureMoveSpeedLabel
            // 
            this.FigureMoveSpeedLabel.AutoSize = true;
            this.FigureMoveSpeedLabel.Location = new System.Drawing.Point(40, 160);
            this.FigureMoveSpeedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FigureMoveSpeedLabel.Name = "FigureMoveSpeedLabel";
            this.FigureMoveSpeedLabel.Size = new System.Drawing.Size(319, 17);
            this.FigureMoveSpeedLabel.TabIndex = 3;
            this.FigureMoveSpeedLabel.Text = "Скорость перемещения фигуры по траектории";
            // 
            // FigureSizeLabel
            // 
            this.FigureSizeLabel.AutoSize = true;
            this.FigureSizeLabel.Location = new System.Drawing.Point(143, 258);
            this.FigureSizeLabel.Name = "FigureSizeLabel";
            this.FigureSizeLabel.Size = new System.Drawing.Size(110, 17);
            this.FigureSizeLabel.TabIndex = 4;
            this.FigureSizeLabel.Text = "Размер фигуры";
            // 
            // FigureSize
            // 
            this.FigureSize.Location = new System.Drawing.Point(25, 300);
            this.FigureSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FigureSize.Name = "FigureSize";
            this.FigureSize.Size = new System.Drawing.Size(350, 56);
            this.FigureSize.TabIndex = 5;
            this.FigureSize.Value = 5;
            // 
            // FigureBreathingSpeedLabel
            // 
            this.FigureBreathingSpeedLabel.AutoSize = true;
            this.FigureBreathingSpeedLabel.Location = new System.Drawing.Point(110, 358);
            this.FigureBreathingSpeedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FigureBreathingSpeedLabel.Name = "FigureBreathingSpeedLabel";
            this.FigureBreathingSpeedLabel.Size = new System.Drawing.Size(182, 17);
            this.FigureBreathingSpeedLabel.TabIndex = 6;
            this.FigureBreathingSpeedLabel.Text = "Скорость дыхания фигуры";
            // 
            // FigureBreathSpeed
            // 
            this.FigureBreathSpeed.Location = new System.Drawing.Point(25, 400);
            this.FigureBreathSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.FigureBreathSpeed.Name = "FigureBreathSpeed";
            this.FigureBreathSpeed.Size = new System.Drawing.Size(350, 56);
            this.FigureBreathSpeed.TabIndex = 7;
            this.FigureBreathSpeed.Value = 1;
            // 
            // ColorSwichButton
            // 
            this.ColorSwichButton.Location = new System.Drawing.Point(99, 476);
            this.ColorSwichButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ColorSwichButton.Name = "ColorSwichButton";
            this.ColorSwichButton.Size = new System.Drawing.Size(210, 25);
            this.ColorSwichButton.TabIndex = 8;
            this.ColorSwichButton.Text = "Изменить цвета";
            this.ColorSwichButton.UseVisualStyleBackColor = true;
            // 
            // FigureSwichButton
            // 
            this.FigureSwichButton.Location = new System.Drawing.Point(99, 516);
            this.FigureSwichButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FigureSwichButton.Name = "FigureSwichButton";
            this.FigureSwichButton.Size = new System.Drawing.Size(210, 26);
            this.FigureSwichButton.TabIndex = 9;
            this.FigureSwichButton.Text = "Изменить фигуру";
            this.FigureSwichButton.UseVisualStyleBackColor = true;
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.AuthorLabel);
            this.ControlPanel.Controls.Add(this.ConfigLabel);
            this.ControlPanel.Controls.Add(this.FigureSwichButton);
            this.ControlPanel.Controls.Add(this.ColorSwichButton);
            this.ControlPanel.Controls.Add(this.FigureBreathSpeed);
            this.ControlPanel.Controls.Add(this.FigureBreathingSpeedLabel);
            this.ControlPanel.Controls.Add(this.FigureSize);
            this.ControlPanel.Controls.Add(this.FigureSizeLabel);
            this.ControlPanel.Controls.Add(this.FigureMoveSpeedLabel);
            this.ControlPanel.Controls.Add(this.TrajectorySpeed);
            this.ControlPanel.Controls.Add(this.TrajectorySizeLabel);
            this.ControlPanel.Controls.Add(this.TrajectorySize);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlPanel.Location = new System.Drawing.Point(782, 0);
            this.ControlPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(400, 628);
            this.ControlPanel.TabIndex = 2;
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorLabel.Location = new System.Drawing.Point(224, 579);
            this.AuthorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(151, 40);
            this.AuthorLabel.TabIndex = 11;
            this.AuthorLabel.Text = "Габбазов Руслан\r\nГруппа 4197";
            // 
            // ConfigLabel
            // 
            this.ConfigLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ConfigLabel.AutoSize = true;
            this.ConfigLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfigLabel.Location = new System.Drawing.Point(124, 21);
            this.ConfigLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ConfigLabel.Name = "ConfigLabel";
            this.ConfigLabel.Size = new System.Drawing.Size(144, 20);
            this.ConfigLabel.TabIndex = 10;
            this.ConfigLabel.Text = "Конфигурация";
            // 
            // PaintBox
            // 
            this.PaintBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.PaintBox.BackColor = System.Drawing.Color.FloralWhite;
            this.PaintBox.Location = new System.Drawing.Point(0, 0);
            this.PaintBox.Margin = new System.Windows.Forms.Padding(4);
            this.PaintBox.Name = "PaintBox";
            this.PaintBox.Size = new System.Drawing.Size(774, 628);
            this.PaintBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PaintBox.TabIndex = 3;
            this.PaintBox.TabStop = false;
            this.PaintBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintBox_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1182, 628);
            this.Controls.Add(this.PaintBox);
            this.Controls.Add(this.ControlPanel);
            this.MinimumSize = new System.Drawing.Size(1200, 675);
            this.Name = "MainForm";
            this.Text = "Programming";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.TrajectorySize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrajectorySpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FigureSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FigureBreathSpeed)).EndInit();
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaintBox)).EndInit();
            this.ResumeLayout(false);
        }

        private void PaintBox_Paint(object sender, PaintEventArgs e)
        {
            _trajectory.Scale = TrajectorySize.Value / (double)(TrajectorySize.Maximum - TrajectorySize.Minimum);
            _trajectory.Draw(PaintBox, e);
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
    }
}