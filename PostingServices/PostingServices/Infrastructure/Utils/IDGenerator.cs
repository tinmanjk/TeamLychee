namespace Infrastructure.Utils
{
    using System.Threading;

    public static class IDGenerator
    {
        private static int counter;

        // Static constructor to initialize first id.
        static IDGenerator()
        {
            counter = 0;
        }

        // Thread safe method to generate unique ids.
        public static int GenerateUniqueID()
        {
            return Interlocked.Increment(ref counter);
        }
    }
}
