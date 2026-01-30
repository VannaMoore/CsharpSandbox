using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleToDoList.Models
{
    internal class TaskList
    {
        private string name { get; set; }
        private List<TaskItem> taskList { get; set; }
        public DateOnly creationDate { get; set; }
    }
}
