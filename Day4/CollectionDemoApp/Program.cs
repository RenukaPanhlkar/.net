using System;
using System.Collections.Generic; // Strong Type containers
//using System.Collections;    // dont not use  these namespace classes
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types

            int amount = 56;
            Boolean status = false;
            double unitprice = 34.5;


            string fullName = "Ravi Tambade";

            Person person1 = new Person { FirstName = "Rajiv", LastName = "Sharma" };
            Person person2 = new Person();
            person2.FirstName = "Seema";
            person2.LastName = "Nene";
            Person [] people = new Person[] { person1, person2 };
            /*ArrayList list = new ArrayList();
           
            //Automatically Boxiong is taken place
            // value types variable are converted into refernce type variables

            list.Add(amount);
            list.Add(status);
            list.Add (unitprice);

            list.Add(fullName);
            list.Add(person1);
            
            foreach( object obj in list)
            {
                //automatically unboxing is taken place for all refernce types which are holding vale type data
                Console.WriteLine(obj);
            }
            Console.WriteLine(list[2]);

            */


            List<int> numbers= new List<int>();
            numbers.Add(amount);
            numbers.Add(int.Parse(unitprice.ToString()));

            List<Person> students = new List<Person>();
            students.Add(person2);
            students.Add(person1);
            foreach( Person pp in students)
            {
                Console.WriteLine(pp);
            }

            LinkedList<Person> batch = new LinkedList<Person>();
            batch.AddFirst(person1);
            batch.AddLast(person2);
            batch.Remove(person1);
            Person person3 = new Person { FirstName = "Chetana", LastName = "Pandey" };
            batch.AddFirst(person3);

            foreach( Person theP in batch)
            {
                Console.WriteLine(theP);
            }

            Dictionary<int, Person> team = new Dictionary<int, Person>();    
            team.Add(1, person3);
            team.Add(2, person2);
            team.Add(3, person1);
            Person thePerson = team[2];

            Dictionary<string, Person> criketTeam = new Dictionary<string, Person>();
            criketTeam.Add("Captain", person3);
            criketTeam.Add("bowler", person2);
            criketTeam.Add("batsman", person1);
            Person thePlayer = criketTeam["captain"];

            Queue<Person> interestedCandidates = new Queue<Person>();
            interestedCandidates.Enqueue(person3);
            interestedCandidates.Enqueue(person2);
            interestedCandidates.Enqueue(person1);

            Person foundPerson=interestedCandidates.Dequeue();
            Console.WriteLine(foundPerson);

            Stack<Person> defaulters = new Stack<Person>();
            defaulters.Push(person1);
            defaulters.Push(person2);
            defaulters.Push(person1);

            Person p=defaulters.Pop();
            Console.WriteLine(foundPerson);

            Console.ReadLine();
        }   
    }
}
