using System;
using System.Collections.Generic;
using System.Text;

namespace Todo_app.Data
{
    public class PersonSequencer
    {
        //Creation of private field of Class PersonSequencer..
        private static int personId;

        //Property to get value of PersonId ..
        public static int PersonId { get { return personId; } }


        //Creation of Method to give increement in PersonId..
        public static int NextPersonId()
        {

            return ++personId;

        }

        //Creation of Method to make PersonId value 0..
        public static int Reset()
        {

            return personId = 0;
        }
    }
}

