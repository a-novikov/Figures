using System;
using System.Windows;

namespace Figures
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Circle(object sender, RoutedEventArgs e)
        {
            MyGrid.Children.Clear();
            MyGrid.Children.Add(new Elements().GetEllipse(true));
        }

        private void Ellipse(object sender, RoutedEventArgs e)
        {
            MyGrid.Children.Clear();
            MyGrid.Children.Add(new Elements().GetEllipse(false));
        }

        private void Triangle(object sender, RoutedEventArgs e)
        {
            MyGrid.Children.Clear();
            MyGrid.Children.Add(new Elements().GetFigure(3));
        }

        private void Square(object sender, RoutedEventArgs e)
        {
            MyGrid.Children.Clear();
            MyGrid.Children.Add(new Elements().GetRectangle(true));
        }

        private void Rectangle(object sender, RoutedEventArgs e)
        {
            MyGrid.Children.Clear();
            MyGrid.Children.Add(new Elements().GetRectangle(false));
        }

        private void Figure(object sender, RoutedEventArgs e)
        {
            MyGrid.Children.Clear();
            MyGrid.Children.Add(new Elements().GetFigure(Convert.ToInt32(MySlider.Value)));
        }


        private void SliderChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (CountTextBlock != null)
            {
                CountTextBlock.Text = MySlider.Value.ToString();
            }
            
        }
    }
}
