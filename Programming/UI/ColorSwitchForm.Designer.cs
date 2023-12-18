using System.ComponentModel;

namespace Programming.UI
{
    partial class ColorSwitchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ColorSwitchFieldButton = new System.Windows.Forms.Button();
            this.ColorSwitchFigureButton = new System.Windows.Forms.Button();
            this.ColorSwitchTrajectoryButton = new System.Windows.Forms.Button();
            this.FieldColorLabel = new System.Windows.Forms.Label();
            this.FigureColorLabel = new System.Windows.Forms.Label();
            this.TrajectoryColorLabel = new System.Windows.Forms.Label();
            this.ColorSwitchTrajectoryDialog = new System.Windows.Forms.ColorDialog();
            this.ColorSwitchFigureDialog = new System.Windows.Forms.ColorDialog();
            this.ColorSwitchFieldDialog = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ColorSwitchFieldButton);
            this.panel1.Controls.Add(this.ColorSwitchFigureButton);
            this.panel1.Controls.Add(this.ColorSwitchTrajectoryButton);
            this.panel1.Controls.Add(this.FieldColorLabel);
            this.panel1.Controls.Add(this.FigureColorLabel);
            this.panel1.Controls.Add(this.TrajectoryColorLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 273);
            this.panel1.TabIndex = 1;
            // 
            // ColorSwitchFieldButton
            // 
            this.ColorSwitchFieldButton.Location = new System.Drawing.Point(30, 210);
            this.ColorSwitchFieldButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ColorSwitchFieldButton.Name = "ColorSwitchFieldButton";
            this.ColorSwitchFieldButton.Size = new System.Drawing.Size(159, 30);
            this.ColorSwitchFieldButton.TabIndex = 5;
            this.ColorSwitchFieldButton.Text = "Задать цвет";
            this.ColorSwitchFieldButton.UseVisualStyleBackColor = true;
            this.ColorSwitchFieldButton.Click += new System.EventHandler(this.ColorSwitchFieldButton_Click);
            // 
            // ColorSwitchFigureButton
            // 
            this.ColorSwitchFigureButton.Location = new System.Drawing.Point(30, 130);
            this.ColorSwitchFigureButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ColorSwitchFigureButton.Name = "ColorSwitchFigureButton";
            this.ColorSwitchFigureButton.Size = new System.Drawing.Size(159, 30);
            this.ColorSwitchFigureButton.TabIndex = 4;
            this.ColorSwitchFigureButton.Text = "Задать цвет";
            this.ColorSwitchFigureButton.UseVisualStyleBackColor = true;
            this.ColorSwitchFigureButton.Click += new System.EventHandler(this.ColorSwitchFigureButton_Click);
            // 
            // ColorSwitchTrajectoryButton
            // 
            this.ColorSwitchTrajectoryButton.Location = new System.Drawing.Point(30, 50);
            this.ColorSwitchTrajectoryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ColorSwitchTrajectoryButton.Name = "ColorSwitchTrajectoryButton";
            this.ColorSwitchTrajectoryButton.Size = new System.Drawing.Size(159, 30);
            this.ColorSwitchTrajectoryButton.TabIndex = 3;
            this.ColorSwitchTrajectoryButton.Text = "Задать цвет";
            this.ColorSwitchTrajectoryButton.UseVisualStyleBackColor = true;
            this.ColorSwitchTrajectoryButton.Click += new System.EventHandler(this.ColorSwitchTrajectoryButton_Click); 
            // 
            // FieldColorLabel
            // 
            this.FieldColorLabel.AutoSize = true;
            this.FieldColorLabel.Location = new System.Drawing.Point(30, 180);
            this.FieldColorLabel.Name = "FieldColorLabel";
            this.FieldColorLabel.Size = new System.Drawing.Size(81, 17);
            this.FieldColorLabel.TabIndex = 2;
            this.FieldColorLabel.Text = "Цвет поля:";
            // 
            // FigureColorLabel
            // 
            this.FigureColorLabel.AutoSize = true;
            this.FigureColorLabel.Location = new System.Drawing.Point(30, 100);
            this.FigureColorLabel.Name = "FigureColorLabel";
            this.FigureColorLabel.Size = new System.Drawing.Size(98, 17);
            this.FigureColorLabel.TabIndex = 1;
            this.FigureColorLabel.Text = "Цвет фигуры:";
            // 
            // TrajectoryColorLabel
            // 
            this.TrajectoryColorLabel.AutoSize = true;
            this.TrajectoryColorLabel.ForeColor = System.Drawing.Color.Black;
            this.TrajectoryColorLabel.Location = new System.Drawing.Point(30, 20);
            this.TrajectoryColorLabel.Name = "TrajectoryColorLabel";
            this.TrajectoryColorLabel.Size = new System.Drawing.Size(126, 17);
            this.TrajectoryColorLabel.TabIndex = 0;
            this.TrajectoryColorLabel.Text = "Цвет траектории:";
            // 
            // ColorSwitchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 273);
            this.Controls.Add(this.panel1);
            this.Name = "ColorSwitchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ColorDialog ColorSwitchTrajectoryDialog;
        private System.Windows.Forms.ColorDialog ColorSwitchFigureDialog;
        private System.Windows.Forms.ColorDialog ColorSwitchFieldDialog;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ColorSwitchFieldButton;
        private System.Windows.Forms.Button ColorSwitchFigureButton;
        private System.Windows.Forms.Button ColorSwitchTrajectoryButton;
        private System.Windows.Forms.Label FieldColorLabel;
        private System.Windows.Forms.Label FigureColorLabel;
        private System.Windows.Forms.Label TrajectoryColorLabel;

        #endregion
    }
}