using System;
using System.Text;
using PostingServices.Core.Contracts;
using PostingServices.Core.Infrastructure.Utils;
using PostingServices.Core.Infrastructure.Constants;

namespace PostingServices.Core.Models.Primitives
{
    public struct Dimensions : IDimensions
    {
        private double width;
        private double height;
        private double length;
        private double weight;

        public double Width
        {
            get { return this.width; }
        }
        public double Height
        {
            get { return this.height; }
        }
        public double Length
        {
            get { return this.length; }
        }
        public double Weight
        {
            get { return this.weight; }
        }


        public Dimensions(double width, double height, double length, double weight)
        {
            this.width = width;
            this.height = height;
            this.length = length;
            this.weight = weight;
            ValidateFields();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("Width: {0}\n", this.width);
            result.AppendFormat("Height: {0}\n", this.height);
            result.AppendFormat("Length: {0}\n", this.length);
            result.AppendFormat("Weight: {0}\n", this.weight);

            return result.ToString();
        }
        private void ValidateFields()
        {

            Validator.ValidateNull(this.width, string.Format(ErrorMsgs.PropertyCannotBeNull, "Width"));
            Validator.ValidateDoubleRange(this.width, ErrorMsgs.MinWidth, ErrorMsgs.MaxWidth,
                string.Format(ErrorMsgs.StringMustBeBetweenMinAndMax, "Width", ErrorMsgs.MinWidth, ErrorMsgs.MaxWidth));

            Validator.ValidateNull(this.height, string.Format(ErrorMsgs.PropertyCannotBeNull, "Height"));
            Validator.ValidateDoubleRange(this.height, ErrorMsgs.MinHeight, ErrorMsgs.MaxHeight,
                string.Format(ErrorMsgs.StringMustBeBetweenMinAndMax, "Height", ErrorMsgs.MinHeight, ErrorMsgs.MaxHeight));

            Validator.ValidateNull(this.length, string.Format(ErrorMsgs.PropertyCannotBeNull, "Length"));
            Validator.ValidateDoubleRange(this.length, ErrorMsgs.MinLength, ErrorMsgs.MaxLength,
                string.Format(ErrorMsgs.StringMustBeBetweenMinAndMax, "Length", ErrorMsgs.MinLength, ErrorMsgs.MaxLength));

            Validator.ValidateNull(this.weight, string.Format(ErrorMsgs.PropertyCannotBeNull, "Weight"));
            Validator.ValidateDoubleRange(this.weight, ErrorMsgs.MinWeight, ErrorMsgs.MaxCityNameLength,
                string.Format(ErrorMsgs.StringMustBeBetweenMinAndMax, "Weight", ErrorMsgs.MinCityNameLength, ErrorMsgs.MinWeight));

        }
    }
}
