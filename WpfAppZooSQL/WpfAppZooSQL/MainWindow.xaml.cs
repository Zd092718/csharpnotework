﻿using System;
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

            ShowZoos();

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

                //Which table info should be shown in list box
                ListofZoos.DisplayMemberPath = "Location";
                //Which value should be delivered when item from listbox is selected
                ListofZoos.SelectedValuePath = "Id";
                //reference to the data the listbox should populate
                ListofZoos.ItemsSource = zooTable.DefaultView;

            }
        }
    }
}
