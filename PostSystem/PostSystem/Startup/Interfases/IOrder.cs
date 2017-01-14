using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startup
{
    public interface IOrder
    {
        int Id
        {
            get;
        }
        DateTime Date
        {
            get;
        }
        Customer Sender
        {
            get;
            set;
        }
        Customer Recipient
        {
            get;
            set;
        }
        Employee AcceptedBy
        {
            get;
            set;       
        }
        Package PackageType
        {
            get;
            set;
        }
        Destination AddresstoDeliver
        {
            get;
            set;
        }
        bool Urgent
        {
            get;
            set;
        }
        Price Price
        {
            get;
        }

    }
}
