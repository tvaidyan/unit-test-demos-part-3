using System;
using System.Collections.Generic;

namespace UnitTestsDemoPart3
{
    public class TodoListManager
    {
        public List<string> TodoList { get; set; } = new List<string>();
        public void AddTodo(string task)
        {
            if (string.IsNullOrWhiteSpace(task))
            {
                throw new ArgumentException("Invalid Task");
            }

            TodoList.Add(task);
        }
    }
}
