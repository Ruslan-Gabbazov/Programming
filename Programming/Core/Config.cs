using System.Drawing;

namespace Programming.Core
{
    public class Config
    {
        private const string FileName = "config.ini";
        private readonly IniFileManager _fileManager = new IniFileManager(FileName);

        public int TrajectorySize = 10;
        public int FigureSize = 10;
        public int FigureSpeed = 10;
        public int FigureBreathingSpeed = 10;

        public Color TrajectoryColor = Color.Black;
        public Color FigureColor = Color.Green;
        public Color FieldColor = Color.White;

        public Point[] CharacteristicPoints = DefaultSettings.MovingFigureCharacteristicPoints;

        public enum Sections
        {
            WorkSpace,
            Trajectory,
            Figure
        }

        public Config()
        {
            LoadConfigFromIni();
        }

        public void SaveConfigToIni()
        {
            _fileManager.WriteIniFile(Sections.WorkSpace, "FieldColor", FieldColor.Name);

            _fileManager.WriteIniFile(Sections.Trajectory, "TrajectorySize", TrajectorySize);
            _fileManager.WriteIniFile(Sections.Trajectory, "TrajectoryColor", TrajectoryColor.Name);

            _fileManager.WriteIniFile(Sections.Figure, "FigureSize", FigureSize);
            _fileManager.WriteIniFile(Sections.Figure, "FigureSpeed", FigureSpeed);
            _fileManager.WriteIniFile(Sections.Figure, "FigureBreathingSpeed", FigureBreathingSpeed);
            _fileManager.WriteIniFile(Sections.Figure, "FigureColor", FigureColor.Name);

            _fileManager.WriteIniFile(Sections.Figure,
                "CharacteristicPoints",
                StringToFigureConverter.ConvertPointsToText(CharacteristicPoints, ", "));
        }

        public void LoadConfigFromIni()
        {
            if (!_fileManager.FileExists())
                return;

            FieldColor = GetColor(_fileManager.ReadIniFile(Sections.WorkSpace, "FieldColor"));

            TrajectorySize = int.Parse(_fileManager.ReadIniFile(Sections.Trajectory, "TrajectorySize"));
            TrajectoryColor = GetColor(_fileManager.ReadIniFile(Sections.Trajectory, "TrajectoryColor"));

            FigureSize = int.Parse(_fileManager.ReadIniFile(Sections.Figure, "FigureSize"));
            FigureSpeed = int.Parse(_fileManager.ReadIniFile(Sections.Figure, "FigureSpeed"));
            FigureBreathingSpeed = int.Parse(_fileManager.ReadIniFile(Sections.Figure, "FigureBreathingSpeed"));
            FigureColor = GetColor(_fileManager.ReadIniFile(Sections.Figure, "FigureColor"));

            CharacteristicPoints = StringToFigureConverter.ConvertTextToPoints(
                _fileManager.ReadIniFile(Sections.Figure, "CharacteristicPoints")
            );
        }
        

        private Color GetColor(string colorString)
        {
            var color = Color.FromName(colorString);

            return !color.IsKnownColor ? ColorTranslator.FromHtml("#" + colorString) : color;
        }
    }
}