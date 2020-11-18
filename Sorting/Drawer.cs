using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Sorting
{
    abstract class Drawer
    {
        protected Canvas canvas;

        public Drawer(Canvas canvas)
        {
            this.canvas = canvas;
            SortingAlgorithms.OnChange += SortingAlgorithms_Notify;
        }

        public void Draw(List<int> array) {
            this.canvas.Children.Clear();
            for (int i = 0; i < array.Count; i++)
            {
                Shape s = this.CreateShape(array, i);
                this.canvas.Children.Add(s);
            }
        }

        private void SortingAlgorithms_Notify(object sender, ElementsEventArgs e)
        {
            Draw(e.Elements);
        }


        protected void SetShapeCoordinates(Shape s, double x, double y)
        {
            Canvas.SetLeft(s, x);
            Canvas.SetBottom(s, y);
        }

        protected abstract Shape CreateShape(List<int> array, int index);

    }
}
