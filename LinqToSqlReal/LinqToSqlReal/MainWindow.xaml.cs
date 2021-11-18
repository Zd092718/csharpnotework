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
            //InsertLectures();
            //InsertStudentLectureAssociations();
            //GetUniOfZack();
            //GetLectsForZack();
            //GetAllStudentsFromHarvard();
            //GetAllUnisWithFemales();
            //GetAllLecturesFromHarvard();
            //UpdateZack();
            DeleteZack();
        }

        public void InsertUnis()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InsertStudents()
        {
            try
            {
                University harvard = dataContext.Universities.First(un => un.Name.Equals("Harvard"));
                University cambridge = dataContext.Universities.First(un => un.Name.Equals("Cambridge"));


                List<Student> students = new List<Student>();

                students.Add(new Student { Name = "Zack", Gender = "Male", UniversityId = harvard.Id });
                students.Add(new Student { Name = "Allie", Gender = "Female", UniversityId = harvard.Id });
                students.Add(new Student { Name = "Bennet", Gender = "Male", UniversityId = cambridge.Id });
                students.Add(new Student { Name = "Christina", Gender = "Female", University = cambridge });

                dataContext.Students.InsertAllOnSubmit(students);
                dataContext.SubmitChanges();

                MainDataGrid.ItemsSource = dataContext.Students;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void InsertLectures()
        {
            try
            {
                dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "Math" });
                dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "History" });
                dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "English" });

                dataContext.SubmitChanges();

                MainDataGrid.ItemsSource = dataContext.Lectures;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InsertStudentLectureAssociations()
        {
            try
            {
                Student Zack = dataContext.Students.First(st => st.Name.Equals("Zack"));
                Student Allie = dataContext.Students.First(st => st.Name.Equals("Allie"));
                Student Christina = dataContext.Students.First(st => st.Name.Equals("Christina"));
                Student Bennet = dataContext.Students.First(st => st.Name.Equals("Bennet"));

                Lecture Math = dataContext.Lectures.First(le => le.Name.Equals("Math"));
                Lecture History = dataContext.Lectures.First(le => le.Name.Equals("History"));
                Lecture English = dataContext.Lectures.First(le => le.Name.Equals("English"));


                //alternate way is to create objects separately and assign the properties in other lines 
                dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Zack, Lecture = Math });
                dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Zack, Lecture = History });
                dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Allie, Lecture = Math });
                dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Bennet, Lecture = English });
                dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Bennet, Lecture = History });


                dataContext.SubmitChanges();

                MainDataGrid.ItemsSource = dataContext.StudentLectures;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GetUniOfZack()
        {
            try
            {
                Student Zack = dataContext.Students.First(st => st.Name.Equals("Zack"));
                University ZdUni = Zack.University;

                List<University> universities = new List<University>();
                universities.Add(ZdUni);


                MainDataGrid.ItemsSource = universities;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GetLectsForZack()
        {
            try
            {
                Student Zack = dataContext.Students.First(st => st.Name.Equals("Zack"));

                var zacksLectures = from sl in Zack.StudentLectures select sl.Lecture;

                MainDataGrid.ItemsSource = zacksLectures;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GetAllStudentsFromHarvard()
        {
            var students = from student in dataContext.Students
                           where student.University.Name == "Harvard"
                           select student;

            MainDataGrid.ItemsSource = students;
        }

        public void GetAllUnisWithFemales()
        {
            var students = from student in dataContext.Students
                           join university in dataContext.Universities
                           on student.University equals university
                           where student.Gender == "Female"
                           select university;

            MainDataGrid.ItemsSource = students;
        }

        public void GetAllLecturesFromHarvard()
        {
            var lectures = from sl in dataContext.StudentLectures
                           join student in dataContext.Students on sl.StudentId equals student.Id
                           where student.University.Name == "Harvard"
                           select sl.Lecture;

            MainDataGrid.ItemsSource = lectures;
        }

        public void UpdateZack()
        {
            try
            {
                Student Zack = dataContext.Students.FirstOrDefault(st => st.Name == "Zack");

                Zack.Name = "ZD";

                dataContext.SubmitChanges();

                MainDataGrid.ItemsSource = dataContext.Students;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteZack()
        {
            try
            {
                Student Zack = dataContext.Students.FirstOrDefault(st => st.Name == "ZD");

                dataContext.Students.DeleteOnSubmit(Zack);
                dataContext.SubmitChanges();

                string connection = ConfigurationManager.ConnectionStrings["LinqToSqlReal.Properties.Settings.C_DBCLASSConnectionString"].ConnectionString;

                LinqToSqlDataClassesDataContext db = new LinqToSqlDataClassesDataContext(connection);

                MainDataGrid.ItemsSource = db.Students;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
