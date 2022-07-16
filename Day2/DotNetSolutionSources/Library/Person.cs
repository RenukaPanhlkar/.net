using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Person
    {
        // Data members

        private string firstName;
        private string lastName;
        private string email;
        private int age;
        private string contactNumber;

        //Properties
       public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }

        //Initializer (Constructor)
        //Metod overloading
        public Person()
        {
            firstName = "Ravi";
            lastName = "Tambade";
            email = "ravi.tambade@transflower.in";
            age = 46;
            contactNumber = "9881735801";
        }
        public Person(string fName, string lName, string contactNumber, string email,int age)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.email = email;
            this.age = age;
            this.contactNumber = contactNumber;
        }

        //Destructor
        ~Person()
        {
            //Auto Clean up Code
        }

        //Method overriding
        public override string ToString()
        {
            string result = string.Format("{0} {1} {2}  {3}  {4}",
                                         this.FirstName, this.LastName, this.Age, this.Email, this.ContactNumber);

            return result;
        }

    }
}
