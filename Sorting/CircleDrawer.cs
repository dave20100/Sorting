//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Windows.Controls;
//using System.Windows.Media;
//using System.Windows.Shapes;

//namespace Sorting
//{
//    class CircleDrawer : Drawer
//    {

//        public CircleDrawer(Canvas canvas): base(canvas) {}

//        public override void Draw(List<int> array)
//        {
//            canvas.Children.Clear();
//            double width = canvas.ActualWidth / array.Count;
//            for (int i = 0; i < array.Count; i++)
//            {
//                Shape s = ShapeFactory.GetShape("ellipse", width, ((double)array[i] / array.Max()) * canvas.ActualHeight);

//                Canvas.SetLeft(s, i * width);
//                Canvas.SetBottom(s, 0);

//                canvas.Children.Add(s);
//            }
//        }
//    }
//}
