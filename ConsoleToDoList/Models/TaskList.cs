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

        public TaskList(string name, DateOnly todayDate)
        {
            Name = name;
            Tasks = new List<TaskItem>();
            CreationDate = todayDate;
        }
    }
}
