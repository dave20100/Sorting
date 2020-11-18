using System.Collections.Generic;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows.Media;
using System.Linq;

namespace Sorting
{
    class BlockDrawer : Drawer
    {
        Canvas canvas;

        public BlockDrawer(Canvas canvas)
        {
            this.canvas = canvas;
            SortingAlgorithms.OnChange += SortingAlgorithms_Notify;
        }


        public void Draw(List<int> array) {
            canvas.Children.Clear();
            double width = canvas.ActualWidth / array.Count;
            for (int i = 0; i < array.Count; i++)
            {
                Shape s = ShapeFactory.GetShape("rectangle", width, ((double)array[i] / array.Max()) * canvas.ActualHeight);
                
                Canvas.SetLeft(s, i * width);
                Canvas.SetBottom(s, 0);

                canvas.Children.Add(s);
            }
        }

        private void SortingAlgorithms_Notify(object sender, ElementsEventArgs e)
        {
            Draw(e.Elements);
        }
    }
}
