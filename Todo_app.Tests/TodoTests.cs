using System;
using Xunit;
using Todo_app.Model;

namespace Todo_app.Tests
{
    public class TodoTests
    {

        [Fact]
        public void Constructor()
        {
            int todoId =0;
            string description = "";
            bool done = false;
            Person assignee = null;

            Todo todoTest = new Todo(todoId,description);

            Assert.NotNull(todoTest);
            Assert.Equal(todoTest.TodoId, todoId);
            Assert.Equal(todoTest.Description, description);
            Assert.Equal(todoTest.Done, done);
            Assert.Equal(todoTest.Assignee, assignee);
        }
      
            [Theory]
            [InlineData(1)]
            [InlineData(0)]
            [InlineData(-1)]
            [InlineData(9999999)]
            public void PropertyrTodoIdCheck(int todoId)            
            {
                string description = "test";
                Todo testTodo = new Todo(todoId, description);

                Assert.Equal(testTodo.TodoId, todoId);
            }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("test")]
        public void ProtertyDescriptionCheck(string description)
        {
            int todoId = 1;

            Todo testTodo = new Todo(todoId, description);

            Assert.Equal(testTodo.Description, description);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]

        public void PropertyDoneCheck(bool done)
        {
            int todoId = 1;
            string description = "test";
            Todo testTodo = new Todo(todoId, description);
            testTodo.Done = done;
            Assert.Equal(testTodo.Done, done);
        }
        //Test class Person type object with proper assert
        [Theory]
        [InlineData(null)]
        public void PropertyAssigneeCheck(Person assignee)
        {
            int todoId = 1;
            string description = "test";
            Todo testTodo = new Todo(todoId, description);
            testTodo.Assignee = assignee;
            Assert.Equal(testTodo.Assignee, assignee);
        }
    }
}
