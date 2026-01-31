using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleToDoList.Models
{
    internal class TaskList
    {
        // Public properties - Properties that describe the object are readable
        // Restricted setters - state changing properties are setter restricted
        // No exposed fields
        public string name { get; private set; }
        public List<TaskItem> taskList { get; private set; }
        public DateOnly creationDate { get; private set; }
    }
}
