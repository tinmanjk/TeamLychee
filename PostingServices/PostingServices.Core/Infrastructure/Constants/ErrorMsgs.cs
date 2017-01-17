using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostingServices.Core.Infrastructure.Constants
{
    public class ErrorMsgs
    {
        // String lengths
        public const int MinNameLength = 2;
        public const int MaxNameLength = 20;
        public const int PhoneNumberLength = 10;

        public const int MinCityNameLength = 2;
        public const int MaxCityNameLength = 40;
        public const int MinStreetNameLength = 3;
        public const int MaxStreetNameLength = 60;

        public const int MinStreetNumberLength = 1;
        public const int MaxStreetNumberLength = 999999;

        public const double MinWidth = 0.1;
        public const double MaxWidth = 2;
        public const double MinHeight = 0.1;
        public const double MaxHeight = 2;
        public const double MinLength = 0.1;
        public const double MaxLength = 2.5;
        public const double MinWeight = 0.01;
        public const double MaxWeight = 50;


        // Strings for validation
        public const string StringMustBeBetweenMinAndMax = "{0} must be between {1} and {2} characters long!";
        public const string NumberMustBeBetweenMinAndMax = "{0} must be between {1} and {2}!";

        public const string NumberMustBeEqual = "{0} must be {1} numbers long";

        // Strings for vehicles, comments and users
        public const string InvalidSymbols = "{0} contains invalid symbols!";


        public const string PropertyCannotBeNull = "{0} cannot be null!";

    }
}
