using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Raj", "Simran", "Rahul", "Amit", "Seeta", "Shiv", "Meena" };
            var studentQuery = from student in students
                               where student.Contains('a') 
                               select student;
            foreach( var name in studentQuery)
            {
                Console.WriteLine(name);
            }

            List<Student> dacStudents = new List<Student>();
            dacStudents.Add(new Student { StudentID=1, Name="Manisha Shinde", Age=23});
            dacStudents.Add(new Student { StudentID = 2, Name = "Chitra Patil", Age = 35 });
            dacStudents.Add(new Student { StudentID = 3, Name = "Raveena Sharma", Age = 21 });
            dacStudents.Add(new Student { StudentID = 4, Name = "Sameera Deo", Age = 40 });
            dacStudents.Add(new Student { StudentID = 5, Name = "Raj Kale", Age = 38 });
            dacStudents.Add(new Student { StudentID = 6, Name = "Ganesh Mogarkar", Age = 25 });
            dacStudents.Add(new Student { StudentID = 7, Name = "Sameer Kulkarni", Age = 23 });
            
           //Bussiness Rule

           var  filteredStudents = from student in dacStudents where student.Age > 20 && student.Age < 45 orderby student.Name ascending select student.Name;

            Console.WriteLine("Filtered Students from dac students.....");
            foreach (string name in filteredStudents)
            {
                Console.WriteLine(name);
            }


            IList<string> javaDevelopers = new List<string>() { "Ravi", "Mangesh", "Sanjana", "Rajiv", "Sharan" , "Meenal"};
            IList<string> dotnetDevelopers = new List<string>() { "Rajan", "Naresh", "Ravi", "Sanjana" , "Sharan"};

            var fullStackDevelopers = javaDevelopers.Join(dotnetDevelopers,   //  targetted list
                                                           dotnet=>dotnet,   // first collections selector
                                                           java=>java,       // second collections  selector
                                                           (java, dotnet) => java);


            //List<string> developers = fullStackDevelopers.ToList();

            Console.WriteLine("All Developers with both skills");

            foreach( var  name in fullStackDevelopers)
            {
                Console.WriteLine(name);
            }

            int i = 56;
            var j= 76;

            int count = i;
            var result = i;


            //Table students
            //Primary key relationship
            //Students ---unique identifier-----------StudentID
            //Course -----unique identifier-----------CourseID

            //Has a relationship with Students and Courses

            //Student is an Entity
            //Course is an Entity


            //Entity Relationship among Student and Course
            // Can I Query data against relationship
            // from , where , join, orderby , group by, select  

            IList<Student> studentList = new List<Student>() {
                        new Student() { StudentID = 1, Name = "Raghav", CourseID =1 },
                        new Student() { StudentID = 2, Name = "Jeevan", CourseID =1 },
                        new Student() { StudentID = 3, Name = "Chaitanya", CourseID =2 },
                        new Student() { StudentID = 4, Name = "Radhika" , CourseID =2 },
                        new Student() { StudentID = 5, Name = "Manisha" , CourseID=3 }
            };


            //Table courses
            IList<Course> courseList = new List<Course>() {
                        new Course(){ CourseID = 1, Name="DAC", Location="Pune"},
                        new Course(){ CourseID = 2, Name="DBDA", Location="Mumbai"},
                        new Course(){ CourseID = 3, Name="DIOT", Location="Delhi"}
            };

           var dacKnowITStudents = studentList.Join(          // outer sequence 
                                              courseList,  // inner sequence 
                                              student => student.CourseID,    // outerKeySelector
                                              course => course.CourseID,  // innerKeySelector
                                              (student, course) => new  // result selector    /// Anonymous intance
                                              {
                                                  Title = student.Name,
                                                  Discipline = course.Name,
                                                  City=course.Location
                                              });

            Console.WriteLine("All DAC Students");

            foreach (var obj in dacKnowITStudents)
            {
                Console.WriteLine(obj.Title +  "  "+ obj.Discipline  + " "+ obj.City);

            }



            Product product1=new Product();
            product1.Title = "Gerbera";
            product1.Description = "Wedding Flower";


            Product product2 = new Product()
            {
                Title = "Rose",
                Description = "Valentine Flower"
            };


            var product3 = new Product()
            {
                Title = "Jasmine",
                Description = "Smelling Flower"
            };

            dynamic product4 = new Product()
            {
                Title = "Lily",
                Description = "Delicate Flower"
            };


            Console.ReadLine();
        }
    }
}
