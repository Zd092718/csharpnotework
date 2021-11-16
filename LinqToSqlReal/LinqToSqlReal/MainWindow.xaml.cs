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
using System.Configuration;

namespace LinqToSqlReal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LinqToSqlDataClassesDataContext dataContext;
        public MainWindow()
        {
            InitializeComponent();

            string connection = ConfigurationManager.ConnectionStrings["LinqToSqlReal.Properties.Settings.C_DBCLASSConnectionString"].ConnectionString;
            dataContext = new LinqToSqlDataClassesDataContext(connection);
            InsertUnis();
        }

        public void InsertUnis()
        {
            University harvard = new University();
            harvard.Name = "Harvard";
            dataContext.Universities.InsertOnSubmit(harvard);

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Universities;
        }
    }
}
