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

namespace Epithet_Erased_System.Controls
{
    /// <summary>
    /// Interaction logic for Control_Charactersheet_Settings.xaml
    /// </summary>
    public partial class Control_Charactersheet_Settings : UserControl
    {

        public static DependencyProperty PageBackgroundProperty = DependencyProperty.Register("PageBackground", typeof(Brush), typeof(Control_Charactersheet_Settings));
        public Brush PageBackground
        {
            get => (Brush)GetValue(PageBackgroundProperty);
            set => SetValue(PageBackgroundProperty, value);
        }

        public static DependencyProperty Stat1ForegroundProperty = DependencyProperty.Register("Stat1Foreground", typeof(Brush), typeof(Control_Charactersheet_Settings));
        public Brush Stat1Foreground
        {
            get => (Brush)GetValue(Stat1ForegroundProperty);
            set => SetValue(Stat1ForegroundProperty, value);
        }

        public static DependencyProperty Stat1StrokeProperty = DependencyProperty.Register("Stat1Stroke", typeof(Brush), typeof(Control_Charactersheet_Settings));
        public Brush Stat1Stroke
        {
            get => (Brush)GetValue(Stat1StrokeProperty);
            set => SetValue(Stat1StrokeProperty, value);
        }

        public static DependencyProperty Stat1TextProperty = DependencyProperty.Register("Stat1Text", typeof(string), typeof(Control_Charactersheet_Settings));
        public string Stat1Text
        {
            get => (string)GetValue(Stat1TextProperty);
            set => SetValue(Stat1TextProperty, value);
        }


        //---------------------------------------------------------------------------------
        private static DependencyProperty Stat2ForegroundProperty = DependencyProperty.Register("Stat2Foreground", typeof(Brush), typeof(Control_Charactersheet_Settings));
        public Brush Stat2Foreground
        {
            get => (Brush)GetValue(Stat2ForegroundProperty);
            set => SetValue(Stat2ForegroundProperty, value);
        }

        public static DependencyProperty Stat2StrokeProperty = DependencyProperty.Register("Stat2Stroke", typeof(Brush), typeof(Control_Charactersheet_Settings));
        public Brush Stat2Stroke
        {
            get => (Brush)GetValue(Stat2StrokeProperty);
            set { SetValue(Stat2StrokeProperty, value); }
        }

        public static DependencyProperty Stat2TextProperty = DependencyProperty.Register("Stat2Text", typeof(string), typeof(Control_Charactersheet_Settings));
        public string Stat2Text
        {
            get => (string)GetValue(Stat2TextProperty);
            set => SetValue(Stat2TextProperty, value);
        }
        //---------------------------------------------------------------------------------
        private static DependencyProperty Stat3ForegroundProperty = DependencyProperty.Register("Stat3Foreground", typeof(Brush), typeof(Control_Charactersheet_Settings));
        public Brush Stat3Foreground
        {
            get => (Brush)GetValue(Stat3ForegroundProperty);
            set => SetValue(Stat3ForegroundProperty, value);
        }

        public static DependencyProperty Stat3StrokeProperty = DependencyProperty.Register("Stat3Stroke", typeof(Brush), typeof(Control_Charactersheet_Settings));
        public Brush Stat3Stroke
        {
            get => (Brush)GetValue(Stat3StrokeProperty);
            set { SetValue(Stat3StrokeProperty, value); }
        }

        public static DependencyProperty Stat3TextProperty = DependencyProperty.Register("Stat3Text", typeof(string), typeof(Control_Charactersheet_Settings));
        public string Stat3Text
        {
            get => (string)GetValue(Stat3TextProperty);
            set => SetValue(Stat3TextProperty, value);
        }
        //---------------------------------------------------------------------------------
        private static DependencyProperty Stat4ForegroundProperty = DependencyProperty.Register("Stat4Foreground", typeof(Brush), typeof(Control_Charactersheet_Settings));
        public Brush Stat4Foreground
        {
            get => (Brush)GetValue(Stat4ForegroundProperty);
            set => SetValue(Stat4ForegroundProperty, value);
        }

        public static DependencyProperty Stat4StrokeProperty = DependencyProperty.Register("Stat4Stroke", typeof(Brush), typeof(Control_Charactersheet_Settings));
        public Brush Stat4Stroke
        {
            get => (Brush)GetValue(Stat4StrokeProperty);
            set { SetValue(Stat4StrokeProperty, value); }
        }

        public static DependencyProperty Stat4TextProperty = DependencyProperty.Register("Stat4Text", typeof(string), typeof(Control_Charactersheet_Settings));
        public string Stat4Text
        {
            get => (string)GetValue(Stat4TextProperty);
            set => SetValue(Stat4TextProperty, value);
        }
        //---------------------------------------------------------------------------------





        public Control_Charactersheet_Settings()
        {
            Stat1Stroke = Brushes.Green;
            Stat1Foreground = Brushes.Green;
            Stat1Text = "STAMINA";

            InitializeComponent();
        }


        private void ColorPicker_CharacterSheetRibbon_Changed(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            var brush = new SolidColorBrush((Color)ColorPicker.SelectedColor);
            PageBackground = brush;
        }


        private void Settings_Stat1_Foreground_Changed(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            var box = (ColorPicker)sender;
            var brush = new SolidColorBrush((Color)box.SelectedColor);
            if (IsLoaded)
            {

                Stat1Foreground = brush;
            }
        }


        private void Settings_Stat1_Stroke_Changed(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            var box = (ColorPicker)sender;
            var brush = new SolidColorBrush((Color)box.SelectedColor);
            if (IsLoaded)
            {

                Stat1Stroke = brush;

            }
        }

        private void Stat1TextPicker_TextChanged(object sender, TextChangedEventArgs e)
        {
            var text = Stat1TextPicker.Text;
            if (IsLoaded)
            {

                Stat1Text = text;

            }
        }
    }
}
