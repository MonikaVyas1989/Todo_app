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

        public void SizeandClearTests()
        {
            TodoItems ob = new TodoItems();
            ob.clear();
            Assert.Equal(0, ob.Size());

            for (int i = 0; i < 5; i++)
            {
                Todo actualTodoItem = TodoItems.NewTodo("test" + i);                
            }
            
            Assert.Equal(5, ob.Size());

            ob.clear();
            Assert.Empty(TodoItems.ArrTodo);
        }

        [Fact]

        public void NewTodoTests()
        {
            Todo[] expectedTodoItem = new Todo[5];

            for (int i = 0; i < 5; i++)
            {
                Todo actualTodoItem = TodoItems.NewTodo("test" + i);
                Todo newTodo = new Todo(TodoSequencer.TodoId, "test" + i);
                expectedTodoItem[i] = newTodo;
            }
            Assert.Equal(expectedTodoItem.ToString(), TodoItems.ArrTodo.ToString());
            //ob.clear();
            //Assert.Empty(TodoItems.ArrTodo);
        }

        [Fact]

        public void FindTodoTests()
        {
            Person obPerson = new Person(PersonSequencer.NextPersonId());
            obPerson.FirstName = "Monika";
            obPerson.LastName = "Vyas";
            Person Madiha = new Person(PersonSequencer.NextPersonId());
            Madiha.FirstName = "Madiha";
            Madiha.LastName = "Gul";
            List<Todo> listobPerson = new List<Todo>();
            List<Todo> listMadiha = new List<Todo>();
            List<Todo> unAssigned = new List<Todo>();
            Todo[] arrDone = new Todo[1];
            List<Todo> ArrNotDone = new List<Todo>();
            TodoItems ob = new TodoItems();
            ob.clear();
            for (int i = 0; i < 5; i++)
            {
               
                Todo actualTodoItem = TodoItems.NewTodo("test" + i);
                if (i == 0)
                {
                    TodoItems.ArrTodo[i].Done = true;
                    arrDone[0] = TodoItems.ArrTodo[i];
                    unAssigned.Add(TodoItems.ArrTodo[i]);
                }
                else { ArrNotDone.Add(TodoItems.ArrTodo[i]); }
                if (i ==1 || i ==3) 
                {
                    TodoItems.ArrTodo[i].Assignee= Madiha;
                    listMadiha.Add(TodoItems.ArrTodo[i]);
                }
                if (i == 2 )
                {
                    TodoItems.ArrTodo[i].Assignee = obPerson;
                    listobPerson.Add(TodoItems.ArrTodo[i]);
                }
                if (i > 3) 
                {
                     unAssigned.Add(TodoItems.ArrTodo[i]);
                }
            }

            /* Just to check actual arrTodo !!
             * Actual:   Todo[] [Todo { Assignee = null, Description = "test0", Done = True, TodoId = 1 }, 
             * Todo { Assignee = Person { ... }, Description = "test1", Done = False, TodoId = 2 },
             * Todo { Assignee = Person { ... }, Description = "test2", Done = False, TodoId = 3 }, 
             * Todo { Assignee = Person { ... }, Description = "test3", Done = False, TodoId = 4 }, 
             * Todo { Assignee = null, Description = "test4", Done = False, TodoId = 5 }]*/

            Assert.Equal(TodoItems.ArrTodo, ob.FindAll());
            Assert.Equal(TodoItems.ArrTodo[1], ob.FindById(2));
            Assert.Equal(TodoItems.ArrTodo[3], ob.FindById(4));

            Assert.Equal(arrDone,ob.FindByDoneStatus(true));
            Assert.Equal(ArrNotDone.ToArray(),ob.FindByDoneStatus(false));

            Assert.Equal(listMadiha.ToArray(), ob.FindByAssignee(Madiha));
            Assert.Equal(listobPerson.ToArray(), ob.FindByAssignee(obPerson.PersonId));

            Assert.Equal(unAssigned.ToArray(),ob.FindUnassignedTodoItems());

            ob.clear();
            Assert.Empty(TodoItems.ArrTodo);
        }

        [Fact]

        public void RemoveFromArrTodoTests()
        {
            TodoItems ob = new TodoItems();
            ob.clear();
            Random rand = new Random();
            int removeIndex =rand.Next(0,3);
            Todo[] removeTodoItem = new Todo[1];
            Todo[] expectedTodoItem = new Todo[2];

            for (int i = 0; i < 3; i++)
            {
                Todo newTodo = TodoItems.NewTodo("test" + i);
                if (removeIndex == i)
                { removeTodoItem[0] = newTodo; }              
            }
            Array.ConstrainedCopy(TodoItems.ArrTodo, 0, expectedTodoItem, 0, removeIndex );
            Array.ConstrainedCopy(TodoItems.ArrTodo, removeIndex + 1, expectedTodoItem, removeIndex, TodoItems.ArrTodo.Length - (removeIndex+1));

            TodoItems.RemoveFromArrTodo(removeTodoItem[0]);

            Assert.Equal(expectedTodoItem, TodoItems.ArrTodo);
        }

        [Fact]
        public void RemoveFromArrTodoIdTests()
        {
            TodoItems ob = new TodoItems();
            ob.clear();
            Random rand = new Random();
            int removeIndex = rand.Next(0, 3);
            int todoId=0;
            Todo[] expectedTodoItem = new Todo[2];

            for (int i = 0; i < 3; i++)
            {
                Todo newTodo = TodoItems.NewTodo("test" + i);
                if (removeIndex == i)
                { todoId= newTodo.TodoId; }
            }
            Array.ConstrainedCopy(TodoItems.ArrTodo, 0, expectedTodoItem, 0, removeIndex);
            Array.ConstrainedCopy(TodoItems.ArrTodo, removeIndex + 1, expectedTodoItem, removeIndex, TodoItems.ArrTodo.Length - (removeIndex + 1));

            TodoItems.RemoveFromArrTodo(todoId);

            Assert.Equal(expectedTodoItem, TodoItems.ArrTodo);
        }

    }
}
