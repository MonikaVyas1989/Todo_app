﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Todo_app.Data
{
    public class TodoSequencer
    {
        // Created private fields as per requirement in the assignment
        private static int todoId;
        // Property to access private member todoId  outside class
        public static int TodoId { get { return todoId; } }
        // Method to get next todoId as per requirement in the assignment
        public static int NextTodoId(int todoId)
        {
            return todoId+1;        
        }
        // Method to reset todoId to zero as per requirement in the assignment
        public static void Reset()
        {
            todoId =0;
        }
    }
}
