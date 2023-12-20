using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;

namespace Programming.Core
{
    public static class StringToFigureConverter
    {
        public static Point[] ConvertTextToPoints(string text)
        {
            text = Regex.Replace(text, @"\s", "");
            var lines = text.Trim().Split(new[] { ",", "(", ")" }, StringSplitOptions.RemoveEmptyEntries);

            return (from line in lines
                select line.Split(';')
                into coordinates
                let x = int.Parse(coordinates[0].Trim())
                let y = int.Parse(coordinates[1].Trim())
                select new Point { X = x, Y = y }).ToArray();
        }

        public static string ConvertPointsToText(IEnumerable<Point> points, string lineSeparator = ",\n")
        {
            return string.Join(lineSeparator, points.Select(p => $"({p.X}; {p.Y})"));
        }
    }
}