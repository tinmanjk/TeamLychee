using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mail
{
    class Package
    {
        public int ID { private set; get; }
        public string Destination { set; get; }
        public string ReceiverName { set; get; }
        public double Weight { set; get; }
        public DateTime SentOn { private set; get; }

        public Package()
        {
            this.ID = UniqueID();
            this.SentOn = DateTime.Now;
        }

        public Package(string destination, string receiverName, double weight)
        {
            this.ID = UniqueID();
            this.Destination = destination;
            this.ReceiverName = receiverName;
            this.Weight = weight;
            this.SentOn = DateTime.Now;
        }

        public static int UniqueID()
        {
            //the last ID is going to be kept in the first line of the .csv file containing all the packages
            StreamReader getLastID = new StreamReader(@".\lastID.txt");
            int lastID;

            using (getLastID)
            {
                lastID = int.Parse(getLastID.ReadLine());
            }

            lastID++;

            return lastID;
        }   //gets last ID of package
        public void AddPackageToFile(string filepath)
        {
            StringBuilder result = new StringBuilder();

            result.Append(this.ID);
            result.Append(";");
            result.Append(this.Destination);
            result.Append(";");
            result.Append(this.ReceiverName);
            result.Append(";");
            result.Append(this.Weight);
            result.Append(";");
            result.Append(this.SentOn.ToString());

            bool AppendToFile = true;
            StreamWriter writer = new StreamWriter(filepath, AppendToFile);

            using (writer)
            {
                writer.WriteLine(result.ToString());
            }// adds the new package to the list

            StreamWriter writerOfID = new StreamWriter("lastID.txt");

            using (writerOfID)
            {
                writerOfID.WriteLine(this.ID);  //corrects ID in the file so the next package can have unique ID as well
            }
        }   //adds new package with unique ID to a file
        public static Package Parse(string packageData)
        {
            var packageParams = packageData.Split(';');

            return new Package
            {
                ID = int.Parse(packageParams[0]),
                Destination = packageParams[1],
                ReceiverName = packageParams[2],
                Weight = double.Parse(packageParams[3]),
                SentOn = DateTime.Parse(packageParams[4])
            };
        }   //package Parse
    }
}
