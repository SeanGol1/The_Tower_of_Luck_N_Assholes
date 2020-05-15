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
    /// Interaction logic for MonsterList.xaml
    /// </summary>
    public partial class MonsterWindow : Window
    {
        public MainWindow mw = new MainWindow();
        public List<Monster> MonsterFilterList = new List<Monster>();
        public List<String> TempCRList = new List<String>();

        public MonsterWindow()
        {
            InitializeComponent();
            
            lstMonster.ItemsSource = mw.MonsterList;
            //cbbMonsterCr.ItemsSource = mw.CRList;
            GenerateList();
        }

        private void GenerateList()
        {
            if (mw.CRRoll != "")
            {
                cbbMonsterCr.SelectedIndex = Convert.ToInt32(mw.CRRoll) + 1;
                foreach (var item in mw.CRList)
                {
                    TempCRList.Add(item.LVLDesc);
                }
                cbbMonsterCr.ItemsSource = TempCRList;
            }
        }

        private void CbbMonsterCr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MonsterFilterList.Clear();
            foreach (Monster mon in mw.MonsterList)
            {
                if(mon.MonsterCR == cbbMonsterCr.SelectedItem.ToString())
                {
                    MonsterFilterList.Add(mon);
                }
            }
            lstMonster.ItemsSource = MonsterFilterList;
            lstMonster.Items.Refresh();
            //lstMonster.UpdateLayout();
        }
    }
}
