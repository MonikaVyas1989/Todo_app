using System;
using System.Collections.Generic;
using System.Text;
using Todo_app.Data;
using Xunit;

namespace Todo_app.Tests
{
    public class TodoSequencerTests
    {

        [Theory]
        [InlineData(1)]
        [InlineData(0)]
        [InlineData(100)]
        [InlineData(-10)]
        public void NextTodoIdTests(int todoId)
        {
            int actualTodoId = todoId +1;
            
            int nextTodoId=TodoSequencer.NextTodoId(todoId);

            Assert.Equal(nextTodoId, actualTodoId);

        }


        [Theory]
        [InlineData(1)]
        [InlineData(0)]
        [InlineData(100)]
        [InlineData(-10)]
        public void ResetTests(int todoId)
        {
            TodoSequencer.NextTodoId(todoId);
                    
            TodoSequencer.Reset();

            Assert.Equal(0, TodoSequencer.TodoId);
        }

    }
}
