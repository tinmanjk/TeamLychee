namespace PostingServices.PostOffices
{
    using PostingServices.Primitives.Location;

    public class PostOffice
    {
        private string name;
        private Location location;

        //properties

        //constructor
        public PostOffice(string name, Location location)
        {
            this.name = name;
            this.location = location;
        }
    }
}
