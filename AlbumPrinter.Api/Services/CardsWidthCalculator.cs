using System;
namespace AlbumPrinter.Api
{
    public class CardsWidthCalculator : IWidthCalculator
    {
        public CardsWidthCalculator(double width) : base(width)
        {

        }
        
        public override double CalculateWidth(int quantity)
        {
            return width * quantity;
        }
    }
}