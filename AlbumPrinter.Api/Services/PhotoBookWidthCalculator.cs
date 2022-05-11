using System;
namespace AlbumPrinter.Api
{
    public class PhotoBookWidthCalculator : IWidthCalculator
    {
        public PhotoBookWidthCalculator(double width): base(width)
        {

        }
        
        public override double CalculateWidth(int quantity)
        {
            return width * quantity;
        }
    }
}