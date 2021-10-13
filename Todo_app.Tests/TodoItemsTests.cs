using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Todo_app.Data;
using Todo_app.Model;

namespace Todo_app.Tests
{
    public class TodoItemsTests
    {
        [Fact]

        public void NewTodoTests()
        {
            //Todo[] testTodo = new Todo[0];
             
            Todo[] expectedTodoItem = new Todo[5];
            TodoItems ob = new TodoItems();
            for (int i = 0; i < 5; i++)
            {
                Todo actualTodoItem = TodoItems.NewTodo("test" + i);
                Todo newTodo = new Todo(TodoSequencer.TodoId, "test" + i);
                expectedTodoItem[i] = newTodo;
            }
            Assert.Equal(expectedTodoItem.ToString(), TodoItems.ArrTodo.ToString());
            Assert.Equal(5, ob.Size());
            Assert.Equal(ob.FindAll(), TodoItems.ArrTodo);
            Assert.Equal(ob.FindById(2), TodoItems.ArrTodo[1]);
            ob.clear();
            Assert.Empty( TodoItems.ArrTodo);
        }

        //[Theory]
        //[InlineData(0)]
        //[InlineData(1)]
        //[InlineData(2)]
        //[InlineData(3)]
        //public void NewTodoItemsTests(int i)
        //{
        //    Todo actualTodoItem = TodoItems.NewTodo("test" + i);
        //    Todo newTodoItem = new Todo(TodoSequencer.TodoId, "test" + i);
        //    Assert.Equal(newTodoItem,TodoItems.ArrTodo[i]);


        //}
    }
}
