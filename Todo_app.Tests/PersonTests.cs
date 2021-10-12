using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Todo_app.Model;

namespace Todo_app.Tests
{
    public class PersonTests
    {
        [Fact]

        public void Idtest()
        {
            int id = 0;
            Person personid = new Person();

            Assert.Equal(personid.PersonId, id);

        }
           
        [Theory]
        [InlineData ("Test")]
        
        public void Firstnametest(string firstname)
        {
            Person persontest = new Person();
            persontest.FirstName = firstname;
            Assert.Equal(persontest.FirstName,firstname);
            Assert.NotNull(persontest.FirstName);
        }
        [Theory]
        [InlineData("")]
        [InlineData(null)]

        public void Firstnamenulltest(string firstname)
        {
            Person persontest = new Person();
          
            ArgumentException result = Assert.Throws<ArgumentException>(() =>  persontest.FirstName =firstname);
            Assert.Equal("First name must have a value..", result.Message);
        }


        [Theory]
        [InlineData("Test")]

        public void lastnametest(string lastname)
        {
            Person persontest = new Person();
            persontest.LastName = lastname;
            Assert.Equal(persontest.LastName, lastname);
            Assert.NotNull(persontest.LastName);
        }
        [Theory]
        [InlineData("")]
        [InlineData(null)]

        public void Lastnamenulltest(string lastname)
        {
            Person persontest = new Person();

            ArgumentException result = Assert.Throws<ArgumentException>(() => persontest.LastName = lastname);
            Assert.Equal("Last name must have a value..", result.Message);
        }



    }

}
