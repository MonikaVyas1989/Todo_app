using System;
using System.Collections.Generic;
using System.Text;

namespace Todo_app.Model
{
    class Todo
    {
        private readonly int todoId;
        public int TodoId { get { return todoId; } }
        
        private string description;
        public string Description { get { return description; } set{ description = value; } }

        private bool done;
        public bool Done { get { return done; } set { done = value; } }

        private Person assignee;
        public Person Assignee { get { return assignee; } set { assignee = value; } }


        public Todo(int todoId,string description )
        {
            this.todoId = todoId;
            this.description = description;
        }
    }
}
