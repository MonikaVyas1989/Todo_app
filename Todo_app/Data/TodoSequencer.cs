using System;
using System.Collections.Generic;
using System.Text;

namespace Todo_app.Data
{
    public class TodoSequencer
    {
        // Created private fields as per requirement in the assignment
        static int todoId=0;
        // Property to access private member todoId  outside class
        public static int TodoId { get { return todoId; } }
        // Method to get next todoId as per requirement in the assignment
        public static int NextTodoId()
        {
            
            return ++todoId;
        }
        // Method to reset todoId to zero as per requirement in the assignment
        public static void Reset()
        {
            todoId =0;
        }
    }
}
