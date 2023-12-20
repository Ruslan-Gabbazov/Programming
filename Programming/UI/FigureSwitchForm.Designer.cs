using System.ComponentModel;

namespace Programming.UI
{
    partial class FigureSwitchForm
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
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.PasteFigureButton = new System.Windows.Forms.Button();
            this.CopyFigureButton = new System.Windows.Forms.Button();
            this.FigureSwitchFigurePreviousFigureButton = new System.Windows.Forms.Button();
            this.FigureSwitchFigureOkButton = new System.Windows.Forms.Button();
            this.FigureSwitchCoordinatesOfVertexLabel = new System.Windows.Forms.Label();
            this.FigureTextSwitchCharacteristicPoints = new System.Windows.Forms.RichTextBox();
            this.ControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.PasteFigureButton);
            this.ControlPanel.Controls.Add(this.CopyFigureButton);
            this.ControlPanel.Controls.Add(this.FigureSwitchFigurePreviousFigureButton);
            this.ControlPanel.Controls.Add(this.FigureSwitchFigureOkButton);
            this.ControlPanel.Controls.Add(this.FigureSwitchCoordinatesOfVertexLabel);
            this.ControlPanel.Controls.Add(this.FigureTextSwitchCharacteristicPoints);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(401, 402);
            this.ControlPanel.TabIndex = 1;
            // 
            // PasteFigureButton
            // 
            this.PasteFigureButton.Location = new System.Drawing.Point(204, 341);
            this.PasteFigureButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasteFigureButton.Name = "PasteFigureButton";
            this.PasteFigureButton.Size = new System.Drawing.Size(170, 33);
            this.PasteFigureButton.TabIndex = 7;
            this.PasteFigureButton.Text = "Вставить";
            this.PasteFigureButton.UseVisualStyleBackColor = true;
            this.PasteFigureButton.Click += new System.EventHandler(this.PasteFigureButton_Click);
            // 
            // CopyFigureButton
            // 
            this.CopyFigureButton.Location = new System.Drawing.Point(24, 341);
            this.CopyFigureButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CopyFigureButton.Name = "CopyFigureButton";
            this.CopyFigureButton.Size = new System.Drawing.Size(170, 33);
            this.CopyFigureButton.TabIndex = 6;
            this.CopyFigureButton.Text = "Копировать";
            this.CopyFigureButton.UseVisualStyleBackColor = true;
            this.CopyFigureButton.Click += new System.EventHandler(this.CopyFigureButton_Click);
            // 
            // FigureSwitchFigurePreviousFigureButton
            // 
            this.FigureSwitchFigurePreviousFigureButton.Location = new System.Drawing.Point(204, 304);
            this.FigureSwitchFigurePreviousFigureButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FigureSwitchFigurePreviousFigureButton.Name = "FigureSwitchFigurePreviousFigureButton";
            this.FigureSwitchFigurePreviousFigureButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FigureSwitchFigurePreviousFigureButton.Size = new System.Drawing.Size(170, 33);
            this.FigureSwitchFigurePreviousFigureButton.TabIndex = 5;
            this.FigureSwitchFigurePreviousFigureButton.Text = "Сбросить";
            this.FigureSwitchFigurePreviousFigureButton.UseVisualStyleBackColor = true;
            this.FigureSwitchFigurePreviousFigureButton.Click += new System.EventHandler(this.FigureSwitchFigurePreviousFigureButton_Click);
            // 
            // FigureSwitchFigureOkButton
            // 
            this.FigureSwitchFigureOkButton.Location = new System.Drawing.Point(24, 304);
            this.FigureSwitchFigureOkButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FigureSwitchFigureOkButton.Name = "FigureSwitchFigureOkButton";
            this.FigureSwitchFigureOkButton.Size = new System.Drawing.Size(170, 33);
            this.FigureSwitchFigureOkButton.TabIndex = 4;
            this.FigureSwitchFigureOkButton.Text = "Изменить";
            this.FigureSwitchFigureOkButton.UseVisualStyleBackColor = true;
            this.FigureSwitchFigureOkButton.Click += new System.EventHandler(this.FigureSwitchFigureOkButton_Click);
            // 
            // FigureSwitchCoordinatesOfVertexLabel
            // 
            this.FigureSwitchCoordinatesOfVertexLabel.AutoSize = true;
            this.FigureSwitchCoordinatesOfVertexLabel.Location = new System.Drawing.Point(24, 27);
            this.FigureSwitchCoordinatesOfVertexLabel.Name = "FigureSwitchCoordinatesOfVertexLabel";
            this.FigureSwitchCoordinatesOfVertexLabel.Size = new System.Drawing.Size(144, 17);
            this.FigureSwitchCoordinatesOfVertexLabel.TabIndex = 3;
            this.FigureSwitchCoordinatesOfVertexLabel.Text = "Координаты вершин";
            // 
            // FigureTextSwitchCharacteristicPoints
            // 
            this.FigureTextSwitchCharacteristicPoints.Location = new System.Drawing.Point(24, 46);
            this.FigureTextSwitchCharacteristicPoints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FigureTextSwitchCharacteristicPoints.Name = "FigureTextSwitchCharacteristicPoints";
            this.FigureTextSwitchCharacteristicPoints.Size = new System.Drawing.Size(350, 230);
            this.FigureTextSwitchCharacteristicPoints.TabIndex = 2;
            this.FigureTextSwitchCharacteristicPoints.Text = "-40; -40\n-40; -20\n-20; -20\n-20; 20\n-40; 20\n-40; 40\n40; 40\n40; 20\n20; 20\n20; -20\n4" + "0; -20\n40; -40 ";
            // 
            // FigureSwitchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 402);
            this.Controls.Add(this.ControlPanel);
            this.Name = "FigureSwitchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FigureSwitchForm";
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button CopyFigureButton;
        private System.Windows.Forms.Button PasteFigureButton;

        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button FigureSwitchFigurePreviousFigureButton;
        private System.Windows.Forms.Button FigureSwitchFigureOkButton;
        private System.Windows.Forms.Label FigureSwitchCoordinatesOfVertexLabel;
        private System.Windows.Forms.RichTextBox FigureTextSwitchCharacteristicPoints;

        #endregion
    }
}