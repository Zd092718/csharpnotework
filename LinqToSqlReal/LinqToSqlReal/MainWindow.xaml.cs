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
            //InsertUnis();
            //InsertStudents();
            InsertLectures();
        }

        public void InsertUnis()
        {

            dataContext.ExecuteCommand("delete from University");

            University harvard = new University();
            harvard.Name = "Harvard";
            dataContext.Universities.InsertOnSubmit(harvard);  
            
            University cambridge = new University();
            cambridge.Name = "Cambridge";
            dataContext.Universities.InsertOnSubmit(cambridge);

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Universities;
        }

        public void InsertStudents()
        {
            University harvard = dataContext.Universities.First(un => un.Name.Equals("Harvard"));
            University cambridge = dataContext.Universities.First(un => un.Name.Equals("Cambridge"));


            List<Student> students = new List<Student>();

            students.Add(new Student { Name = "Zack", Gender = "Male", UniversityId = harvard.Id});
            students.Add(new Student { Name = "Allie", Gender = "Female", UniversityId = harvard.Id});
            students.Add(new Student { Name = "Bennet", Gender = "Male", UniversityId = cambridge.Id});
            students.Add(new Student { Name = "Christina", Gender = "Female", University = cambridge});

            dataContext.Students.InsertAllOnSubmit(students);
            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;

        }

        public void InsertLectures()
        {
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "Math" });
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "History" });
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "English" });

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource= dataContext.Lectures;
        }

        public void InsertStudentLectureAssociations()
        {
            Student Zack = dataContext.Students.First(st => st.Name.Equals("Zack"));
            Student Allie = dataContext.Students.First(st => st.Name.Equals("Allie"));
            Student Christina = dataContext.Students.First(st => st.Name.Equals("Christina"));
            Student Bennet = dataContext.Students.First(st => st.Name.Equals("Bennet"));

            Lecture Math = dataContext.Lectures.First(le => le.Name.Equals("Math"));
            Lecture History = dataContext.Lectures.First(le => le.Name.Equals("History"));
            Lecture English = dataContext.Lectures.First(le => le.Name.Equals("English"));
            Lecture Science = dataContext.Lectures.First(le => le.Name.Equals("Science"));
        }
    }
}
