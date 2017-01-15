- OrdersContainer will be a static class so we can use calls like "OrdersContainer.Add(order)
- OrdersContainer will have methods for
	* tracking (based on estimated delivery date of order and datetime.now)
	* adding an order. new Order(Package, uniqueID, estDeliveryDate etc.)
	* marking an order as delivered
	* grouping orders for given sender or receiver (might use LINQ or extension methods)
- think of implementation of some type of events (for notification or something else)

**** feel free to add more ****

- made working for sending, delivery time needs to be fixed
- have to write properties for most of the classes
- optimize code (since looking a bit badly now)