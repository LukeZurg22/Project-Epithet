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
using Xceed.Wpf.Toolkit;

namespace Epithet_Erased_System
{
    /// <summary>
    /// Interaction logic for Settings_Page.xaml
    /// </summary>
    public partial class Settings_Page : UserControl
    {
        //public static Brush GlobalBackground { get; set; }
        //public static Brush GlobalForeground { get; set; }
        public static Brush GlobalFontFamily { get; set; }
        public static Brush GlobalFontSize { get; set; }

        public static DependencyProperty GlobalBackgroundProperty = DependencyProperty.Register("GlobalBackground", typeof(Brush), typeof(Settings_Page));
        public Brush GlobalBackground
        {
            get { return (Brush)GetValue(GlobalBackgroundProperty); }
            set { SetValue(GlobalBackgroundProperty, value); }
        }

        public static DependencyProperty GlobalForegroundProperty = DependencyProperty.Register("GlobalForeground", typeof(Brush), typeof(Settings_Page));
        public Brush GlobalForeground
        {
            get { return (Brush)GetValue(GlobalForegroundProperty); }
            set { SetValue(GlobalForegroundProperty, value); }
        }

        public Settings_Page()
        {
            InitializeComponent();
        }

        private void Settings_Background_Changed(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            var box = (ColorPicker)sender;
            var brush = new SolidColorBrush((Color)box.SelectedColor);
            GlobalBackground = brush;
        }

        private void Settings_Foreground_Changed(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            var box = (ColorPicker)sender;
            var brush = new SolidColorBrush((Color)box.SelectedColor);
            GlobalForeground = brush;
        }
    }
}
