namespace ToDoList.Classes
{
    public class TaskManager
    {
        // Task list
        private List<ToDoItem> toDoItems = new();
        // Task counter
        // The number of the first task is 1, and the counter will increase as new tasks are added
        private int counter = 1;

        // Add task
        public void AddItem(string item)
        {
            ToDoItem item1 = new()
            {
                ItemID = counter,

                Title = item,

                IsCompleted = false,

                CreatedDate = DateTime.Now,
            };
            toDoItems.Add(item1);
            counter++;
        }

        // Delete task
        public void DeleteItem(int id)
        {
            ToDoItem? willBeRemove = toDoItems.Find(x => x.ItemID == id);
            if (willBeRemove != null)
            {
                toDoItems.Remove(willBeRemove);
            }
        }

        // List tasks
        public List<ToDoItem> ItemList()
        {
            return toDoItems;
        }

        // Complete task
        public void CompleteItem(int id)
        {
            ToDoItem? completeTask = toDoItems.Find(x => x.ItemID == id);
            if (completeTask != null && completeTask.IsCompleted == false)
            {
                completeTask.IsCompleted = true;
            }
        }
    }
}
