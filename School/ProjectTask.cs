namespace School
{
    public class ProjectTask : AbstractTask
    {
        public ProjectTask(string title,
                           string description,
                           string subtasks,
                           string[] reference,
                           string deadline)
        {
            Title = title;
            Description = description;
            Subtasks = subtasks;
            References = reference;
            Deadline = deadline;
        }
        public ProjectTask(string title,
                           string description,
                           string subtasks,
                           string[] reference,
                           string deadline,
                           Student[] studentsWhoAcceptedTask)
        {
            Title = title;
            Description = description;
            Subtasks = subtasks;
            References = reference;
            Deadline = deadline;
            StudentsWhoAcceptedTask = studentsWhoAcceptedTask;
        }

        public override void GetInfo()
        {
            Console.WriteLine("\n" + Title);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("Subtasks: " + Subtasks);
            WriteReferencesArray();
            Console.WriteLine("Deadline: " + Deadline);
            WriteListOfStudentWhoAcceptedTask();
        }

        public override void ChangeAttributes()
        {
            Console.WriteLine("Enter the title");
            Title = Console.ReadLine();

            Console.WriteLine("Enter description");
            Description = Console.ReadLine();

            Console.WriteLine("Enter subtasks");
            Subtasks = Console.ReadLine();

            Console.WriteLine("Enter links to materials separated by a space in the usual format (ref1.com ref2.com)");
            string referencesOfProjectTaskString = Console.ReadLine();
            References = referencesOfProjectTaskString.Split(" "); ;

            Console.WriteLine("Enter the due date in the format dd.MM.yyyy");
            Deadline = Console.ReadLine();
        }

        public void ChangeSubtasks()
        {
            Console.WriteLine("\nEnter new sutasks:");
            Subtasks = Console.ReadLine();
        }

        public override void WriteListOfStudentWhoAcceptedTask()
        {
            Console.Write($"List of students who took the project {Title}:\n");

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