namespace PostingServices.Orders
{
    using Core.Models.Shipment.Abstract;
    using Infrastructure.Enumerations;
    using Infrastructure.Utils;
    using System;
    using System.Text;
    using System.Device.Location;
    using Core;

    public class Order : IOrder
    {
        private static uint uniqueID = 1;
        private int ID;
        private Shipment shipment;
        private DateTime deliveryDate;
        private double price;
        private bool isDelivered;

        //properties
        public DateTime DeliveryDate
        {
            get
            {
                return this.deliveryDate;
            }
            private set
            {
                if (this.shipment.DeliveryType == DeliveryType.TheFlash)
                {
                    int deliveryYear = this.shipment.DateSent.Year;
                    int deliveryMonth = this.shipment.DateSent.Month;
                    int deliveryDay = this.shipment.DateSent.Day;

                    // use a timespan instead as it might be easier

                    int deliveryHour = this.shipment.DateSent.Hour;
                    int deliveryMinute = this.shipment.DateSent.Minute + 5;  //5 min delivery
                    // throws an exception when minutes are over 55
                    this.deliveryDate = new DateTime(deliveryYear, deliveryMonth, deliveryDay, deliveryHour, deliveryMinute, 0);
                }
                //else if-s for other delivery types
            }
        }

        //property to calculate price


        //constructors
        public Order(Shipment shipment)
        {
            this.shipment = shipment;
            this.ID = IDGenerator.GenerateUniqueID();
            this.price = 42;    // can calculate actual price via property based on dimensions or something else
            this.DeliveryDate = DateTime.Now;
            this.Delivery += this.HandleEvent;
        }

        public Order()
        {
            this.Delivery += this.HandleEvent;
        }

        public override string ToString()
        {
            // full description can be added after all properties get implemented
            StringBuilder result = new StringBuilder();
            result.AppendFormat("- ID -- {0}\n", this.ID);
            result.AppendFormat("{0}", this.shipment);
            result.AppendFormat("Delivery date: {0}", this.CalculateDeliveryDate());

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
                double speed = 40; //subject to change (in km/h)
                double hours = distance / speed;
                TimeSpan timeTaken = new TimeSpan((int)hours, 0, 0);    //casting will round

                return dateSent.Add(timeTaken);
            }
            else if(this.shipment.DeliveryType == DeliveryType.Priority)
            {
                double speed = 70; //kmh;
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
