using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp {
    internal class Task {
        public enum TaskStatus {
            NotStarted,
            InProgress,
            Completed
        }

        private string _title;
        private string _description;
        private string _dueDate;
        private TaskStatus _status;
        public string Title { get { return _title; } }
        public string Description { get { return _description; } }
        public string DueDate { get { return _dueDate; } }
        public TaskStatus Status { 
            get { return _status; }
            set { _status = value; } 
        }



        public Task(string title, string description, string dueDate, TaskStatus status) {
            _title = title;
            _description = description;
            _dueDate = dueDate;
            _status = status;
        }

        public void DisplayTaskDetails() {
            Dictionary<string, string> taskDetails = new Dictionary<string, string> {
                { "Title", _title },
                { "Description", _description },
                { "Due Date", _dueDate },
                { "Status", _status.ToString() }
            };

            foreach (var detail in taskDetails) {
                Console.WriteLine($"{detail.Key}: {detail.Value}");
            }
        }
    }
}
