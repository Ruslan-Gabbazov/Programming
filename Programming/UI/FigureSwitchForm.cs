using System;
using System.Windows.Forms;
using Programming.Core;
using Programming.Properties;
using Programming.Shapes;

namespace Programming.UI
{
    public partial class FigureSwitchForm : Form
    {
        public event EventHandler ClipboardCopied;
        public event EventHandler ClipboardPasted;
        public event EventHandler FigureSwitchFailed;

        public FigureSwitchForm()
        {
            InitializeComponent();

            ClipboardCopied += (sender, args) =>
                MessageBox.Show("Фигура скопирована!",
                    "Копирование фигуры в буфера обмена",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            ClipboardPasted += (sender, args) =>
                MessageBox.Show("Фигура вставлена!",
                    "Вставка фигуры из буфера обмена",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            FigureSwitchFailed += (sender, args) =>
                MessageBox.Show(Resources.FigureSwitchFailure.Replace("\\n", Environment.NewLine),
                    "Неверный формат фигуры",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            FigureTextSwitchCharacteristicPoints.Text =
                StringToFigureConverter.ConvertPointsToText(
                    MainForm.MovingFigure.CharacteristicPoints);
        }

        private void FigureSwitchFigureOkButton_Click(object sender, EventArgs e)
        {
            try
            {
                var characteristicPoints = StringToFigureConverter.ConvertTextToPoints(
                    FigureTextSwitchCharacteristicPoints.Text);
                MainForm.MovingFigure = new MovingFigureTrajectory(characteristicPoints);

                Close();
            }
            catch (FormatException)
            {
                FigureSwitchFailed?.Invoke(this, EventArgs.Empty);
            }
        }

        private void FigureSwitchFigurePreviousFigureButton_Click(object sender, EventArgs e)
        {
            var characteristicPoints = DefaultSettings.MovingFigureCharacteristicPoints;
            MainForm.MovingFigure = new MovingFigureTrajectory(characteristicPoints);

            Close();
        }

        private void CopyFigureButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(FigureTextSwitchCharacteristicPoints.Text);
            ClipboardCopied?.Invoke(this, EventArgs.Empty);
        }

        private void PasteFigureButton_Click(object sender, EventArgs e)
        {
            if (!Clipboard.ContainsText()) return;

            FigureTextSwitchCharacteristicPoints.Text = Clipboard.GetText();
            ClipboardPasted?.Invoke(this, EventArgs.Empty);
        }
    }
}