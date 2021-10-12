using System;
using System.Collections.Generic;
using System.Text;

namespace Todo_app.Model
{
    public class Person
    {
        //Declaration of private fields of Class Person...
        private readonly  int personId;
        private string firstName, lastName;

        public Person()
        {
           /* this.personId = 1;
            this.firstName = "Monika";
            this.lastName = "Vyas";*/
        }

        //Property to get value of PersonId ..
        public int PersonId { get { return personId; } }

        //Property to access of first name which can not be null or empty..
        public string FirstName
        {
            get
            { return firstName; }  
            set 
            {
                if(value .Equals (""))
                {
                    throw new ArgumentNullException("First name must have a value..");
                }
                firstName = value;
            }    
        }

        //Property to access of last name which can not be null or empty..
        public string LastName
        {
            get {return lastName;} 
            set
            {
                if (value.Equals(""))
                {
                    throw new ArgumentNullException("Last name must have a value..");
                }
                lastName = value; 
            }
        }
    }

}
