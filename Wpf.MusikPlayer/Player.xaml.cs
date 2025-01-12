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

namespace Wpf.MusikPlayer
{
    /// <summary>
    /// Interaction logic for Player.xaml
    /// </summary>
    public partial class Player : UserControl
    {
        public Player()
        {
            InitializeComponent();
            this.TimeSlider.Value = 150;
        }

        private void TimeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int totalSeconds = (int)TimeSlider.Value;
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;

            TimeLabel.Content = $"{minutes:D1}:{seconds:D2}";
        }
    }
}
