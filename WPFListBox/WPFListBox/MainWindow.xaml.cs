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

namespace WPFListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Match> matches = new List<Match>();
            matches.Add(new Match()
            { Team1 = "49ers", Team2 = "Patriots", Score1 = 15, Score2 = 50, Completion = 90 });            matches.Add(new Match()
            { Team1 = "Packers", Team2 = "Patriots", Score1 = 40, Score2 = 50, Completion = 51 });            matches.Add(new Match()
            { Team1 = "Raiders", Team2 = "Buccaneers", Score1 = 10, Score2 = 20, Completion = 75 });            matches.Add(new Match()
            { Team1 = "Chargers", Team2 = "Giants", Score1 = 20, Score2 = 30, Completion = 20 });

            lbMatches.ItemsSource = matches;
        }
    }

    public class Match
    {
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int Completion { get; set; }


    }
}
