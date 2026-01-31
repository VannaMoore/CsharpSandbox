using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleToDoList.Models
{
    internal class TaskItem
    {
        // Public properties - Properties that describe the object are readable
        // Restricted setters - state changing properties are setter restricted
        // No exposed fields
        public string TaskItemName { get; private set; }
        public string? TaskDescription { get; private set; }
        public bool IsComplete { get; private set; }

        public TaskItem(string itemName, string? itemDescription)
        {
            TaskItemName = itemName;
            TaskDescription = itemDescription;
            IsComplete = false;      
        }
        
        public void MarkComplete()
        {
            IsComplete = true;
        }

        public void ChangeItemName(string itemName)
        {
            TaskItemName = itemName;
        }

        public void SetDescription(string? description)
        {
            TaskDescription = description;
        }
    }
}
