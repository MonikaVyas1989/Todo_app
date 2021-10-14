using System;
using System.Collections.Generic;
using System.Text;
using Todo_app.Data;

namespace Todo_app.Model
{
    public class Person
    {
        //Declaration of private fields of Class Person...
        private readonly  int personId;
        private string firstName, lastName;

        //Property to get value of PersonId ..
        public int PersonId { get { return personId; } }

        public Person()
        {
          
        }
        public Person(int perId)
       {
            personId =perId;
       }  
           
        //Property to access of first name which can not be null or empty..
        public string FirstName
        {
            get
            { return firstName; }  
            set 
            {
                if(string .IsNullOrEmpty (value))
                {
                    throw new ArgumentException("First name must have a value..");
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
                if (string.IsNullOrEmpty (value))
                {
                    throw new ArgumentException("Last name must have a value..");
                }
                lastName = value; 
            }
        }
    }
    

}
