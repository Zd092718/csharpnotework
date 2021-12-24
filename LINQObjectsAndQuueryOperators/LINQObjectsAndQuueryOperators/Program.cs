using System;
using System.Collections.Generic;
using System.Linq;
using Log = System.Diagnostics.Debug;

namespace LINQObjectsAndQuueryOperators
{
    class Person
    {
        public string Name;
        public int Age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            UniManager um = new UniManager();
            //um.MaleStudents();
            //um.FemaleStudents();
            //um.SortStudentsByAge();
            //um.AllStudentsFromHarvard();

            /*
            string input = Console.ReadLine();
            try
            {
            int inputAsInt = Convert.ToInt32(input);

            um.AllStudentsFromThatUni(inputAsInt);

            }
            catch (Exception e)
            {

                Console.WriteLine("Wrong entry");
            }
            */

            //um.StudentAndUniversityNameCollection();


            ///Using Linq without sql tags
            //List<Person> people = new List<Person>()
            //{
            //    new Person() { Name = "Zack", Age = 25},
            //    new Person() { Name = "Allie", Age = 26},
            //    new Person() { Name = "Bennet", Age = 32},
            //    new Person() { Name = "Matt", Age = 31}
            //};

            //int oldestPersonAge = people.Select(p => p.Age).Max();

            //Log.WriteLine("The oldest's person's age is " + oldestPersonAge);
            //Console.Read();


            ///Using cast with Linq
            //List<int> collection = new List<int>() { 1, 2, 3};
            //IEnumerable<float> collectionOfFloats = collection.Cast<float>();

            //foreach(var f in collectionOfFloats)
            //{
            //    Log.WriteLine(f);

            //}

            ///Using select and select many
            //List<int> collection = new List<int>() { 1, 2, 3};
            //IEnumerable<int> collectionOfIntsMultipliedBy2 = collection.Select(s => s * 2);
            //foreach (int i in collectionOfIntsMultipliedBy2)
            //{
            //    Log.WriteLine(i.ToString() + " ");
            //}
            //Log.WriteLine(string.Empty);

            //List<List<int>> collections = new List<List<int>>()
            //{
            //    new List<int> { 1, 2, 3 },
            //    new List<int> { 4, 5, 6 },
            //    new List<int> { 7, 8, 9 }
            //};

            //IEnumerable<int> result = collections.SelectMany(c => c);
            //Log.WriteLine(result.Count().ToString());
            //foreach (int i in result)
            //{
            //    Log.Write(i.ToString() + " ");
            //}
            //Log.WriteLine(string.Empty);

            ///OfType and Where
            
        }
    }

    class UniManager
    {
        public List<University> universities;
        public List<Student> students;

        public UniManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            universities.Add(new University { Id = 1, Name = "Yale" });
            universities.Add(new University { Id = 2, Name = "Harvard" });

            
            students.Add(new Student { Id = 1, Name = "Zack", Gender = "Male", Age = 25, UniversityId = 1 });
            students.Add(new Student { Id = 2, Name = "Allie", Gender = "Female", Age = 26, UniversityId = 2 });
            students.Add(new Student { Id = 3, Name = "Bennet", Gender = "Male", Age = 32, UniversityId = 1 });
            students.Add(new Student { Id = 4, Name = "Heather", Gender = "Female", Age = 50, UniversityId = 1 });
            students.Add(new Student { Id = 5, Name = "Matt", Gender = "Male", Age = 31, UniversityId = 2 });
            students.Add(new Student { Id = 6, Name = "Christina", Gender = "Female", Age = 28, UniversityId = 1 });
        }


        //Prints all male students
        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students 
                                                where student.Gender == "Male" select student;

            Console.WriteLine("Male - Students:");

            foreach (Student student in maleStudents)
            {
                student.Print();
            }
        }      

        //Prints all female students
        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students 
                                                where student.Gender == "Female" select student;

            Console.WriteLine("Female - Students:");

            foreach (Student student in femaleStudents)
            {
                student.Print();
            }
        }

        //Prints all students sorted by age
        public void SortStudentsByAge()
        {
            var sortedStudents = from student in students orderby student.Age select student;
            Console.WriteLine($"Student sorted by Age:");

            foreach (Student student in sortedStudents)
            {
                student.Print();
            }
        }

        //Prints All students from harvard
        public void AllStudentsFromHarvard()
        {
            IEnumerable<Student> harvStudents = from student in students
                                                join university in universities on student.UniversityId equals university.Id
                                                where university.Name == "Harvard"
                                                select student;

            Console.WriteLine("Students  who went to Harvard:");
            foreach (Student student1 in harvStudents)
            {
                student1.Print();
            }
        }

        //Prints all students from unis with specified ids
        public void AllStudentsFromThatUni(int Id)
        {
            IEnumerable<Student> uniStudents = from student in students
                                                join university in universities on student.UniversityId equals university.Id
                                                where university.Id == Id
                                                select student;

            Console.WriteLine($"Students who went to University with Id {Id}:");
            foreach (Student student1 in uniStudents)
            {
                student1.Print();
            }
        }

        // Prints all students and their respective universities
        public void StudentAndUniversityNameCollection()
        {
            var newCollection = from student in students
                                join university in universities on student.UniversityId equals university.Id
                                orderby student.Name
                                select new { StudentName = student.Name, UniversityName = university.Name }; //Makes new collection

            Console.WriteLine("New collection:");
            foreach (var col in newCollection)
            {
                Console.WriteLine($"Student {col.StudentName} from University {col.UniversityName}");
            }
                                
        }



    }






    class University
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine($"University {Name} with the Id {Id}");
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int UniversityId { get; set; }

        public void Print()
        {
            Console.WriteLine($"Student {Name} with Id {Id}, Gender {Gender}" +
                $" and Age {Age} from the university with id {UniversityId}.");
        }

    }
}
