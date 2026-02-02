using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleToDoList.Models
{
    // Invariants:
    // - Name is required
    // - Tasks is always initialized as an empty list
    // - CreationDate is set once at creation

    internal class TaskList
    {
        // Public properties - Properties that describe the object are readable
        // Restricted setters - state changing properties are setter restricted
        // No exposed fields
        public string Name { get; private set; }
        public List<TaskItem> Tasks { get; private set; }
        public DateOnly CreationDate { get; private set; }

        public TaskList(string name)
        {
            Name = name;
            Tasks = new List<TaskItem>();
            CreationDate = DateOnly.FromDateTime(DateTime.Now);
        }

        public void ChangeName(string newName)
        {
            Name = newName;
        }

        // TaskList owns TaskItems
        private readonly List<TaskItem> _items = new(); 
        public IReadOnlyList<TaskItem> Items => _items; 

        public void AddTaskItem(TaskItem item) => _items.Add(item); 
        public void RemoveTaskItemAt(int index) => _items.RemoveAt(index); 
        public bool IsValidTaskIndex(int index) => index >= 0 && index < _items.Count;
        public TaskItem GetTaskItemAt(int index) => _items[index]; 
    }
}
