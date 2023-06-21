using System;
using System.Windows.Media;

namespace ColorPlayground.logic;

public class ColorGenerator
{
    public static Color GenerateColor()
    {
        var r = new Random();
        var color = Color.FromArgb(255, (byte)r.Next(256), (byte)r.Next(256), (byte)r.Next(256));
        return color;
    }
}