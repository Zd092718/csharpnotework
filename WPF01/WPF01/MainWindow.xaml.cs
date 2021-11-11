using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Create your own dependency property
        //public int MyProperty
        //{
        //    get { return (int)GetValue(myDependencyProperty); }
        //    set { SetValue(myDependencyProperty, value); } 

        //}

        //public static readonly DependencyProperty myDependencyProperty =
        //    DependencyProperty.Register("MyProperty", typeof(int), typeof(MainWindow), new PropertyMetadata(0));

        public MainWindow()
        {
            InitializeComponent();
            //Grid grid = new Grid();
            //this.Content = grid;
            //Button button = new Button();
            //button.FontSize = 26;
            //button.Height = 100;
            //button.Width = 100;

            //WrapPanel wrapPanel = new WrapPanel();
            //TextBlock textBlock = new TextBlock();
            //textBlock.Text = "Multi";
            //textBlock.Foreground = Brushes.Blue;
            //wrapPanel.Children.Add(textBlock);

            //textBlock = new TextBlock();
            //textBlock.Text = "Color";
            //textBlock.Foreground = Brushes.Red;
            //wrapPanel.Children.Add(textBlock);

            //textBlock = new TextBlock();
            //textBlock.Text = "Button";
            //textBlock.Foreground = Brushes.AliceBlue;
            //wrapPanel.Children.Add(textBlock);

            //button.Content = wrapPanel;
            //grid.Children.Add(button);

        }

        //event handler function
        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("Thanks for clicking me");
        //}



        //Routed events - Wpf mechanism to handle events 
        //Direct routed events  - handled by the item itself i.e. click
        //Bubbling event - event at top of the hierarchy
        //tunneling event - event at bottom of heirarchy
        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("Button was clicked - direct event");
        //}

        //private void Button_MouseUp(object sender, MouseButtonEventArgs e)
        //{
        //    MessageBox.Show("Mouse button went up / was released - bubbling event");
        //}

        //private void Button_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        //{
        //    MessageBox.Show("Mouse button went up / was released - tunneling event");
        //}

        //private void Button_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    MessageBox.Show("Left Mouse button went down / was not released - tunneling event");
        //}

        //private void Button_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    MessageBox.Show("Right Mouse button went down / was not released - tunneling event");
        //}

    }
}
