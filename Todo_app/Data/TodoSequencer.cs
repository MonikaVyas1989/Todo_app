using System;
using System.Collections.Generic;
using System.Text;

namespace Todo_app.Data
{
    public class TodoSequencer
    {
        private static int todoId;
        public static int TodoId { get { return todoId; } }
        public static int NextTodoId(int todoId)
        {
            return todoId+1;        
        }
        public static void Reset()
        {
            todoId =0;
        }
    }
}
