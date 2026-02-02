using ConsoleToDoList.Models;
using System.Collections.Generic;

namespace ConsoleToDoList.Services
{
    // ***** Add validations to methods if user passes invalid indices 
    internal class TaskManager
    {
        // TaskManager owns the in-memory "database" for the collection of lists
        private List<TaskList> _taskLists = new List<TaskList>();
        public void CreateList(string listName)
        {
            // prevents empty names
            if (string.IsNullOrWhiteSpace(listName))
                return;

            TaskList newList = new TaskList(listName.Trim());
            _taskLists.Add(newList);
        }

        private bool IsValidIndex(int index)
        {
            return index >= 0 && index < _taskLists.Count;
        }

        public IReadOnlyList<TaskList> GetAllLists()
        {
            return _taskLists;
        }

        // Retrieve one TaskList by index and return one TaskList
        public bool TryGetListByIndex(int index, out TaskList? list)
        {
            if (index < 0 || index >= _taskLists.Count)
            {
                list = null;
                return false;
            }

            list = _taskLists[index];
            return true;
        }

        public bool TryUpdateListName(int index, string newName)
        {
            if (string.IsNullOrWhiteSpace(newName))
                return false;

            if (!TryGetListByIndex(index, out TaskList? selectedTaskList)) 
                return false;

            // Gauranteed this is not null at this point
            selectedTaskList!.ChangeName(newName.Trim());
            return true;
        }

        public bool TryDeleteTaskList(int index)
        {
            if (!IsValidIndex(index))
                return false;

            _taskLists.Remove(_taskLists[index]);
            return true;
        }
    }
}
