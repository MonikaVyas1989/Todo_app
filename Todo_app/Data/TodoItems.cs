using System;
using System.Collections.Generic;
using System.Text;
using Todo_app.Model;

namespace Todo_app.Data
{
    public class TodoItems
    {
        // Created and instantiated Todo array as per assignment requirement
        private static Todo[] arrTodo = new Todo[0];
        public static Todo[] ArrTodo { get { return arrTodo; } }
        // Returns size of array as per assignment
        public int Size()
        {
            return arrTodo.Length;
        }

        // Creates a new Todo object and expands arrTodo as per assignment
        public static Todo NewTodo(string description)
        {
            // Creates new Todo boject by giving unique id using NextTodoId and description of the TodoItem
            var newTodo = new Todo(TodoSequencer.NextTodoId(), description);

            // Expands arrTodo to accomodate newly created object
          
            int size = arrTodo.Length + 1;
            Array.Resize(ref arrTodo,size);
            arrTodo[size-1] = newTodo;

            return newTodo;

        }


        // Returns array to access all data within private arrTodo outside class
        public Todo[] FindAll()
        {
            return arrTodo;
        }

        // Returns specific data according to todoId in private arrTodo outside class
        public Todo FindById(int todoId)
        {
            Todo obTodo = new Todo(0, "");
            try
            {
                for (int i = 0; i < Size(); i++)
                {
                    if (arrTodo[i].TodoId.Equals(todoId))
                         obTodo= arrTodo[i];
                }
            }
            catch 
            {
                Console.WriteLine("/n Exception occured while finding Todo using TodoId. Contact System Admin ");               
            }
            return obTodo;
        }
        
        public void clear()
        {
            arrTodo = Array.Empty<Todo>();
        }
        
    }
}
