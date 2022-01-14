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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void TestMethod(object sender, RoutedEventArgs e)
        {
            var newTab = new TabItem();
            var sheet = new CharacterSheet();
            newTab.Content = sheet;
            Main_Tabs.Items.Add(newTab);
        }

        public void Test_Add_Initial_Sheets(object sender, RoutedEventArgs e)
        {
            var newTab = new TabItem();
            var sheet = new CharacterSheet();
            newTab.Content = sheet;
            newTab.Header = Convert.ToString(Main_Tabs.Items.Count);
            Main_Tabs.Items.Add(newTab);

            var twoTag = new TabItem();
            var sheet2 = new CharacterSheet();
            sheet2.PageBackground = Brushes.Red;
            twoTag.Header = Convert.ToString(Main_Tabs.Items.Count);
            twoTag.Content = sheet2;
            Main_Tabs.Items.Add(twoTag);

        }

    }
}
