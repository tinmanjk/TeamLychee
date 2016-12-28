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
using System.IO;

namespace Mail
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, RoutedEventArgs e)
        {
            string destination;
            string receiver;
            double weight;

            if(String.IsNullOrEmpty(textBoxDestination.Text) || String.IsNullOrEmpty(textBoxReceiver.Text)
                || !double.TryParse(textBoxWeight.Text, out weight))
            {
                MessageBox.Show("Please enter the information in the correct way!", "Invalid output");
                return; //stop executing 
            }   //this statement checks (kinda) if the input in the boxes is correct
            else
            {
                destination = textBoxDestination.Text;
                receiver = textBoxReceiver.Text;
                weight = double.Parse(textBoxWeight.Text);
            }

            Package package = new Package(destination, receiver, weight);
            package.AddPackageToFile("packages.csv");
        }

        IEnumerable<Package> ProcessPackagesFromFile(string filepath)
        {
            var packages = new List<Package>();
            var lines = File.ReadAllLines(filepath);

            foreach (var line in lines)
            {
                packages.Add(Package.Parse(line));
            }

            return packages;
        }

        private void buttonShowAll_Click(object sender, RoutedEventArgs e)
        {
            listViewPackages.Items.Clear();

            var fileContent = ProcessPackagesFromFile(@".\packages.csv");

            foreach (var item in fileContent)
            {
                listViewPackages.Items.Add(item);
            }
        }
    }
}
