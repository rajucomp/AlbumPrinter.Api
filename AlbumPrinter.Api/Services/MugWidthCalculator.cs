using System;
namespace AlbumPrinter.Api
{
    public class MugWidthCalculator : IWidthCalculator
    {
        public MugWidthCalculator(double width) : base(width)
        {

        }

        public override double CalculateWidth(int quantity)
        {
            return width * Math.Ceiling(quantity / 4.0);
        }
    }
}