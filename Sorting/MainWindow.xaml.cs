using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Sorting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Sorter s;
        Drawer d;
      
        public MainWindow()
        {
            InitializeComponent();
            d = new BlockDrawer(canvas);
            s = new Sorter();
            SortingAlgorithms.OnChange += SortingAlgorithms_OnChange;
        }

        private void SortingAlgorithms_OnChange(object sender, ElementsEventArgs e)
        {
            StatsBox.Text = "Iteration: " + e.IterationCount.ToString();
        }


        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            SortingAlgorithms.IsCanceled = true;

            List<int> t = new List<int>();
            int numberOfElements = Int32.Parse(ElementNumberTextBox.Text);
            for (int i = 0; i < numberOfElements; i++)
            {
                Random r = new Random();
                t.Add(r.Next(0, 1000));
            }
            await s.Sort(t);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (algorithmsComboBox.SelectedIndex)
            {
                case 0:
                    s.SetSortingAlgorithm(SortingAlgorithms.Bubble);
                    break;
                case 1:
                    s.SetSortingAlgorithm(SortingAlgorithms.Insertion);
                    break;
                case 2:
                    s.SetSortingAlgorithm(SortingAlgorithms.Bogo);
                    break;
            }
        }
    }
}
