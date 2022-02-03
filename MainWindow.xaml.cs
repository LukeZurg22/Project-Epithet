using Epithet_Erased_System.Pages;
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

            /**
             * The below is for loading an initial sheet; for testing.
             */
            var testTab = new TabItem();
            var testSheet = new CharacterSheet();
            testTab.Content = testSheet;
            testTab.Header = "Test Sheet";
            Main_Tabs.Items.Add(testTab);


            var testTab1 = new TabItem();
            var testSheet1 = new Page_Campaign();
            testTab1.Content = testSheet1;
            testTab1.Header = "Test Campaign";
            Main_Tabs.Items.Add(testTab1);
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            ((TabItem)Main_Tabs.Items[0]).Header = "Changed!";
        }


        public void Test_Add_Campaign(object sender, RoutedEventArgs e)
        {
            var newTab = new TabItem();
            var sheet = new Page_Campaign();
            newTab.Content = sheet;
            Main_Tabs.Items.Add(newTab);

        }

        public void Test_Add_Sheet(object sender, RoutedEventArgs e)
        {
            var twoTag = new TabItem();
            var sheet2 = new CharacterSheet();
            twoTag.Header = Convert.ToString(Main_Tabs.Items.Count);
            twoTag.Content = sheet2;
            Main_Tabs.Items.Add(twoTag);

        }

    }
}
