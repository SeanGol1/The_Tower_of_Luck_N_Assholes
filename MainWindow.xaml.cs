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

namespace MosterGenWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<RoomNumber> RoomList = new List<RoomNumber>();
        public List<Biom> BiomList = new List<Biom>();
        public List<Event> EventList = new List<Event>();
        public List<MonsterCR> CRList = new List<MonsterCR>();
        public List<Monster> MonsterList = new List<Monster>();
        public List<Monster> CurrentMonsterList = new List<Monster>();
        public List<Monster> TempMonsterList = new List<Monster>();

        public string RoomRoll = "";
        public string BiomRoll = "";
        public string EventRoll = "";
        public string CRRoll = "";
        public string MonsterRoll1 = "";
        public string MonsterRoll2 = "";
        public MainWindow()
        {
            InitializeComponent();
            CreateList();
        }


        public void CreateList()
        {
            //Add Rooms
            RoomList.Add(new RoomNumber("1", "-6"));
            RoomList.Add(new RoomNumber("2", "-5"));
            RoomList.Add(new RoomNumber("3", "-4"));
            RoomList.Add(new RoomNumber("4", "-3"));
            RoomList.Add(new RoomNumber("5", "-2"));
            RoomList.Add(new RoomNumber("6", "-1"));
            RoomList.Add(new RoomNumber("7", "+1"));
            RoomList.Add(new RoomNumber("8", "+2"));
            RoomList.Add(new RoomNumber("9", "+3"));
            RoomList.Add(new RoomNumber("10", "+4"));
            RoomList.Add(new RoomNumber("11", "+5"));
            RoomList.Add(new RoomNumber("12", "+6"));

            //Add Bioms
            BiomList.Add(new Biom("1", "Moster Biom (DM Choice)"));
            BiomList.Add(new Biom("2", "Cave"));
            BiomList.Add(new Biom("3", "Empty Room"));
            BiomList.Add(new Biom("4", "Swamp"));
            BiomList.Add(new Biom("5", "Desert"));
            BiomList.Add(new Biom("6", "Aquatic"));
            BiomList.Add(new Biom("7", "Underdark"));
            BiomList.Add(new Biom("8", "Jungle"));
            BiomList.Add(new Biom("9", "10x10 Room"));
            BiomList.Add(new Biom("10", "Urban"));
            BiomList.Add(new Biom("11", "Arctic"));
            BiomList.Add(new Biom("12", "Monster Biom (DM Choice)"));
            BiomList.Add(new Biom("1", "Arctic"));


            //Add Random Events
            EventList.Add(new Event("1", "DEX Save Stepping out of Elevator"));
            EventList.Add(new Event("2", "DEX Save Poison Arrow + 2 round restrained"));
            EventList.Add(new Event("3", "Change Enemy Size - O=Large, E=Small"));
            EventList.Add(new Event("4", "Walls Open up to reveal an audience watching the fight"));
            EventList.Add(new Event("5", "STR to open the elevator"));
            EventList.Add(new Event("6", "10 ft gap between elevator and room"));
            EventList.Add(new Event("7", "Reverse Gravity"));
            EventList.Add(new Event("8", "ASK DM"));
            EventList.Add(new Event("9", "Spikes in ceiling lower 30sec to complete"));
            EventList.Add(new Event("10", "1d10 Random Floors Electrified"));
            EventList.Add(new Event("11", "Gain 5 Temp HP"));
            EventList.Add(new Event("12", "Change Player Size  - O=Large, E=Small"));

            //Add CR Levels
            CRList.Add(new MonsterCR("1", "7 + 4"));
            CRList.Add(new MonsterCR("2", "5 + 6"));
            CRList.Add(new MonsterCR("3", "8 + 3"));
            CRList.Add(new MonsterCR("4", "9 + 2"));
            CRList.Add(new MonsterCR("5", "10"));
            CRList.Add(new MonsterCR("6", "5 + 2 + 2"));
            CRList.Add(new MonsterCR("7", "5 + 4"));
            CRList.Add(new MonsterCR("8", "4 + 2 + 2"));
            CRList.Add(new MonsterCR("9", "3 + 6"));
            CRList.Add(new MonsterCR("10", "3 + 3 + 2"));
            CRList.Add(new MonsterCR("11", "5 + 4"));
            CRList.Add(new MonsterCR("12", "8 + 2"));

            //Add Monster
            MonsterList.Add(new Monster("2", "PlesioSaurus", "80", "1"));
            MonsterList.Add(new Monster("2", "Grick", "173", "2"));
            MonsterList.Add(new Monster("2", "Priest", "0", "3"));
            MonsterList.Add(new Monster("2", "Ochre Jelly", "243", "4"));

            MonsterList.Add(new Monster("3", "Veteran", "350", "1"));
            MonsterList.Add(new Monster("3", "Knight", "347", "2"));
            MonsterList.Add(new Monster("3", "Minotaur", "223", "3"));
            MonsterList.Add(new Monster("3", "Displaced Beast", "0", "4"));

            MonsterList.Add(new Monster("4", "Shadow Demon", "64", "1"));
            MonsterList.Add(new Monster("4", "Chuul", "40", "2"));
            MonsterList.Add(new Monster("4", "Red Dragon Wyrmling", "98", "3"));
            MonsterList.Add(new Monster("4", "Weretiger", "0", "4"));

            MonsterList.Add(new Monster("5", "Night Hag", "178", "1"));
            MonsterList.Add(new Monster("5", "Flesh Golem", "169", "2"));
            MonsterList.Add(new Monster("5", "Unicorn", "294", "3"));
            MonsterList.Add(new Monster("5", "Gorgon", "171", "4"));

            MonsterList.Add(new Monster("6", "Chimera", "60", "1"));
            MonsterList.Add(new Monster("6", "Drider", "120", "2"));
            MonsterList.Add(new Monster("6", "Vrock", "64", "3"));
            MonsterList.Add(new Monster("6", "Mammoth", "332", "4"));

            MonsterList.Add(new Monster("7", "Yuan-Ti Abomination", "308", "1"));
            MonsterList.Add(new Monster("7", "Shield Golem", "271", "2"));
            MonsterList.Add(new Monster("7", "Mind Flayer", "222", "3"));
            MonsterList.Add(new Monster("7", "Giant Ape", "0", "4"));

            MonsterList.Add(new Monster("8", "Hydra", "190", "1"));
            MonsterList.Add(new Monster("8", "Assassin", "343", "2"));
            MonsterList.Add(new Monster("8", "Green Slaad", "277", "3"));
            MonsterList.Add(new Monster("8", "Frost Giant", "155", "4"));

            MonsterList.Add(new Monster("9", "FireGiant", "154", "1"));
            MonsterList.Add(new Monster("9", "Abominatble Yeti", "306", "2"));
            MonsterList.Add(new Monster("9", "Clay Golem", "168", "3"));
            MonsterList.Add(new Monster("9", "Nycaloth", "134", "4"));

            MonsterList.Add(new Monster("10", "Death Slaad", "278", "1"));
            MonsterList.Add(new Monster("10", "Guardian Naga", "234", "2"));
            MonsterList.Add(new Monster("10", "Stone Golem", "170", "3"));
            MonsterList.Add(new Monster("10", "Young Red Dragon", "98", "4"));

            MonsterList.Add(new Monster("11", "Roc", "260", "1"));
            MonsterList.Add(new Monster("11", "Gynosphinx", "282", "2"));
            MonsterList.Add(new Monster("11", "Horned Devil", "0", "3"));
            MonsterList.Add(new Monster("11", "Remorhaz", "258", "4"));


        }

        //Create 
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Random rd = new Random();

            if (tbxRoomRoll.Text == "")
                RoomRoll = Convert.ToString(rd.Next(1, 12));
            else
                RoomRoll = Convert.ToString(tbxRoomRoll.Text);


            if (tbxBiomRoll.Text == "")
                BiomRoll = Convert.ToString(rd.Next(1, 12));
            else
                BiomRoll = Convert.ToString(tbxBiomRoll.Text);


            if (tbxEventRoll.Text == "")
                EventRoll = Convert.ToString(rd.Next(1, 12));
            else
                EventRoll = Convert.ToString(tbxEventRoll.Text);


            if (tbxCRRoll.Text == "")
                CRRoll = Convert.ToString(rd.Next(1, 12));
            else
                CRRoll = Convert.ToString(tbxCRRoll.Text);



            GenerateValues();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Random rd = new Random();

            RoomRoll = Convert.ToString(rd.Next(1, 12));
            BiomRoll = Convert.ToString(rd.Next(1, 12));
            EventRoll = Convert.ToString(rd.Next(1, 12));
            CRRoll = Convert.ToString(rd.Next(1, 6));



            GenerateValues();
        }

        public void GenerateValues()
        {
            int addroom = 0;
            //Generate Room
            foreach (RoomNumber roll in RoomList)
            {
                if (roll.Number == RoomRoll)
                {
                    tbxRoomDesc.Text = "Current Room " + roll.Room;
                    addroom = Convert.ToInt32(roll.Room);
                }
            }

            //Generate Biom
            foreach (Biom roll in BiomList)
            {
                if (roll.BiomNumber == BiomRoll)
                {
                    tbxBiomDesc.Text = roll.BiomDesc;
                }
            }

            //Generate Event
            foreach (Event roll in EventList)
            {
                if (roll.EventNumber == EventRoll)
                {
                    tbxEventDesc.Text = roll.EventDesc;
                }
            }

            //Generate CR
            foreach (MonsterCR roll in CRList)
            {
                if (roll.LVLNumber == CRRoll)
                {
                    tbxMonterCRDesc.Text = "Level " + roll.LVLDesc + " Monster(s)";
                }
            }

            //Generate New Room #
            int roomno = Convert.ToInt32(tbxCurrentRoom.Text) + addroom;
            tbxCurrentRoom.Text = Convert.ToString(roomno);

            tbxRoomRoll.Text = RoomRoll;
            tbxBiomRoll.Text = BiomRoll;
            tbxEventRoll.Text = EventRoll;
            tbxCRRoll.Text = CRRoll;

        }




        /* Assign 4 Monsters for each CR and pop them into a list */

        public void GetMonsterList()
        {
            Random rd = new Random();
            int index = rd.Next(MonsterList.Count);

        }


        public void AssignMonsterRolls()
        {

            for (int i = 2; i < 11; i++)
            {
                Random rd = new Random();
                int x = 1;
                foreach (Monster mon in MonsterList.Where(n => n.MonsterCR == Convert.ToString(i)))
                {
                    int index = rd.Next(1, 5);                    
                    mon.MonsterRdNumber = Convert.ToString(index);
                    TempMonsterList.Add(mon);                   
                    x++;
                }

            }
        }

        public void AssignRDnumbers()
        {
            Random rd = new Random();
            foreach (Monster mon in TempMonsterList)
            {
                string rdnumber = Convert.ToString(rd.Next(1, TempMonsterList.Count()));
                if (CheckExists(rdnumber) == true)
                {
                    mon.MonsterRdNumber = rdnumber;
                }
            }
        }

        public bool CheckExists(string rdnumber)
        {
            foreach (Monster moncr in TempMonsterList)
            {
                if (moncr.MonsterRdNumber != rdnumber)
                {
                    return true;
                }
                else return false;
            }
            return false;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AssignMonsterRolls();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MonsterWindow monsterWindow = new MonsterWindow();
            monsterWindow.Show();
        }
    }
}
