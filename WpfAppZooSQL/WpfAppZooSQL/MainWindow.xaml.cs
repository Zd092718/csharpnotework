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

            ShowZoos();
            ShowAnimals();
        }
        //show all zoos
        private void ShowZoos()
        {
            //try catch should be used when using db
            try
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
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }        
        //show all animals
        private void ShowAnimals()
        {
            //try catch should be used when using db
            try
            {
                string query = "select * from Animal";
                //sqldataAdapter can be seen as an interface to make tables usable by c sharp objects
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);

                using (adapter)
                {
                    DataTable animalTable = new DataTable();

                    adapter.Fill(animalTable);

                    //Which table info should be shown in list box
                    ListOfAllAnimals.DisplayMemberPath = "Name";
                    //Which value should be delivered when item from listbox is selected
                    ListOfAllAnimals.SelectedValuePath = "Id";
                    //reference to the data the listbox should populate
                    ListOfAllAnimals.ItemsSource = animalTable.DefaultView;

                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }       
        //show animals associated with specific zoos
        private void ShowAssociatedAnimals()
        {
            //try catch should be used when using db
            try
            {
                string query = "select * from Animal a inner join ZooAnimal za " +
                    "on a.Id = za.AnimalId where za.ZooId = @ZooId";

                SqlCommand command = new SqlCommand(query, sqlConnection);
                //sqldataAdapter can be seen as an interface to make tables usable by c sharp objects
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                using (adapter)
                {

                    command.Parameters.AddWithValue("@ZooId", ListofZoos.SelectedValue);

                    DataTable animalTable = new DataTable();

                    adapter.Fill(animalTable);

                    //Which table info should be shown in list box
                    ListOfAssociatedAnimals.DisplayMemberPath = "Name";
                    //Which value should be delivered when item from listbox is selected
                    ListOfAssociatedAnimals.SelectedValuePath = "Id";
                    //reference to the data the listbox should populate
                    ListOfAssociatedAnimals.ItemsSource = animalTable.DefaultView;

                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }

        //Displays animals associated with zoos
        private void ListofZoos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowAssociatedAnimals();
            ShowSelectedZooInTextBox();
        }

        //delete zoos
        private void Delete_Zoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "delete from Zoo where id = @ZooId";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                cmd.Parameters.AddWithValue("@ZooId", ListofZoos.SelectedValue);
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
            finally
            {
                sqlConnection.Close();

                ShowZoos();
            }



        }

        //Delete animal from all animals
        private void Delete_Animal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "delete from Animal where id = @AnimalId";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                cmd.Parameters.AddWithValue("@AnimalId", ListOfAllAnimals.SelectedValue);
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                sqlConnection.Close();

                ShowAnimals();
            }
        }
        //add new zoo
        private void Add_Zoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "insert into Zoo values (@Location)";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                cmd.Parameters.AddWithValue("@Location", inputBox.Text);
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                sqlConnection.Close();

                ShowZoos();
            }
        }       
        //add new animal
        private void Add_Animal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "insert into Animal values (@Name)";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                cmd.Parameters.AddWithValue("@Name", inputBox.Text);
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                sqlConnection.Close();

                ShowAnimals();
            }
        }
        //add animal to zoo 
        private void Add_Animal_To_Zoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "insert into ZooAnimal values (@ZooId, @AnimalId)";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                cmd.Parameters.AddWithValue("@AnimalId", ListOfAllAnimals.SelectedValue);
                cmd.Parameters.AddWithValue("@ZooId", ListofZoos.SelectedValue);
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                sqlConnection.Close();

                ShowZoos();
                ShowAssociatedAnimals();
            }
        }       
        //displays selected zoo in the text box
        private void ShowSelectedZooInTextBox()
        {
            try
            {
                string query = "select location from Zoo where id = @ZooId";

                SqlCommand command = new SqlCommand(query, sqlConnection);
                //sqldataAdapter can be seen as an interface to make tables usable by c sharp objects
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                using (adapter)
                {

                    command.Parameters.AddWithValue("@ZooId", ListofZoos.SelectedValue);

                    DataTable zooTable = new DataTable();

                    adapter.Fill(zooTable);

                    inputBox.Text = zooTable.Rows[0]["Location"].ToString();

                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }       
        //displays selected animal in the text box
        private void ShowSelectedAnimalInTextBox()
        {
            try
            {
                string query = "select name from Animal where id = @AnimalId";

                SqlCommand command = new SqlCommand(query, sqlConnection);
                //sqldataAdapter can be seen as an interface to make tables usable by c sharp objects
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                using (adapter)
                {

                    command.Parameters.AddWithValue("@AnimalId", ListOfAllAnimals.SelectedValue);

                    DataTable animalTable = new DataTable();

                    adapter.Fill(animalTable);

                    inputBox.Text = animalTable.Rows[0]["Name"].ToString();

                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }

        private void ListOfAllAnimals_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowSelectedAnimalInTextBox();
        }
        //Update Zoo location
        private void Update_Zoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "update Zoo Set location = @Location where Id = @ZooId";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                cmd.Parameters.AddWithValue("@ZooId", ListofZoos.SelectedValue);
                cmd.Parameters.AddWithValue("@Location", inputBox.Text);
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                sqlConnection.Close();

                ShowZoos();
            }
        }        
        //Update animal name
        private void Update_Animal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "update Animal Set name = @Name where Id = @AnimalId";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                cmd.Parameters.AddWithValue("@AnimalId", ListOfAllAnimals.SelectedValue);
                cmd.Parameters.AddWithValue("@Name", inputBox.Text);
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                sqlConnection.Close();

                ShowAnimals();
            }
        }
    }
}
