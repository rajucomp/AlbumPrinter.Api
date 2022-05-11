using System;
namespace AlbumPrinter.Api
{
    public class CalendarWidthCalculator : IWidthCalculator
    {
        public CalendarWidthCalculator(double width) : base(width)
        {

        }
        
        public override double CalculateWidth(int quantity)
        {
            return width * quantity;
        }
    }
}