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

namespace FED_ALLE_Opgaver.Views
{
    /// <summary>
    /// Interaction logic for BabyNameList.xaml
    /// </summary>
    public partial class BabyNameList : UserControl
    {
        public BabyNameList()
        {
            InitializeComponent();
        }

        private void Mi_FileExitClick(object sender, RoutedEventArgs e)
        {
            
        }

        private void Mi_FontSmall(object sender, RoutedEventArgs e)
        {
            FontSize = 8.0;
        }

        private void Mi_FontNormal(object sender, RoutedEventArgs e)
        {
            FontSize = 12.0;
        }

        private void Mi_FontLarge(object sender, RoutedEventArgs e)
        {
            FontSize = 18.0;
        }

        private void Mi_FontHuge(object sender, RoutedEventArgs e)
        {
            FontSize = 40;
        }
    }
}
