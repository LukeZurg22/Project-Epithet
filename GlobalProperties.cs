using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Epithet_Erased_System
{


    public static class GlobalProperties
    {
        public static event EventHandler GlobalBackgroundChanged;

        private static Brush _background;
        public static Brush GlobalBackground
        {
            get { return _background; }
            set
            {
                if (value != _background)
                {
                    _background = value;

                    if (GlobalBackgroundChanged != null)
                        GlobalBackgroundChanged(null, EventArgs.Empty);
                }
            }
        }

        public static event EventHandler GlobalForegroundChanged;
        private static Brush _foreground;
        public static Brush GlobalForeground
        {
            get { return _foreground; }
            set
            {
                if (value != _foreground)
                {
                    _foreground = value;

                    if (GlobalForegroundChanged != null)
                        GlobalForegroundChanged(null, EventArgs.Empty);
                }
            }
        }


        public static event EventHandler GlobalFontSizeChanged;
        private static double _fontsize;
        public static double GlobalFontSize
        {
            get { return _fontsize; }
            set
            {
                if (value != _fontsize)
                {
                    _fontsize = value;

                    if (GlobalFontSizeChanged != null)
                        GlobalFontSizeChanged(null, EventArgs.Empty);
                }
            }
        }


/*      public static event EventHandler GlobalFontFamilyChanged;
        private static double _fontfamily;
        public static double GlobalFontFamily
        {
            get { return _fontfamily; }
            set
            {
                if (value != _fontfamily)
                {
                    _fontfamily = value;

                    if (GlobalFontFamilyChanged != null)
                        GlobalFontFamilyChanged(null, EventArgs.Empty);
                }
            }
        }*/

        public static event EventHandler GlobalStat1StrokeChanged;
        private static Brush _stat1colorstroke = Brushes.Green;
        public static Brush GlobalStat1Stroke
        {
            get { return _stat1colorstroke; }
            set
            {
                if (value != _stat1colorstroke)
                {
                    _stat1colorstroke = value;

                    if (GlobalStat1StrokeChanged != null)
                        GlobalStat1StrokeChanged(null, EventArgs.Empty);
                }
            }
        }

        public static event EventHandler GlobalStat1ForegroundChanged;
        private static Brush _stat1colorforeground = Brushes.Green;
        public static Brush GlobalStat1Foreground
        {
            get { return _stat1colorforeground; }
            set
            {
                if (value != _stat1colorforeground)
                {
                    _stat1colorforeground = value;

                    if (GlobalStat1ForegroundChanged != null)
                        GlobalStat1ForegroundChanged(null, EventArgs.Empty);
                }
            }
        }

    }
}
