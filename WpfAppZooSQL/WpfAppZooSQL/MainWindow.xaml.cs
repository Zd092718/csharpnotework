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
using System.Data.SqlClient;
using System.Data;

namespace WpfAppZooSQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlConnection;
        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings
                ["WpfAppZooSQL.Properties.Settings.C_DBCLASSConnectionString"].ConnectionString;
            
            sqlConnection = new SqlConnection(connectionString);


        }

        private void ShowZoos()
        {
            string query = "select * from Zoo";
            //sqldataAdapter can be seen as an interface to make tables usable by c sharp objects
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);

            using (adapter)
            {
                DataTable zooTable = new DataTable();

                adapter.Fill(zooTable);

                ListofZoos.DisplayMemberPath = "location";
                ListofZoos.SelectedValuePath = "Id";
                ListofZoos.ItemsSource = zooTable.DefaultView;

            }
        }
    }
}
