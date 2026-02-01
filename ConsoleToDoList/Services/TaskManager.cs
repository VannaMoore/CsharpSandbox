using ConsoleToDoList.Models;

namespace ConsoleToDoList.Services
{
    // ***** Add validations to methods if user passes invalid indices 
    internal class TaskManager
    {
        // TaskManager owns the in-memory "database" for the collection of lists
        private List<TaskList> _taskLists = new List<TaskList>();
        public void CreateList(string listName)
        {
            TaskList newList = new TaskList(listName);
            _taskLists.Add(newList);
        }

        public IReadOnlyList<TaskList> GetAllLists()
        {
            return _taskLists;
        }

        // Retrieve one TaskList by index and return one TaskList
        public TaskList GetListByIndex(int index)
        {
            return _taskLists[index];
        }

        public void UpdateTaskListName(int index, string newName)
        {
            TaskList selectedTaskList = GetListByIndex(index);
            selectedTaskList.ChangeName(newName);
        }

        public void DeleteTaskList(int index)
        {
            _taskLists.Remove(_taskLists[index]);
        }
    }
}
