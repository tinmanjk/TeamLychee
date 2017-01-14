using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostingServices.Shipments;
using PostingServices.Enums;

namespace PostingServices.Orders
{
    public class Order
    {
        private static uint uniqueID = 1;
        private uint ID;
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
                if(this.shipment.DeliveryType == DeliveryType.TheFlash)
                {
                    int deliveryYear = this.shipment.DateSent.Year;
                    int deliveryMonth = this.shipment.DateSent.Month;
                    int deliveryDay = this.shipment.DateSent.Day;
                    
                    int deliveryHour = this.shipment.DateSent.Hour;
                    int deliveryMinute = this.shipment.DateSent.Minute + 5;  //5 min delivery

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
            this.ID = uniqueID;
            uniqueID++;
            this.price = 42;    // can calculate actual price via property based on dimensions or something else
        }

    }
}
