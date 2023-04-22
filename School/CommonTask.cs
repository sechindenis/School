namespace School
{
    public class CommonTask : AbstractTask
    {
        public CommonTask(string title,
                          string description,
                          string[] reference,
                          string deadline)
        {
            Title = title;
            Description = description;
            References = reference;
            Deadline = deadline;
        }

        public CommonTask(string title,
                          string description,
                          string[] reference,
                          string deadline,
                          Student[] studentsWhoAcceptedTask)
        {
            Title = title;
            Description = description;
            References = reference;
            Deadline = deadline;
            StudentsWhoAcceptedTask = studentsWhoAcceptedTask;
        }

        public override void GetInfo()
        {
            Console.WriteLine("\n" + Title);
            Console.WriteLine("Description: " + Description);
            WriteReferencesArray();
            Console.WriteLine("Deadline: " + Deadline);
            WriteListOfStudentWhoAcceptedTask();
        }

        public override void ChangeAttributes()
        {
            Console.WriteLine("Enter the name of the regular task");
            Title = Console.ReadLine();

            Console.WriteLine("Enter the description");
            Description = Console.ReadLine();

            Console.WriteLine("Enter links to materials separated by a space in the usual format (ref1.com ref2.com)");
            string referencesOfCommonTaskString = Console.ReadLine();
            References = referencesOfCommonTaskString.Split(" ");

            Console.WriteLine("Enter the due date of the task in the format dd.MM.yyyy");
            Deadline = Console.ReadLine();
        }

        public override void WriteListOfStudentWhoAcceptedTask()
        {
            Console.Write($"List of students who accepted the regular assignment {Title}:\n");

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