namespace PostingServices.Core.Contracts
{
    using PostingServices.People;

    interface IShipment
    {
        int Id { get; }
        Person Sender { get; } // TODO should be an interface
        Person Receiver { get; } // TODO should be an interface

    }
}
