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
    /// Interaction logic for MonsterIMGFullSize.xaml
    /// </summary>
    public partial class MonsterIMGFullSize : Window
    {
        public Monster SelMon = null;
        public MonsterIMGFullSize(Monster _SelMon)
        {
            InitializeComponent();
            SelMon = _SelMon;

        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Monster SelMonster = SelMon;

                string fullpath = "C:/Users/seang/source/repos/MosterGenWPF/img/" + SelMonster.MonsterName + ".jpg";

                imgMonster.Source = new BitmapImage(new Uri(fullpath));

            }
            catch
            {
                imgMonster.Source = null;
            }
        }
    }
}
