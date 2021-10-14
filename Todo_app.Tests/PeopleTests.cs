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

            Assert.Equal(0, people.Size());
            Assert.Equal(people.FindAll(), People.PersonArray);

        }
        [Fact]
        public void PeopleTest1()
        {
            People people = new People();
            Person[] expctedArray = new Person[4];

            for (int i = 0; i < expctedArray.Length; i++)
            {
                Person actualArray = people.NewPerson("Monika", "Vyas" + i);
                expctedArray[i] = actualArray;

            }
            Assert.Equal(expctedArray.ToString(), People.PersonArray.ToString());
            Assert.Equal(4, people.Size());
            Assert.Equal(people.FindById(2), People.PersonArray[1]);
            people.Clear();

        }

    }
}