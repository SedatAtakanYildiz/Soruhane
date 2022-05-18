using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoruHane1._4
{
    public static class TemaRengi
    {
        public static List<string> RenkListesi = new List<string>() { "#3F51B5",
                                                                      "#009688",
                                                                      "#FF5722",
                                                                      "#607D8B",
                                                                      "#FF9800",
                                                                      "#9C27B0",
                                                                      "#2196F3",
                                                                      "#EA676C",
                                                                      "#E41A4A",
                                                                      "#5978BB",
                                                                      "#018790",
                                                                      "#0E3441",
                                                                      "#00B0AD",
                                                                      "#721D47",
                                                                      "#EA4833",
                                                                      "#EF937E",
                                                                      "#F37521",
                                                                      "#A12059",
                                                                      "#126881",
                                                                      "#8BC240",
                                                                      "#364D5B",
                                                                      "#C7DC5B",
                                                                      "#0094BC",
                                                                      "#E4126B",
                                                                      "#43B76E",
                                                                      "#7BCFE9",
                                                                      "#B71C46"};

        public static Color ChangeColorBrightness(Color Renk, double correctionFactor)
        {
            double red = Renk.R;
            double green = Renk.G;
            double blue = Renk.B;
            //If correction factor is less than 0, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If correction factor is greater than zero, lighten color.
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(Renk.A, (byte)red, (byte)green, (byte)blue);
        }

    }
}
