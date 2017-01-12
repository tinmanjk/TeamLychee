using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostalSystem
{
    class Order
    {
        private int IdNumber;

        private DateTime Date;

        private Person Sender;

        private Person Recipient;

        private Employee AcceptedBy;

        private Package PackageType;

        private Destination AddresstoDeliver; 

        private bool Urgent;

        private double Price;

    }
}
