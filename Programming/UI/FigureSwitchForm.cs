using System;
using System.Windows.Forms;
using Programming.Core;
using Programming.Shapes;

namespace Programming.UI
{
    public partial class FigureSwitchForm : Form
    {
        public FigureSwitchForm()
        {
            InitializeComponent();

            FigureSwitchTextBoxForVertexCoordinates.Text =
                StringToFigureConverter.ConvertPointsToText(
                    MainForm.MovingFigure.CharacteristicPoints);
        }

        private void FigureSwitchFigureOkButton_Click(object sender, EventArgs e)
        {
            var characteristicPoints = StringToFigureConverter.ConvertTextToPoints(
                FigureSwitchTextBoxForVertexCoordinates.Text);
            MainForm.MovingFigure = new MovingFigureTrajectory(characteristicPoints);

            Close();
        }

        private void FigureSwitchFigurePreviousFigureButton_Click(object sender, EventArgs e)
        {
            var characteristicPoints = FigureSettings.MovingFigureCharacteristicPoints;
            MainForm.MovingFigure = new MovingFigureTrajectory(characteristicPoints);

            Close();
        }

        private void CopyFigureButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(FigureSwitchTextBoxForVertexCoordinates.Text);
        }

        private void PasteFigureButton_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
                FigureSwitchTextBoxForVertexCoordinates.Text = Clipboard.GetText();
        }
    }
}