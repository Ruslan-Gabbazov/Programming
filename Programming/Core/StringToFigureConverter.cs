using System;
using System.Drawing;
using System.Linq;

namespace Programming.Core
{
    public static class StringToFigureConverter
    {
        public static Point[] ConvertTextToPoints(string text)
        {
            var lines = text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            return (from line in lines
                select line.Split(';')
                into coordinates
                let x = int.Parse(coordinates[0].Trim())
                let y = int.Parse(coordinates[1].Trim())
                select new Point { X = x, Y = y }).ToArray();
        }

        public static string ConvertPointsToText(Point[] points)
        {
            return string.Join("\n", points.Select(p => $"{p.X}; {p.Y}"));
        }
    }
}