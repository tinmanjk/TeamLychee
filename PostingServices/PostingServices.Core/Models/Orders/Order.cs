using System;
using System.Text;
using System.Device.Location;
using PostingServices.Core.Contracts;
using PostingServices.Core.Models.Shipments;
using PostingServices.Core.Infrastructure.Enumerations;
using PostingServices.Core.Infrastructure.Utils;

namespace PostingServices.Core.Models.Orders
{
    public class Order : IOrder
    {
        //private static uint uniqueID = 1;
        private int ID;
        private Shipment shipment;
        private DateTime deliveryDate;
        private double price;

        //properties
        public DateTime DeliveryDate
        {
            get
            {
                return this.deliveryDate;
            }
            private set
            {
                this.deliveryDate = value;
                //else if-s for other delivery types
            }
        }

        public int Id
        {
            get
            {
                return this.ID;
            }
        }

        public Shipment Shipment
        {
            get
            {
                return this.shipment;
            }
            private set
            {
                this.shipment = value;
            }
        }

        public string ShortDetails
        {
            get
            {
                
                return string.Format("ID: {0} -- Sender {1} -- Receiver {2} --\n"
                    , this.Id, this.shipment.Sender.FirstName, this.shipment.Receiver.FirstName);
            }
        }

        //constructors
        public Order(Shipment shipment)
        {
            this.shipment = shipment;
            this.ID = IDGenerator.GenerateUniqueID();
            this.price = PriceCalculate() / 12000;
            this.DeliveryDate = CalculateDeliveryDate();
        }

        public Order()
        {
            this.Delivery += this.HandleEvent;
        }
        public double PriceCalculate()
        {
            double typeIndex = 1;
            //double sizeIndex = 1;
            if ((int)this.shipment.DeliveryType == 0)
            {
                typeIndex = 1;
            }
            else if ((int)this.shipment.DeliveryType == 1)
            {
                typeIndex = 1.5;
            }
            else
            {
                typeIndex = 2;
            }
            double sizeIndex = (this.shipment is Letter) ? 1 : 2;

            return price = this.shipment.OfficeSentTo.Location.GetDistanceTo(this.shipment.OfficeSentFrom.Location) / 5 * typeIndex * sizeIndex;
        }
        public override string ToString()
        {
            // full description can be added after all properties get implemented
            StringBuilder result = new StringBuilder();

            result.AppendFormat("- ID -- {0}\n", this.ID);
            result.AppendFormat("{0}", this.shipment);
            result.AppendFormat("Delivery date: {0}\n", this.CalculateDeliveryDate());
            result.AppendFormat("Price: {0:F2}$", this.price);
            result.AppendLine();
            result.AppendLine("__________________________");

            return result.ToString();
        }

        public DateTime CalculateDeliveryDate()
        {
            DateTime dateSent = this.shipment.DateSent;
            GeoCoordinate sending = this.shipment.OfficeSentFrom.Location;
            GeoCoordinate receiving = this.shipment.OfficeSentTo.Location;
            double distance = sending.GetDistanceTo(receiving) / 1000;

            if (this.shipment.DeliveryType == DeliveryType.Regular)
            {
                double speed = 5; //subject to change (in km/h)
                double hours = distance / speed;
                TimeSpan timeTaken = new TimeSpan((int)hours, 0, 0);    //casting will round

                return dateSent.Add(timeTaken);
            }
            else if (this.shipment.DeliveryType == DeliveryType.Priority)
            {
                double speed = 10; //kmh;
                double hours = distance / speed;
                TimeSpan timeTaken = new TimeSpan((int)hours, 0, 0);    //casting will round

                return dateSent.Add(timeTaken);
            }
            else
            {
                double speed = 300;
                double hours = distance / speed;
                TimeSpan timeTaken = new TimeSpan((int)hours, 0, 0);

                return dateSent.Add(timeTaken);
            }
        }

        public event EventHandler Delivery;

        public void ShipmentDelivered()
        {
            Delivery?.Invoke(this, EventArgs.Empty);
        }
        public void HandleEvent(object order, EventArgs args)
        {
            Console.WriteLine("Order is delivered");
        }

    }
}
