using System;
using PostingServices.Core.Infrastructure.Utils;
using PostingServices.Core.Models.Orders;
using PostingServices.Core.Models.PostOffices;
using PostingServices.Core.Infrastructure.Constants;
using System.Device.Location;
using PostingServices.Core.Infrastructure.Enumerations;
using PostingServices.Core.Models.People;
using PostingServices.Core.Models.Primitives;
using PostingServices.Core.Models.Shipments;

namespace PostingServices
{


    class Program
    {
        static void Main()
        {
            ConsoleKeyInfo keyinfo;
            TimeWalker tw = new TimeWalker();


            PostEngine.StartUp(tw.GetCurrentTime());

            do
            {
                keyinfo = Console.ReadKey();
                if (keyinfo.Key == ConsoleKey.RightArrow)
                {
                    tw.StepForward();
                    PostEngine.UpdateScreen(tw.GetCurrentTime());
                }

                if (keyinfo.Key == ConsoleKey.Add)
                {
                    tw.MoveTimeFaster();
                    PostEngine.UpdateScreen(tw.GetCurrentTime());
                }

                if (keyinfo.Key == ConsoleKey.Subtract)
                {
                    tw.MoveTimeSlower();
                    PostEngine.UpdateScreen(tw.GetCurrentTime());
                }

                if (keyinfo.Key == ConsoleKey.N)
                {
                    Console.Clear();

                    Console.WriteLine("Sender first name:");
                    string senderFName = Console.ReadLine();
                    Console.WriteLine("Sender last name:");
                    string senderLName = Console.ReadLine();
                    Console.WriteLine("Sender Phone number:");
                    string senderPhone = Console.ReadLine();

                    Sender sender = new Sender(senderFName, senderLName, senderPhone);

                    Console.WriteLine("Receiver first name:");
                    string receiverFName = Console.ReadLine();
                    Console.WriteLine("Receiver last name:");
                    string receiverLName = Console.ReadLine();
                    Console.WriteLine("Receiver phone number:");
                    string receiverPhone = Console.ReadLine();                    

                    Console.WriteLine("Receiver address:");
                    Console.WriteLine("City:");
                    string receiverCity = Console.ReadLine();
                    Console.WriteLine("Street name:");
                    string receiverStreet = Console.ReadLine();
                    Console.WriteLine("Street number");
                    int receiverStreetNumber = int.Parse(Console.ReadLine());

                    Address receiverAddress = new Address(receiverCity, receiverStreet, receiverStreetNumber);
                    Receiver receiver = new Receiver(receiverFName, receiverLName, receiverPhone, receiverAddress);

                    Console.WriteLine("Sending post-office");
                    string postOffice = Console.ReadLine();
                    PostOffice officeSentFrom;
                    switch (postOffice)
                    {
                        case "Sofia":
                            officeSentFrom = new PostOffice("HQ Sofia", CityLocations.sofia);
                            break;
                        case "Burgas":
                            officeSentFrom = new PostOffice("HQ Burgas", CityLocations.burgas);
                            break;
                        case "Varna":
                            officeSentFrom = new PostOffice("HQ Varna", CityLocations.varna);
                            break;
                        case "Plovdiv":
                            officeSentFrom = new PostOffice("HQ Plovdiv", CityLocations.plovdiv);
                            break;
                        case "Ruse":
                            officeSentFrom = new PostOffice("HQ Ruse", CityLocations.ruse);
                            break;
                        case "Veliko Tarnovo":
                            officeSentFrom = new PostOffice("HQ Veliko Tarnovo", CityLocations.velikoTarnovo);
                            break;
                        default:
                            officeSentFrom = new PostOffice("Middle of nowhere", new GeoCoordinate(0, 0));
                            break;
                    }
                    Console.WriteLine("Destination post-office:");
                    postOffice = Console.ReadLine();
                    PostOffice officeSentTo;
                    switch (postOffice)
                    {
                        case "Sofia":
                            officeSentTo = new PostOffice("HQ Sofia", CityLocations.sofia);
                            break;
                        case "Burgas":
                            officeSentTo = new PostOffice("HQ Burgas", CityLocations.burgas);
                            break;
                        case "Varna":
                            officeSentTo = new PostOffice("HQ Varna", CityLocations.varna);
                            break;
                        case "Plovdiv":
                            officeSentTo = new PostOffice("HQ Plovdiv", CityLocations.plovdiv);
                            break;
                        case "Ruse":
                            officeSentTo = new PostOffice("HQ Ruse", CityLocations.ruse);
                            break;
                        case "Veliko Tarnovo":
                            officeSentTo = new PostOffice("HQ Veliko Tarnovo", CityLocations.velikoTarnovo);
                            break;
                        default:
                            officeSentTo = new PostOffice("Middle of nowhere", new GeoCoordinate(0, 0));
                            break;
                    }
                    Console.WriteLine("Delivery type [regular/priority/THEFLASH :");
                    string deliveryType = Console.ReadLine();
                    DeliveryType delivery;
                    switch (deliveryType)
                    {
                        case "regular":
                            delivery = DeliveryType.Regular;
                            break;
                        case "priority":
                            delivery = DeliveryType.Priority;
                            break;
                        case "THEFLASH":
                            delivery = DeliveryType.TheFlash;
                            break;
                        default:
                            delivery = DeliveryType.Regular;
                            break;
                    }

                    Console.WriteLine("Parcel/Letter:");
                    string shipmentType = Console.ReadLine();
                    Shipment shipment;
                    switch (shipmentType)
                    {
                        case "Parcel":
                            Console.WriteLine("Enter dimensions as follows Width, Height, Length, Weight:");
                            double width = double.Parse(Console.ReadLine());
                            double height = double.Parse(Console.ReadLine());
                            double length = double.Parse(Console.ReadLine());
                            double weight = double.Parse(Console.ReadLine());
                            Dimensions dimensions = new Dimensions(width, height, length, weight);
                            Console.WriteLine("What is the content of the parcel:");
                            string parcelContent = Console.ReadLine();
                            shipment = new Parcel(sender, receiver, officeSentFrom, officeSentTo, delivery, dimensions, parcelContent);
                            break;
                        default:
                            Console.WriteLine("Letter paper size [a4,a5,DL]:");
                            string paperSize = Console.ReadLine();
                            PaperSize size;
                            if(paperSize == "a4")
                            {
                                size = PaperSize.A4;
                            }
                            else if(paperSize == "a5")
                            {
                                size = PaperSize.A5;
                            }
                            else if(paperSize == "DL")
                            {
                                size = PaperSize.DL;
                            }
                            else
                            {
                                size = PaperSize.A6;
                            }
                            Console.WriteLine("Text of letter:");
                            string text = Console.ReadLine();
                            shipment = new Letter(sender, receiver, officeSentFrom, officeSentTo, delivery, size, text);
                            break;
                    }
                    sender.SendShipment(shipment);

                }

            } while (keyinfo.Key != ConsoleKey.Q);


            // post offices are defined manually, can be kept in a file (might not be the best option)
            // new sender
            // new receiver
            // new shipment
            // use sender.Send(...) or PostOffice.Send(...)
            // 
            // what Send does is:
            // new Shipment(sender, receiver, sentFrom office, sentTo office, delivery type)
            // make a new Order(of the shipment)
            // add that order in the orders container
            // unique ID is displayed to the sender
            //
            // * can add functionalities:
            // - every time the program is started orders to check if they are later than DateTime.Now and mark themselves received
            // - track : enter the order ID, OrdersContainer searches in its list for the ID and displays information
            // - not sure how to add events
            // - interfaces for different classes which might contain the methods
            //
            // * can add a few more types of shipments in order to get the required number of classes/depth of inheritance
            // *         

            //Sender sender = new Sender("Gosho Sender", "+359888888");
            //Address receiverAddress = new Address("Sofia", "Gorno nanadolnishte", 10);
            //Receiver receiver = new Receiver("Gosho", "+88888+", receiverAddress);

            //PostOffice officeSofia = new PostOffice("HQ Sofia", CityLocations.sofia);
            //PostOffice officeBurgas = new PostOffice("HQ Burgas", CityLocations.burgas);
            //string text = "Hope this thing works";

            //Shipment shipment1 = new Letter(sender, receiver, officeSofia, officeBurgas, DeliveryType.TheFlash, PaperSize.A4, text);
            //Shipment shipment2 = new Letter(sender, receiver, officeSofia, officeBurgas, DeliveryType.Regular, PaperSize.A4, text);
            //Shipment shipment3 = new Letter(sender, receiver, officeSofia, officeBurgas, DeliveryType.Priority, PaperSize.A4, text);
            //sender.SendShipment(shipment1);
            //sender.SendShipment(shipment2);
            //sender.SendShipment(shipment3);

            //Console.WriteLine("Orders:");
            //foreach (var item in OrdersContainer.Orders)
            //{
            //    Console.WriteLine(item);
            //}

            //Shipment shipmentToSend = new Shipment(sender, receiver, ...)
        }
    }
}
