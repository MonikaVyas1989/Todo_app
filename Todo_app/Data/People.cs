using System;
using System.Collections.Generic;
using System.Text;
using Todo_app.Model;

namespace Todo_app.Data
{
    public class People
    {
        //Creation of private Person array which is NotNull...
        private static Person[] array = new Person[0];
        public static Person[] PersonArray { get { return array; } }
        //Creation of a method to get size of Array....
        public int Size()
        {


            int arrayLength = array.Length;
            return arrayLength;
        }

        //Creation of a method to get Person Array...
        public Person[] FindAll()
        {
            Person[] returnArray = new Person[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                returnArray[i] = array[i];
            }
            return returnArray;

        }

        //Creation of a method to get Person id which match person name...
        public Person FindById(int personId)
        {
            Person personById = new Person();

            try
            {
                for (int i = 0; i < Size(); i++)
                {
                    if (array[i].PersonId.Equals(personId))
                    {
                        personById = array[i];
                    }

                }
            }
            catch
            {
                Console.WriteLine("\nException occure when trying to find by id... ");
            }
            return personById;
        }

        //Creation of method to assign personid to person object...

        public Person NewPerson(string FirstName, string LastName)
        {

            Person personObject = new Person(PersonSequencer.NextPersonId());
            personObject.FirstName = FirstName;
            personObject.LastName = LastName;


            int size = array.Length + 1;
            Array.Resize(ref array, size);
            array[array.Length - 1] = personObject;


            return personObject;
        }
        public static void ArrayObjectRemove(int personId)
        {
            People people = new People();
            try
            {
                int indexToRemove = Array.IndexOf(array, people.FindById(personId));
                List<Person> temp = new List<Person>(array);

                temp.RemoveAt(indexToRemove);
                array = temp.ToArray();
            }
            catch
            {
                Console.WriteLine("Error occured while removing from Array");
            }

        }


        //Creation of method to clear values from array...

        public void Clear()
        {
            array = Array.Empty<Person>();
        }
    }
}