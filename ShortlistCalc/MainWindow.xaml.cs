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

namespace ShortlistCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class ShortlistModel
        {
            public string _symbol = string.Empty;
            public DateTime _startDate;
            public DateTime _endDate;
            public double _movementPrice = 0.0;
            public double _average = 0.0;

            public int GetWeeks()
            {
                return (int) (_endDate - _startDate).TotalDays / 7;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ShortlistModel sl = new ShortlistModel();
            sl._startDate = (DateTime) StartDate.SelectedDate;
            sl._endDate = (DateTime) EndDate.SelectedDate;
            MessageBox.Show("Weeks: " + sl.GetWeeks());
        }
    }
}
