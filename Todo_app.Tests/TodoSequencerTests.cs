using System;
using System.Collections.Generic;
using System.Text;
using Todo_app.Data;
using Xunit;

namespace Todo_app.Tests
{
    public class TodoSequencerTests
    {
        // Tests NextTodoId method, Tested with fact, theory not works
        [Fact]

        public void NextTodoIdTests()
        {
            for (int i = 1; i < 6; i++)
            {
                int nextTodoId = TodoSequencer.NextTodoId();

                Assert.Equal(i, nextTodoId);
            }

        }


        // tests Reset method
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        public void ResetTests(int todoId)
        {
            int actualTodoId = todoId + 1;
            int expectedTodoId = TodoSequencer.NextTodoId();
                    
            TodoSequencer.Reset();

            Assert.Equal(0, TodoSequencer.TodoId);
        }

    }
}
