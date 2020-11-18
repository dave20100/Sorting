using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Sorting
{
    class CircleDrawer : Drawer
    {

        public CircleDrawer(Canvas canvas) : base(canvas) { }

        protected override Shape CreateShape(List<int> array, int index)
        {
            double step = canvas.ActualWidth/ array.Count;
            double r = 10;
            Shape s = ShapeFactory.GetShape("ellipse", r, r);
            double y = array[index] * 1.0 / array.Max() * canvas.ActualHeight - r;
            if(y < 0)
            {
                y = 0;
            }
            SetShapeCoordinates(s, step * index, y) ;
            return s;
        }
    }
}
