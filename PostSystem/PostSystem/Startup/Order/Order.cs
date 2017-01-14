using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startup
{
    class Order: IOrder
    {
        private static int idNumber = 1;
        private int id;
        private DateTime date;
        private Customer sender;
        private Customer recipient;
        private Employee acceptedBy;
        private Package packageType;
        private Destination addressToDeliver; 
        private bool urgent;
        private Price price;

        List<Order> listOfOrders = new List<Order>();
        public Order()
        {
            //this.Price = new Price().GetPrice(this.urgent,this.addressToDeliver);
            this.Date = DateTime.Now;
            this.id = idNumber;
            idNumber++;
            OrderList.AddOrder(this);
        }


        public Order(Customer sender, Customer recipient, Employee acceptedBy, Package packageType, Destination addressToDeliver, bool urgent)
        {
            
            this.Sender = sender;
            this.Recipient = recipient;
            this.AcceptedBy = acceptedBy;
            this.packageType = packageType;
            this.AddresstoDeliver = addressToDeliver;
            this.Urgent = urgent;
            this.Date = DateTime.Now;
            this.id = idNumber;
            idNumber++;
            OrderList.AddOrder(this);

        }
    
        public int Id
        {
            get { return this.id; }
        }
        public DateTime Date
        {
            get { return this.date; }
            set { this.date = DateTime.Now; }
        }
        public Customer Sender
        {
            get { return this.sender; }
            set { this.sender = value; }
        }
        public Customer Recipient
        {
            get {return this.recipient; }
            set { this.recipient = value; }
        }
        public Employee AcceptedBy
        {
            get { return this.acceptedBy; }
            set { this.acceptedBy = value; }
        }
        public Package PackageType
        {
            get { return this.packageType; }
            set { this.packageType = value; }
        }
        public Destination AddresstoDeliver
        {
            get { return this.addressToDeliver; }
            set { this.addressToDeliver = value; }
        }
    
        public bool Urgent
        {
        get { return this.urgent; }
        set { this.urgent = value; }
        }
        public Price Price
        {
            get { return this.price; }         
        }
        public List<Order> ListOfOrders
        {
            get;
        }

        

    }
}
