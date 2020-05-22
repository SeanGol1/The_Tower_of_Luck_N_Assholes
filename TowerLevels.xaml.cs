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
        public TowerLevels()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            /*
             // Create a string array with the lines of text
            string[] lines = { "First line", "Second line", "Third line" };

            // Set a variable to the Documents path.
            string docPath =
              Environment.GetFolderPath();

            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt")))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }
            */
        }

        private void BtnLoad_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
