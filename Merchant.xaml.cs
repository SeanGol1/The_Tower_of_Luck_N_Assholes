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
using System.Windows.Shapes;

namespace MosterGenWPF
{
    
    /// <summary>
    /// Interaction logic for Merchant.xaml
    /// </summary>
    public partial class Merchant : Window
    {
        public List<Item> TempItemList = new List<Item>();
        public Merchant()
        {
            InitializeComponent();
            MainWindow mw = new MainWindow();
            lbxItems.ItemsSource = mw.ItemsList;

        }

        private void CbxVendor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
