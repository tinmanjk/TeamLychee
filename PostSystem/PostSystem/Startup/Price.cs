using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startup
{
    public struct Price
    {

        private Distance distance;
        private Package typeOfPackage;
        private bool isUrgent;

        public Distance Distance
        {
            get { return this.distance; }
            set { this.distance = value; }
        }
        public bool IsUrgent
        {
            get { return this.isUrgent; }
            set { this.isUrgent = value; }
        }
        public Package TypeOfPackage
        {
            get { return this.typeOfPackage; }
            set { this.typeOfPackage = value; }
        }

        public double GetPrice()
        {
            int urgentAmplifier = isUrgent ? 2 : 1;
            double packageAmplifier = 1;
            if (typeOfPackage.Size >= 500)
            {
                packageAmplifier = 2;
            }else if (typeOfPackage.Size <= 100)
            {
                packageAmplifier = 1;
            }else
            {
                packageAmplifier = 1.5;
            }
           return (int)this.distance / 5*urgentAmplifier*packageAmplifier;
        }
    }
}
