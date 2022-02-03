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
        public Settings_Page()
        {
            InitializeComponent();
        }

        private void Settings_Background_Changed(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            var box = (ColorPicker)sender;
            var brush = new SolidColorBrush((Color)box.SelectedColor);
            GlobalProperties.GlobalBackground = brush;
        }

        private void Settings_Foreground_Changed(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            var box = (ColorPicker)sender;
            var brush = new SolidColorBrush((Color)box.SelectedColor);
            GlobalProperties.GlobalForeground = brush;
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var box = (Slider)sender;
            GlobalProperties.GlobalFontSize = box.Value;

        }

        private void settingsslider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var box = (Slider)sender;
            GlobalProperties.GlobalSettingsFontSize = box.Value;

        }

        /*private void Settings_FontFamily_Changed(object sender, RoutedPropertyChangedEventArgs<double?> e)
        {
            var box = (Slider)sender;
            GlobalProperties.GlobalFontSize = box.Value;
    }*/



        }
    }
