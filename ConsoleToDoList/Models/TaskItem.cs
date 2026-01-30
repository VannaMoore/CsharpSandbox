using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleToDoList.Models
{
    internal class TaskItem
    {
        private string taskName { get; set; }
        private string? taskDescription { get; set; }
        public bool isComplete { get; set; }
    }
}
