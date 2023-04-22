using System.Text.RegularExpressions;

namespace School
{
    public class TestTask : AbstractTask
    {
        private string _reference;

        public TestTask(string title,
                        string reference,
                        string deadline)
        {
            Title = title;
            Reference = reference;
            Deadline = deadline;
        }

        public TestTask(string title,
                        string reference,
                        string deadline,
                        Student[] studentsWhoAcceptedTask)
        {
            Title = title;
            Reference = reference;
            Deadline = deadline;
            StudentsWhoAcceptedTask = studentsWhoAcceptedTask;
        }

        public string Reference
        {
            get
            {
                return _reference;
            }
            set
            {
                string referencesPattern = "([\\w-]{1,32}\\.[\\w-]{1,32})[^\\s@]*$";

                Match isMatch = Regex.Match(value, referencesPattern);

                if (isMatch.Success)
                {
                    _reference = value;
                }
                else
                {
                    _reference = "The link to test does not match the format";
                }
            }
        }

        public override void GetInfo()
        { 
            Console.WriteLine("\n" + Title);
            Console.WriteLine("Link to the test: " + Reference);
            Console.WriteLine("DeadLine: " + Deadline);
            WriteListOfStudentWhoAcceptedTask();
        }

        public override void ChangeAttributes()
        {
            Console.WriteLine("Enter the name of the test task");
            Title = Console.ReadLine();

            Console.WriteLine("Enter the link to the test in the usual format (test-ref.com)");
            Reference = Console.ReadLine();

            Console.WriteLine("Enter the due date in the format dd.MM.yyyy");
            Deadline = Console.ReadLine();
        }

        public override void WriteListOfStudentWhoAcceptedTask()
        {
            Console.Write($"List of students who took the test {Title}:\n");

            if (StudentsWhoAcceptedTask.Length > 0)
            {
                for (int i = 0; i < StudentsWhoAcceptedTask.Length; i++)
                {
                    Console.WriteLine($"  {i + 1}) " + StudentsWhoAcceptedTask[i].Name);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("---No students who accepted the assignment---\n");
            }
        }
    }
}