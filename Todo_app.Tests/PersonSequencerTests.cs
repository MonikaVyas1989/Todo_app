using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Todo_app.Data;

namespace Todo_app.Tests
{
    public class PersonSequencerTests
    {
        [Fact]

        public void PersonSequencertest()
        {
            int id = 0;

            Assert.Equal(PersonSequencer.PersonId, id);

        }
        [Theory]
        [InlineData(1)]
        [InlineData(2)]

        public void PersonIdIncreamentTest(int nextId)
        {


            int PersonnextId = PersonSequencer.NextPersonId();
            Assert.Equal(nextId, PersonnextId);

        }

        [Fact]
        public void PersonNextIdTest()
        {
            int nextIdTest = 0;
            for (int i = 0; i < 10; i++)
            {
                nextIdTest = i + 1;
                int PersonnextId = PersonSequencer.NextPersonId();
                Assert.Equal(nextIdTest, PersonnextId);
            }

        }

        [Theory]
        [InlineData(3)]
        [InlineData(101)]
        [InlineData(9)]
        public void PersonIdResetTests(int id)
        {

            int resetPersonId = PersonSequencer.Reset();

            Assert.Equal(0, resetPersonId);
        }

    }
}

