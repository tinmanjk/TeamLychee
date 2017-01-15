namespace PostingServices
{
    using System;
    using TimeWalkerUtility;
    using PostEngineUtility;

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
                    tw.MoveTimeSlower();
                    // new order
                    PostEngine.UpdateScreen(tw.GetCurrentTime());
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
