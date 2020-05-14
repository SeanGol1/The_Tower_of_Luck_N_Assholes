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
    /// Interaction logic for Startup.xaml
    /// </summary>
    public partial class Startup : Window
    {
        public MainWindow mw = new MainWindow();
        public Startup()
        {
            InitializeComponent();
            cbbPlayers.ItemsSource = mw.PlayerLevelList;            

        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {

            mw.PlayerLVL = cbbPlayers.SelectedItem.ToString();
            mw.Show();
            this.Close();
            
        }
    }
}
