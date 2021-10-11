using System;
using System.Collections.Generic;
using System.Text;

namespace Todo_app.Model
{
    public class Todo
    {
        // Created private readonly todoId, private description,done and assignee as per requirement in the assignment
        private readonly int todoId;
        private string description;
        private bool done;
        private Person assignee;
        // Property for private member todoId to access outside class
        public int TodoId { get { return todoId; } }
        
        // Property for private member description to access outside class
        public string Description { get { return description; } set{ description = value; } }
        
        // Property for private member done to access outside class
        public bool Done { get { return done; } set { done = value; } }
        
        // Property for private member assignee to access outside class
        public Person Assignee { get { return assignee; } set { assignee = value; } }

        // Created Todo constructor as per requirement in the assignment

        public Todo(int todoId,string description )
        {
            this.todoId = todoId;
            this.description = description;
        }
    }
}
