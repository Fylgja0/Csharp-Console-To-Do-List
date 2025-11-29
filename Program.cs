using ToDoList.Classes;

namespace ToDoList
{
    public class Program
    {
        static void Main(string[] args)
        {
            TaskManager manager = new();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("--- WELCOME TO THE TO DO LIST ---");
                Console.WriteLine("1) Add Task");
                Console.WriteLine("2) List Tasks");
                Console.WriteLine("3) Delete Task");
                Console.WriteLine("4) Complete Task");
                Console.WriteLine("5) Exit ");
                Console.Write("\nChoice: ");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    // Add task
                    case "1":
                        Console.Write("Enter a Task to Add: ");
                        string? taskName = Console.ReadLine();
                        manager.AddItem(taskName ?? "Null Task");
                        break;

                        // List tasks
                    case "2":
                        Console.WriteLine("Your To Do List: ");
                        var incomingList = manager.ItemList();
                        foreach (var item in incomingList)
                        {
                            string statusText;
                            if (item.IsCompleted == true)
                            {
                                statusText = "[ COMPLETED ]";
                            }
                            else
                            {
                                statusText = "[ CONTINUES ]";
                            }
                                Console.WriteLine($"\nID: {item.ItemID} \nTitle: {item.Title} \nStatus: {statusText} \nDate: {item.CreatedDate}");
                            Console.WriteLine();
                        }
                        break;

                        // Delete task
                    case "3":
                        // See the tasks that can be deleted
                        Console.WriteLine("--- Tasks That Can Be Deleted ---");
                        var deletingList = manager.ItemList();
                        foreach (var item in deletingList)
                        {
                            Console.WriteLine($"\nID: {item.ItemID} \nTitle: {item.Title} \nStatus: {item.IsCompleted}");
                        }

                        // Delete the task
                        Console.Write("Enter a Task ID to Delete: ");
                        if (int.TryParse((Console.ReadLine()), out int willBeRemove))
                        {
                            manager.DeleteItem(willBeRemove);
                        }
                        else
                        {
                            Console.WriteLine("Error! Please Enter a Valid Value!");
                        }
                        break;

                        // Complete the task
                    case "4":
                        // See the tasks what can be complete
                        Console.WriteLine("--- Task That Will Be Complete ---");
                        foreach (var item in manager.ItemList())
                        {
                            if (item.IsCompleted == false)
                            {
                                Console.WriteLine($"\nID: {item.ItemID} \nTitle: {item.Title}");
                            }
                        }

                        // Complete the task
                        Console.Write("Enter a Task ID to Complete: ");
                        if (int.TryParse((Console.ReadLine()),out int willBeComplete))
                        {
                            manager.CompleteItem(willBeComplete);
                        }
                        else
                        {
                            Console.WriteLine("Error! Please Enter a Valid Value!");
                        }
                            break;

                        // Exit
                    case "5":
                        return;
                }

                Console.WriteLine("Press Any Key to Continue...");
                Console.ReadKey();

            }
        }
    }
}
