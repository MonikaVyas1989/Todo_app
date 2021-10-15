using System;
using System.Collections.Generic;
using System.Text;
using Todo_app.Data;
using Todo_app.Model;
using Xunit;

namespace Todo_app.Tests
{
    public class PeopleTests
    {
        [Fact]
        public void PeopleTest()
        {
            People people = new People();
            people.Clear();
            Assert.Equal(0, people.Size());
           
        }

        [Fact]
        public void ArrayObjectRemoveTest1()
        {
            People people = new People();

            people.Clear();
            Random re = new Random();
            int id = 0;
            int indexToRemove = re.Next(0, 4);
            List<Person> temp = new List<Person>();
            for (int i = 0; i < 4; i++)
            {
                Person actualArray = people.NewPerson("Monika", "Vyas" + i);

                temp.Add(actualArray);
                if (indexToRemove == i)
                {
                    id = actualArray.PersonId;
                    temp.RemoveAt(indexToRemove);
                }

            }

            People.ArrayObjectRemove(id);
            Assert.Equal(temp.ToArray(), People.PersonArray);
            people.Clear();
        }
        [Fact]
        public void PeopleTest1()
        {
            People people = new People();
            
            Person[] expctedArray = new Person[4];
            people.Clear();
            for (int i = 0; i < expctedArray.Length; i++)
            {
                Person actualArray = people.NewPerson("Monika", "Vyas" + i);
                expctedArray[i] = actualArray;

            }
            Assert.Equal(expctedArray.ToString(), People.PersonArray.ToString());

            Assert.Equal(people.FindAll(), People.PersonArray);
            Assert.Equal(4, people.Size());
            Assert.Equal(people.FindById(2), People.PersonArray[1]);
            people.Clear();
            Assert.Empty(People.PersonArray);


        }

    }
}