using System.Collections.Generic;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows.Media;
using System.Linq;

namespace Sorting
{
    class BlockDrawer : Drawer
    {
        public BlockDrawer(Canvas canvas) : base(canvas) { }

        protected override Shape CreateShape(List<int> array, int index)
        {
            double width = canvas.ActualWidth / array.Count;
            Shape s = ShapeFactory.GetShape("rectangle", width, ((double)array[index] / array.Max()) * canvas.ActualHeight);
            this.SetShapeCoordinates(s, index * width, 0);
            return s;
        }
    }
}
