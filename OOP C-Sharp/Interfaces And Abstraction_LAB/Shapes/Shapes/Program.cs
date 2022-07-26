using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(9);
            circle.Draw();

            Rectangle rectangle = new Rectangle(10, 5);
            rectangle.Draw();
        }
    }
}
