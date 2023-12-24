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

        private System.Windows.Forms.Label AuthorLabel;

        private Label ConfigLabel;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.PictureBox PaintBox;

        private TrackBar TrajectorySize;
        private Label TrajectorySizeLabel;

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
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.ConfigLabel = new System.Windows.Forms.Label();
            this.PaintBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TrajectorySize)).BeginInit();
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
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.AuthorLabel);
            this.ControlPanel.Controls.Add(this.ConfigLabel);
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