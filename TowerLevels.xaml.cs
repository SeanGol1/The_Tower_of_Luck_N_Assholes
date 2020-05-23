using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for TowerLevels.xaml
    /// </summary>
    public partial class TowerLevels : Window
    {
        public List<RoomEvent> RoomEventList = new List<RoomEvent>();
        public TowerLevels()
        {
            InitializeComponent();
        }


        public void GenerateLevels()
        {
            
            if(tbxLevel20.Text != "")
            {
                RoomEventList.Add(new RoomEvent("20", tbxLevel20.Text));
            }
            if (tbxLevel19.Text != "")
            {
                RoomEventList.Add(new RoomEvent("19", tbxLevel19.Text));
            }
            if (tbxLevel18.Text != "")
            {
                RoomEventList.Add(new RoomEvent("18", tbxLevel18.Text));
            }
            if (tbxLevel17.Text != "")
            {
                RoomEventList.Add(new RoomEvent("17", tbxLevel17.Text));
            }
            if (tbxLevel16.Text != "")
            {
                RoomEventList.Add(new RoomEvent("16", tbxLevel16.Text));
            }
            if (tbxLevel15.Text != "")
            {
                RoomEventList.Add(new RoomEvent("15", tbxLevel15.Text));
            }
            if (tbxLevel14.Text != "")
            {
                RoomEventList.Add(new RoomEvent("14", tbxLevel14.Text));
            }
            if (tbxLevel13.Text != "")
            {
                RoomEventList.Add(new RoomEvent("13", tbxLevel13.Text));
            }
            if (tbxLevel12.Text != "")
            {
                RoomEventList.Add(new RoomEvent("12", tbxLevel12.Text));
            }
            if (tbxLevel11.Text != "")
            {
                RoomEventList.Add(new RoomEvent("11", tbxLevel11.Text));
            }
            if (tbxLevel10.Text != "")
            {
                RoomEventList.Add(new RoomEvent("10", tbxLevel10.Text));
            }
            if (tbxLevel9.Text != "")
            {
                RoomEventList.Add(new RoomEvent("9", tbxLevel9.Text));
            }
            if (tbxLevel8.Text != "")
            {
                RoomEventList.Add(new RoomEvent("8", tbxLevel8.Text));
            }
            if (tbxLevel7.Text != "")
            {
                RoomEventList.Add(new RoomEvent("7", tbxLevel7.Text));
            }
            if (tbxLevel6.Text != "")
            {
                RoomEventList.Add(new RoomEvent("6", tbxLevel6.Text));
            }
            if (tbxLevel5.Text != "")
            {
                RoomEventList.Add(new RoomEvent("5", tbxLevel5.Text));
            }
            if (tbxLevel4.Text != "")
            {
                RoomEventList.Add(new RoomEvent("4", tbxLevel4.Text));
            }
            if (tbxLevel3.Text != "")
            {
                RoomEventList.Add(new RoomEvent("3", tbxLevel3.Text));
            }
            if (tbxLevel2.Text != "")
            {
                RoomEventList.Add(new RoomEvent("2", tbxLevel2.Text));
            }
            if (tbxLevel1.Text != "")
            {
                RoomEventList.Add(new RoomEvent("1", tbxLevel1.Text));
            }
            if (tbxLevelm1.Text != "")
            {
                RoomEventList.Add(new RoomEvent("-1", tbxLevelm1.Text));
            }
            if (tbxLevelm2.Text != "")
            {
                RoomEventList.Add(new RoomEvent("-2", tbxLevelm2.Text));
            }
            if (tbxLevelm3.Text != "")
            {
                RoomEventList.Add(new RoomEvent("-3", tbxLevelm3.Text));
            }
            if (tbxLevelm4.Text != "")
            {
                RoomEventList.Add(new RoomEvent("-4", tbxLevelm4.Text));
            }
            if (tbxLevelm5.Text != "")
            {
                RoomEventList.Add(new RoomEvent("-5", tbxLevelm5.Text));
            }
            if (tbxLevelm6.Text != "")
            {
                RoomEventList.Add(new RoomEvent("-6", tbxLevelm6.Text));
            }
            if (tbxLevelm7.Text != "")
            {
                RoomEventList.Add(new RoomEvent("-7", tbxLevelm7.Text));
            }
            if (tbxLevelm8.Text != "")
            {
                RoomEventList.Add(new RoomEvent("-8", tbxLevelm8.Text));
            }
            if (tbxLevelm9.Text != "")
            {
                RoomEventList.Add(new RoomEvent("-9", tbxLevelm9.Text));
            }
            if (tbxLevelm10.Text != "")
            {
                RoomEventList.Add(new RoomEvent("-10", tbxLevelm10.Text));
            }
            if (tbxLevelm11.Text != "")
            {
                RoomEventList.Add(new RoomEvent("-11", tbxLevelm11.Text));
            }
            if (tbxLevelm12.Text != "")
            {
                RoomEventList.Add(new RoomEvent("-12", tbxLevelm12.Text));
            }
            if (tbxLevelm13.Text != "")
            {
                RoomEventList.Add(new RoomEvent("-13", tbxLevelm13.Text));
            }
            if (tbxLevelm14.Text != "")
            {
                RoomEventList.Add(new RoomEvent("-14", tbxLevelm14.Text));
            }
            if (tbxLevelm15.Text != "")
            {
                RoomEventList.Add(new RoomEvent("-15", tbxLevelm15.Text));
            }
            if (tbxLevelm16.Text != "")
            {
                RoomEventList.Add(new RoomEvent("-16", tbxLevelm16.Text));
            }
            if (tbxLevelm17.Text != "")
            {
                RoomEventList.Add(new RoomEvent("-17", tbxLevelm17.Text));
            }
            if (tbxLevelm18.Text != "")
            {
                RoomEventList.Add(new RoomEvent("-18", tbxLevelm18.Text));
            }
            if (tbxLevelm19.Text != "")
            {
                RoomEventList.Add(new RoomEvent("-19", tbxLevelm19.Text));
            }
            if (tbxLevelm20.Text != "")
            {
                RoomEventList.Add(new RoomEvent("-20", tbxLevelm20.Text));
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            GenerateLevels();
             // Create a string array with the lines of text
            
            
            

            // Set a variable to the Documents path.
            string docPath =
              Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(System.IO.Path.Combine(docPath, "/Users/seang/source/repos/MosterGenWPF/save/Test1.txt")))
            {
                outputFile.WriteLine(DateTime.Now);
                foreach (RoomEvent ev in RoomEventList)
                {
                    outputFile.WriteLine(ev.RoomNumber + "," + ev.EventName);
                }                
            }
            
        }

        private void BtnLoad_Click(object sender, RoutedEventArgs e)
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"/Users/seang/source/repos/MosterGenWPF/save/Test1.txt");
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                counter++;
            }

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
            System.Console.ReadLine();
        }
    }
}
