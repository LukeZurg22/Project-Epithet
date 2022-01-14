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

    public partial class CharacterSheet : UserControl
    {
        public static new DependencyProperty BackgroundProperty = DependencyProperty.Register("Background", typeof(Brush), typeof(CharacterSheet));
        public new Brush Background
        {
            get { return (Brush)GetValue(BackgroundProperty); }
            set { SetValue(BackgroundProperty, value); }
        }

        public static DependencyProperty PageBackgroundProperty = DependencyProperty.Register("PageBackground", typeof(Brush), typeof(CharacterSheet));
        public Brush PageBackground
        {
            get { return (Brush)GetValue(Settings_Page.GlobalBackgroundProperty); }
            set { SetValue(Settings_Page.GlobalBackgroundProperty, value); }
        }

        public CharacterSheet()
        {
            InitializeComponent();
        }

        private void Update_Name_Margin(object sender, TextChangedEventArgs e)
        {
            /*            //if (Box_Name.Text.Length > 0)
                        {
                            Box_Name.Width = 12 + (Box_Name.Text.Length * 6);
                        }
            */
        }

        private void ColorPicker_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            var brush = new SolidColorBrush((Color)ColorPicker.SelectedColor);
            Background = brush;
        }
    }
}
