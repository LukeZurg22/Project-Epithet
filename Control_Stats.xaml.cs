using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Epithet_Erased_System
{
    /// <summary>
    /// Interaction logic for Stat.xaml
    /// </summary>
    public partial class Stat : UserControl
    {
        public static DependencyProperty StrokeProperty = DependencyProperty.Register("Stroke", typeof(Brush), typeof(Stat));
        public Brush Stroke
        {
            get { return (Brush)GetValue(StrokeProperty); }
            set { SetValue(StrokeProperty, value); }
        }

        public static new DependencyProperty FontFamilyProperty = DependencyProperty.Register("FontFamily", typeof(FontFamily), typeof(Stat));
        public new FontFamily FontFamily
        {
            get { return (FontFamily)GetValue(FontFamilyProperty); }
            set { SetValue(FontFamilyProperty, value); }
        }

        public static DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(Stat));
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static DependencyProperty TitleColor = DependencyProperty.Register("Foreground", typeof(Brush), typeof(Stat));
        public new Brush Foreground
        {
            get { return (Brush)GetValue(TitleColor); }
            set { SetValue(TitleColor, value); }
        }

        public Stat()
        {
            InitializeComponent();
        }




    }
}
