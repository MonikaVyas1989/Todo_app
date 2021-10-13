using System;
using System.Collections.Generic;
using System.Text;
using Todo_app.Data;

namespace Todo_app.Model
{
    public class Todo
    {
        // Created private fields as per requirement in the assignment
        private readonly int todoId;
        private string description;
        private bool done;
        private Person assignee;
        // Property to access private member todoId  outside class
        public int TodoId { get { return todoId; } }

        // Property to access private member description outside class
        public string Description { get { return description; } set{ description = value; } }

        // Property to access private member done outside class
        public bool Done { get { return done; } set { done = value; } }

        // Property to access private member assignee outside class
        public Person Assignee { get { return assignee; } set { assignee = value; } }

        // Created Todo constructor as per requirement in the assignment

        public Todo(int todoId,string description )
        {
            this.todoId = todoId;
            Description = description;
            Done = false;
            Assignee = null;
        }
    }
}
