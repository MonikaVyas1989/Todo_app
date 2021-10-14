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
                foreach (Todo item in arrTodo)
                {
                    if (item.TodoId.Equals(todoId))
                        obTodo=(item);
                }

                //for (int i = 0; i < Size(); i++)
                //{
                //    if (arrTodo[i].TodoId.Equals(todoId))
                //         obTodo= arrTodo[i];
                //}
            }
            catch 
            {
                Console.WriteLine("/n Exception occured while finding Todo using TodoId. Contact System Admin ");               
            }
            return obTodo;
        }

        // Returns specific data according to done status 
        public Todo[] FindByDoneStatus(bool doneStatus)
        {
            List<Todo> listTodo = new List<Todo>();
            try
            {
                foreach (Todo item in arrTodo)
                {
                    if (item.Done.Equals(doneStatus))
                        listTodo.Add(item);
                }
                //for (int i = 0; i < Size(); i++)
                //{
                //    if (arrTodo[i].Done.Equals(doneStatus))
                //        listTodo.Add(arrTodo[i]);
                //}
            }
            catch
            {
                Console.WriteLine("/n Exception occured while finding Todo using Done status. Contact System Admin ");
            }


            return listTodo.ToArray();
        }
        // Returns specific data according to assigneeId 
        public Todo[] FindByAssignee(int personId)
        {
            List<Todo> listTodo = new List<Todo>();
            try
            {
                foreach (Todo item in arrTodo)
                {
                    if(item.Assignee!=null)
                    if (item.Assignee.PersonId==personId)
                        listTodo.Add(item);
                }
                //for (int i = 0; i < Size(); i++)
                //{
                //    if (arrTodo[i].Assignee.PersonId.Equals(personId))
                //        listTodo.Add(arrTodo[i]);
                //}
            }
            catch
            {
                Console.WriteLine("/n Exception occured while finding Todo using personId. Contact System Admin ");
            }


            return listTodo.ToArray();
        }
        // Returns specific data according to assignee
        public Todo[] FindByAssignee(Person assignee)
        {
            List<Todo> listTodo = new List<Todo>();
            try
            {
                foreach (Todo item in arrTodo)
                {
                    if (item.Assignee != null)
                        if (item.Assignee == assignee)
                        listTodo.Add(item);
                }
            }
            catch
            {
                Console.WriteLine("/n Exception occured while finding Todo using assignee object. Contact System Admin ");
            }

            return listTodo.ToArray();
        }

        // Returns specific data where arrTodo has no assignee yet
        public Todo[] FindUnassignedTodoItems()
        {
            List<Todo> listTodo = new List<Todo>();
            try
            {
                foreach (Todo item in arrTodo)
                {
                    if (item.Assignee == null)
                        listTodo.Add(item);
                }
                //for (int i = 0; i < Size(); i++)
                //{
                //    if (arrTodo[i].Assignee.Equals(null))

                //        listTodo.Add(arrTodo[i]);
                //}
            }
            catch
            {
                Console.WriteLine("/n Exception occured while finding unassigned Todo items. Contact System Admin ");
            }

            return listTodo.ToArray();
        }

        // Updates arrTodo by removing object from array without nulling using Todo object
        public static void RemoveFromArrTodo(Todo obTodo)
        {
            TodoItems ob = new TodoItems();
            try
            {
                int removeIndex = Array.IndexOf(arrTodo, obTodo);
                //int size = ob.Size();
                //Todo[] arrTemp = arrTodo;

                Array.ConstrainedCopy(arrTodo, removeIndex + 1, arrTodo, removeIndex, ob.Size() - (removeIndex + 1));
                Array.Resize(ref arrTodo, ob.Size() - 1);
            }
            catch
            {
                Console.WriteLine("/n Exception occured while removing Todo items. Contact System Admin ");
            }

        }
        // Updates arrTodo by removing object from array without nulling using todoId
        public static void RemoveFromArrTodo(int todoId)
        {
            TodoItems ob = new TodoItems();
            try
            {
                int removeIndex = Array.IndexOf(arrTodo, ob.FindById(todoId));

                Array.ConstrainedCopy(arrTodo, removeIndex + 1, arrTodo, removeIndex, ob.Size() - (removeIndex + 1));
                Array.Resize(ref arrTodo, ob.Size() - 1);
            }
            catch
            {
                Console.WriteLine("/n Exception occured while removing Todo items. Contact System Admin ");
            }
        }

        public void clear()
        {
            arrTodo = Array.Empty<Todo>();
        }
        
    }
}
