using System;
using System.Linq;
using System.Xml.Linq;

namespace LinqWithXML
{
    class Program
    {
        static void Main(string[] args)
        {

            //We simply apply our Student-Structure to XML. 
            string studentsXML =
                        @"<Students>
                            <Student>
                                <Name>Toni</Name>
                                <Age>21</Age>
                                <University>Yale</University>
                                <Semester>6</Semester>
                                <Degree>Computer Science</Degree>
                            </Student>
                            <Student>
                                <Name>Carla</Name>
                                <Age>17</Age>
                                <University>Yale</University>
                                <Semester>1</Semester>
                                <Degree>Biology</Degree>
                            </Student>
                            <Student>
                                <Name>Leyla</Name>
                                <Age>19</Age>
                                <University>Beijing Tech</University>
                                <Semester>3</Semester>
                                <Degree>History</Degree>    
                            </Student>
                            <Student>
                                <Name>Frank</Name>
                                <Age>25</Age>
                                <University>Beijing Tech</University>
                                <Semester>10</Semester>
                                <Degree>Chemistry</Degree>
                            </Student>                   
                            <Student>
                                <Name>Garrett</Name>
                                <Age>25</Age>
                                <University>Fort Lewis College</University>
                                <Semester>10</Semester>
                                <Degree>History</Degree>
                            </Student>
                        </Students>";

            //grab xml with XDocument and parse the xml with Xdocument.Parse
            XDocument xStudents = new XDocument();
            xStudents = XDocument.Parse(studentsXML);

            //create a new collection based off of entered xml values
            var students = from student in xStudents.Descendants("Student")
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = student.Element("Age").Value,
                               University = student.Element("University").Value,
                               Degree = student.Element("Degree").Value
                           };

            foreach (var student in students)
            {
                Console.WriteLine($"Student {student.Name} is {student.Age} " +
                    $"and goes to {student.University} while studying {student.Degree}");
            }



            var sortedStudents = from student in students
                                 orderby student.Age
                                 select student;

            Console.WriteLine("Students sorted by age: ");

            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"Student {student.Name} is {student.Age} " +
                    $"and goes to {student.University}");
            }
            Console.ReadLine();
        }
    }
}
