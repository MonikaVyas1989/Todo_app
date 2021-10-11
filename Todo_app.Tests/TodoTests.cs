using System;
using Xunit;
using Todo_app.Model;

namespace Todo_app.Tests
{
    public class TodoTests
    {
      
            [Theory]
            [InlineData(1)]
            [InlineData(-1)]
            [InlineData(9999999)]

            public void ConstructorTodorIdCheck(int todoId)            
            {
                string description = "test";

                Todo testTodo = new Todo(todoId, description);

                Assert.Equal(testTodo.TodoId, todoId);
            }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("test")]

        public void ConstructorTodoDescriptionCheck(string description)
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
        // Test class Person type object with proper assert
        //[Theory]
        //[InlineData()]
        //[InlineData()]

        //public void PropertyAssigneeCheck(bool assignee)
        //{
        //    int todoId = 1;
        //    string description = "test";
        //    Todo testTodo = new Todo(todoId, description);
        //    testTodo.Assignee = assignee;
        //    Assert.(testTodo.Assignee, assignee);
        //}
    }
}
