namespace PostEngineUtility
{
    using System;
    using System.Text;

    public static class PostEngine
    {

        public static void StartUp(DateTime timestamp)
        {
            DrawScreen(timestamp);
        }

        public static void DrawScreen(DateTime timestamp)
        {
            StringBuilder sbHeader = new StringBuilder();
            StringBuilder sbFooter = new StringBuilder();

            // Warning! Ugly code here...
            // Header
            sbHeader.AppendLine(new String('#', 76))
              .AppendFormat("{0}{1,15}{0}", new String('#', 30), " POSTAL SERVICE ")
              .Append("\n")
              .AppendLine(new String('#', 76));

            sbHeader.AppendLine()
              .AppendFormat("{0,30}{1}", "Today is ", timestamp.ToString("dd.MM.yyyy -- dddd"))
              .Append("\n")
              .AppendFormat("{0,30}{1}", "        Time: ", timestamp.ToString("HH:mm"));

            Console.WriteLine();
            Console.WriteLine(sbHeader.ToString());

            // Here be log
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // Footer
            sbFooter.AppendLine(new String('_', 76))
                    .AppendLine(" TIME CONTROLS: \n")
                    .AppendLine("         * Press 'N' to submit a new Order")
                    .AppendLine("         * Press '->' to step forward")
                    .AppendLine("         * Press '+' to increase step TimeSpan (by 3 hours)")
                    .AppendLine("         * Press '-' to decrease step TimeSpan (by 3 hours)")
                    .AppendLine("         * Press 'Q' to exit")
                    .Append("\n")
                    .AppendLine(new String('#', 76));

            Console.WriteLine(sbFooter.ToString());

        }

        public static void UpdateScreen(DateTime timestamp)
        {
            Console.Clear();
            DrawScreen(timestamp);
        }
    }
}
