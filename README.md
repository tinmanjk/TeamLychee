# TeamLycheePrivate!

# A C# Console application that simulates sending, tracking and receiving of shipments.
# 
# - Current DateTime is replaced with a fixed one which the user is able to move in order to see where his order is at a given time
# - When the date and time become "later" than the delivery date of the shipment an event raised by the time change makes the shipments appear as delivered.
# - Each shipment has: sender, receiver, office to be sent from, office to be sent to, delivery type
# - Each letter has: the above-mentioned properties of shipment as well as paper size(a4, a5, etc.) and text
# - Each parcel has: properties of shipment as well as dimensions(weight, height, length, width) and content
# - The class order contains a shipment as well as a unique ID, estimated delivery date, price
# - The static class orders container contains a list of all orders as well as some methods for handling events, adding orders, etc.
