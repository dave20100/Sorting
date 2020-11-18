using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Sorting
{
    class CircleDrawer : Drawer
    {

        Canvas canvas;

        public CircleDrawer(Canvas canvas)
        {
            this.canvas = canvas;
            SortingAlgorithms.OnChange += SortingAlgorithms_Notify;
        }


        public void Draw(List<int> array)
        {
            canvas.Children.Clear();
            double width = canvas.ActualWidth / array.Count;
            for (int i = 0; i < array.Count; i++)
            {
                Shape rect = new Ellipse();
                rect.Stroke = new SolidColorBrush(Colors.Black);
                rect.Fill = new SolidColorBrush(Colors.Green);
                rect.Width = width;
                rect.Height = width;
                rect.StrokeThickness = 0.4;

                Canvas.SetLeft(rect, i * width);
                Canvas.SetBottom(rect, 0);

                canvas.Children.Add(rect);
            }
        }


        private void SortingAlgorithms_Notify(object sender, ElementsEventArgs e)
        {
            Draw(e.Elements);
        }
    }
}
