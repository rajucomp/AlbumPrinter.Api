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
