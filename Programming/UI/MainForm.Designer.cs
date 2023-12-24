using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace Programming.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
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
            ColorSwitchButton = new Button();
            FigureSwitchButton = new Button();
            ControlPanel = new Panel();
            AuthorLabel = new Label();
            ConfigLabel = new Label();
            PaintBox = new PictureBox();
            MovingPointTimer = new Timer();
            ((System.ComponentModel.ISupportInitialize)TrajectorySize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TrajectorySpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FigureSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FigureBreathSpeed).BeginInit();
            ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PaintBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MovingPointTimer).BeginInit();
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
            FigureBreathSpeed.Maximum = 20;
            FigureBreathSpeed.Name = "FigureBreathSpeed";
            FigureBreathSpeed.Size = new Size(350, 56);
            FigureBreathSpeed.TabIndex = 7;
            FigureBreathSpeed.Value = 10;
            FigureBreathSpeed.Scroll += new EventHandler(FigureBreathSpeed_Scroll);
            // 
            // ColorSwitchButton
            // 
            ColorSwitchButton.Location = new Point(99, 476);
            ColorSwitchButton.Margin = new Padding(3, 2, 3, 2);
            ColorSwitchButton.Name = "ColorSwitchButton";
            ColorSwitchButton.Size = new Size(210, 25);
            ColorSwitchButton.TabIndex = 8;
            ColorSwitchButton.Text = "Изменить цвета";
            ColorSwitchButton.UseVisualStyleBackColor = true;
            ColorSwitchButton.Click += new EventHandler(ColorSwitchButton_Click);
            // 
            // FigureSwitchButton
            // 
            FigureSwitchButton.Location = new Point(99, 516);
            FigureSwitchButton.Margin = new Padding(3, 2, 3, 2);
            FigureSwitchButton.Name = "FigureSwitchButton";
            FigureSwitchButton.Size = new Size(210, 26);
            FigureSwitchButton.TabIndex = 9;
            FigureSwitchButton.Text = "Изменить фигуру";
            FigureSwitchButton.UseVisualStyleBackColor = true;
            FigureSwitchButton.Click += new EventHandler(FigureSwitchButton_Click);
            // 
            // ControlPanel
            // 
            ControlPanel.Controls.Add(AuthorLabel);
            ControlPanel.Controls.Add(ConfigLabel);
            ControlPanel.Controls.Add(FigureSwitchButton);
            ControlPanel.Controls.Add(ColorSwitchButton);
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
            PaintBox.BackColor = Color.White;
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
            Load += new EventHandler(MainForm_Load);
            FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)TrajectorySize).EndInit();
            ((System.ComponentModel.ISupportInitialize)TrajectorySpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)FigureSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)FigureBreathSpeed).EndInit();
            ControlPanel.ResumeLayout(false);
            ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PaintBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)MovingPointTimer).EndInit();
            ResumeLayout(false);
        }

    }
}