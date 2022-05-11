using System;
namespace AlbumPrinter.Api
{
    public class CanvasWidthCalculator : IWidthCalculator
    {
        public CanvasWidthCalculator(double width) : base(width)
        {

        }
        
        public override double CalculateWidth(int quantity)
        {
            return width * quantity;
        }
    }
}