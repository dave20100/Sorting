using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Sorting
{
    static class ShapeFactory
    {
        public static Shape GetShape(string name, double width, double height)
        {
            Shape shape;
            if (name == "rectangle")
            {
                shape = new Rectangle();
            }
            else
            {
                return null;
            }

            shape.Stroke = new SolidColorBrush(Colors.Black);
            shape.Fill = new SolidColorBrush(Colors.Green);
            shape.StrokeThickness = 0.4;
            shape.Width = width;
            shape.Height = height;

            return shape;
        }
    }
}
