using Microsoft.VisualBasic;
using System.ComponentModel.Design;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp {
    internal class Project {
        public static List<Task> tasks = new List<Task>();

        static void Main(string[] args) {
            string options = "\nTo close application type n \nTo create a task type t \nTo view all tasks type v \nTo view specific task type vt\"index\" example: vt0 \nTo set status type st\"index\" example st0\nTo Delete task type dt\"index\"";
            Console.WriteLine(options);
            while (true) {
                Console.WriteLine("\nTo view options type h");
                string input = Console.ReadLine().ToLower();
                if (input == "n") {
                    break;
                } else if (input == "h") {
                    Console.WriteLine(options);
                    continue;
                }
                handleInput(input);

            }
        }

        static void handleInput(string input) {
            if (input == "t") {
                CreateTask();
            } else if (input == "v") {
                PrintTaskList();
            } else if (input[0] == 'v') {
                ViewTask(input);
            } else if (input[0] == 's') {
                SetTaskStatus(input);
            } else if (input[0] == 'd') {
                DeleteTask(input);
            }
        }


        static void PrintTaskList() {
            for (int i = 0; i < tasks.Count; i++) {
                Console.WriteLine(i + ": " + tasks[i].Title);
            }
        }


        static void CreateTask() {
            Dictionary<string, string> inputDetails = new Dictionary<string, string> {
                { "title", null },
                { "description", null },
                { "dueDate", null },
                { "status", null }
            };

            Task.TaskStatus status = Task.TaskStatus.NotStarted; 


            foreach(var detail in inputDetails) {
                if (detail.Key == "status") {
                    Console.WriteLine("Possible options are NotStarted, InProgress, Completed");
                }

                Console.Write("input " + detail.Key + ": ");
                string input = Console.ReadLine();

                if (detail.Key == "status") {
                    status = ParseTaskStatus(input);
                }

                 inputDetails[detail.Key] = input;
            }

            Task task = new Task(inputDetails["title"], inputDetails["description"], inputDetails["dueDate"], status);
            tasks.Add(task);
            Console.WriteLine("Task added");
        }


        static void ViewTask(string input) {
            Task? task = RetrieveTask(input);
            if (task != null) {
                task.DisplayTaskDetails();
            }
        }

        static void SetTaskStatus(string input) {
            Task? task = RetrieveTask(input);
            if (task != null) {
                Console.WriteLine("Possible options are NotStarted, InProgress, Completed");
                string inputStatus = Console.ReadLine();

                Task.TaskStatus status = ParseTaskStatus(inputStatus);
                task.Status = status;
                Console.WriteLine("Task status set!");
            }
        }

        static void DeleteTask(string input) {
            Task? task = RetrieveTask(input);
            if (task != null) {
                tasks.Remove(task);
                Console.WriteLine("Task sucessfuly deleted!");
            }
        }





        static Task.TaskStatus ParseTaskStatus(string input) {
            string inputLowCase = input.ToLower();
            if (inputLowCase == "completed") {
                return Task.TaskStatus.Completed;
            } else if (inputLowCase == "inprogress") {
                return Task.TaskStatus.InProgress;
            } else if (inputLowCase == "notstarted") {
                return Task.TaskStatus.NotStarted;
            }
            Console.WriteLine("Incorect status input setting status to Not Started");
            return Task.TaskStatus.NotStarted;
        }

        static Task? RetrieveTask(string input) { //Retrieve task looks for index starting at 2
            bool parseSuccess = int.TryParse(input.Substring(2), out int index);
            if (!parseSuccess) {
                Console.WriteLine("Incorrect index");
                return null;
            }
            try {
                Task task = tasks[index];
                return task;
            }
            catch (ArgumentOutOfRangeException) {
                Console.WriteLine("There is no task with that index try again ");
                return null;
            }
        }

    }

}
