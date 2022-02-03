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

    public partial class CharacterSheet : UserControl
    {
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

        private void Grid_GotKeyboardFocus(object sender, MouseEventArgs e)
        {
            //Settings_Control.Settings_Expander.IsExpanded = false;
            Console.WriteLine("Lost focus of the expander.");
        }
    }
}
