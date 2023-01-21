using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace WpfApp9_pd
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private int _count;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _count++;
            if (_count == 1)
            {
                DoubleAnimation animation = new DoubleAnimation
                {
                    From = 310,
                    To = 165,
                    Duration = new Duration(TimeSpan.FromSeconds(2))
                };
                pBar.BeginAnimation(ProgressBar.MaximumProperty, animation);
            }
            if (_count == 2)
            {
                DoubleAnimation animation = new DoubleAnimation
                {
                    From = 165,
                    To = 13,
                    Duration = new Duration(TimeSpan.FromSeconds(2))
                };
                pBar.BeginAnimation(ProgressBar.MaximumProperty, animation);
            }
            if (_count == 3)
            {
                DoubleAnimation animation = new DoubleAnimation
                {
                    From = 12,
                    To = 310,
                    Duration = new Duration(TimeSpan.FromSeconds(2))
                };
                pBar.BeginAnimation(ProgressBar.MaximumProperty, animation);
                _count = 0;
            }
        }
    }
}
