using System;
namespace AlbumPrinter.Api
{
    public abstract class IWidthCalculator
    {
        protected double width;

        public IWidthCalculator(double value)
        {
            this.width = value;
        }

        public abstract double CalculateWidth(int quantity);
    }
}
