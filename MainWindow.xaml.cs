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

        public string RoomRoll = "";
        public string BiomRoll = "";
        public string EventRoll = "";
        public string CRRoll = "";
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
            CRList.Add(new MonsterCR("6", "11"));


        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Random rd = new Random();

            if (tbxRoomRoll.Text == "")
                RoomRoll = Convert.ToString(rd.Next(1, 12));
            else
                RoomRoll = Convert.ToString(tbxRoomRoll.Text);


            if(tbxBiomRoll.Text == "")
                BiomRoll = Convert.ToString(rd.Next(1, 12));
            else
                BiomRoll = Convert.ToString(tbxBiomRoll.Text);


            if(tbxEventRoll.Text == "")
                EventRoll = Convert.ToString(rd.Next(1, 12));
            else
                EventRoll = Convert.ToString(tbxEventRoll.Text);


            if(tbxCRRoll.Text == "")
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
            //Generate Room
            foreach (RoomNumber roll in RoomList)
            {
                if (roll.Number == RoomRoll)
                {
                    tbxRoomDesc.Text = roll.Room;
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


            tbxRoomRoll.Text = RoomRoll;
            tbxBiomRoll.Text = BiomRoll;
            tbxEventRoll.Text = EventRoll;
            tbxCRRoll.Text = CRRoll;

        }


    }
}
