using Met_Abstratos.Entitites.Enums;

namespace Met_Abstratos.Entitites
{
    class Rectangle : Shape
    {

        public double Width { get; set; }

        public double Height { get; set; }


        public Rectangle(double width , double height ,Color color) : base(color) 
        {
            Width = Width;
            Height = Height;
        }
        public override double Area()
        {
            return  Width * Height;
        }
    }
}
