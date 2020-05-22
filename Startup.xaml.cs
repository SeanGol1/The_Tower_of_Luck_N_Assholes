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
            /*
            if (txtRoomENumber1.Text != "" || txtRoomENumber1.Text != null)
            {
                mw.RoomEventList.Add(new RoomEvent(txtRoomENumber1.Text, txtRoomEDescription1.Text));
            }
            if (txtRoomENumber2.Text != "" || txtRoomENumber2.Text != null)
            {
                mw.RoomEventList.Add(new RoomEvent(txtRoomENumber2.Text, txtRoomEDescription2.Text));
            }
            if (txtRoomENumber3.Text != "" || txtRoomENumber3.Text != null)
            {
                mw.RoomEventList.Add(new RoomEvent(txtRoomENumber3.Text, txtRoomEDescription3.Text));
            }
            if (txtRoomENumber4.Text != "" || txtRoomENumber4.Text != null)
            {
                mw.RoomEventList.Add(new RoomEvent(txtRoomENumber4.Text, txtRoomEDescription4.Text));
            }
            if (txtRoomENumber5.Text != "" || txtRoomENumber5.Text != null)
            {
                mw.RoomEventList.Add(new RoomEvent(txtRoomENumber5.Text, txtRoomEDescription5.Text));
            }
            if (txtRoomENumber6.Text != "" || txtRoomENumber6.Text != null)
            {
                mw.RoomEventList.Add(new RoomEvent(txtRoomENumber6.Text, txtRoomEDescription6.Text));
            }
            */

            mw.PlayerLVL = cbbPlayers.SelectedItem.ToString();
            mw.Show();
            this.Close();
            
        }
    }
}
