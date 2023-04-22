namespace School
{
    public class Group
    {
        private Student[] _students;

        private Lesson[] _lessons;

        private AbstractTask[] _tasks;

        public Group(string groupName,
                     Student[] students,
                     Lesson[] lessons,
                     AbstractTask[] tasks)
        {
            GroupName = groupName;
            Students = students;
            Lessons = lessons;
            Tasks = tasks;
        }

        public string GroupName { get; set; }

        public Student[] Students
        {
            get
            {
                return _students;
            }
            set
            {
                if (value !=  null)
                {
                    _students = new Student[value.Length];

                    for (int i = 0; i < value.Length; i++)
                    {
                        _students[i] = value[i];
                    }
                }
                else
                {
                    _students = Array.Empty<Student>();
                }
            }
        }

        public Lesson[] Lessons
        {
            get
            {
                return _lessons;
            }
            set
            {
                if (value != null)
                {
                    _lessons = new Lesson[value.Length];

                    for (int i = 0; i < value.Length; i++)
                    {
                        _lessons[i] = value[i];
                    }
                }
                else
                {
                    _lessons = Array.Empty<Lesson>();
                }
            }
        }

        public AbstractTask[] Tasks
        {
            get
            {
                return _tasks;
            }
            set
            {
                if (value != null)
                {
                    _tasks = new AbstractTask[value.Length];

                    for (int i = 0; i < value.Length; i++)
                    {
                        _tasks[i] = value[i];
                    }
                }
                else
                {
                    _tasks = Array.Empty<AbstractTask>(); 
                }
            }
        }

        // final method for all task
        public void ActWithGroup()
        {
            Console.WriteLine("Not welcome...");
            string choices = "\n1 – sudents (it`s not worth it)\r\n" +
                               "2 – занятия (are you sure?)\r\n" +
                               "3 – tasks (the last chance to choose the right variant)\r\n" +
                               "0 - exit (yes, this is the right variant)";
            Console.WriteLine(choices);
            int enteredNumber;

            do
            {
                Console.WriteLine("\nEnter the corresponding number\n");
                Console.WriteLine("You entered:");
                enteredNumber = ConvertStringToIntIfPossibleOrReturnNegativeOne(Console.ReadLine());
                Console.WriteLine();

                if (enteredNumber == 1)
                {
                    ActWithStudent();
                    Console.WriteLine(choices);
                }
                else if (enteredNumber == 2)
                {
                    ActWithLesson();
                    Console.WriteLine(choices);
                }
                else if (enteredNumber == 3)
                {
                    ActWithTask();
                    Console.WriteLine(choices);
                }
                else if (enteredNumber != 0)
                {
                    Console.WriteLine("---The number is not correct---");
                }
            }
            while (enteredNumber != 0);
        }

        // final method for students
        public void ActWithStudent()
        {
            WriteListOfStudents();
            int enteredNumber;
            string choices = "\n1 – information about student\r\n" +
                               "2 – add accepting the task by student\r\n" +
                               "3 – get student status on the tasks of the group\r\n" +
                               "4 - delete student\r\n" +
                               "5 – add student\r\n" +
                               "0 – go back";
            Console.WriteLine(choices);

            do
            {
                Console.WriteLine("\nTo select the function enter its number, to go back enter 0\n");
                Console.WriteLine("You entered:");
                enteredNumber = ConvertStringToIntIfPossibleOrReturnNegativeOne(Console.ReadLine());
                Console.WriteLine();

                if (enteredNumber == 1)
                {
                    WriteListOfStudents();
                    ShowStudent();
                    Console.WriteLine(choices);
                }
                else if (enteredNumber == 2)
                {
                    ChooseStudentAndAddTasks();
                    WriteListOfStudents();
                    Console.WriteLine(choices);
                }
                else if (enteredNumber == 3)
                {
                    GetStudentStatusesOfTasks();
                    WriteListOfStudents();
                    Console.WriteLine(choices);
                }
                else if (enteredNumber == 4)
                {
                    DeleteStudent();
                    WriteListOfStudents();
                    Console.WriteLine(choices);
                }
                else if (enteredNumber == 5)
                {
                    AddNewStudent();
                    WriteListOfStudents();
                    Console.WriteLine(choices);
                }
                else if (enteredNumber != 0)
                {
                    Console.WriteLine("---The number is not correct---");
                }
            }
            while (enteredNumber != 0);
        }

        // final method for lessons
        public void ActWithLesson()
        {
            WriteListOfLessons();
            int enteredNumber;
            string choices = "\n1 – information about lesson\r\n" +
                               "2 - delete lesson\r\n" +
                               "3 – add lesson\r\n" +
                               "0 – go back";
            Console.WriteLine(choices);

            do
            {
                Console.WriteLine("\nTo select the function enter its number, to go back enter 0\n");
                Console.WriteLine("Ypu entered:");
                enteredNumber = ConvertStringToIntIfPossibleOrReturnNegativeOne(Console.ReadLine());
                Console.WriteLine();

                if (enteredNumber == 1)
                {
                    WriteListOfLessons();
                    ShowLesson();
                    Console.WriteLine(choices);
                }
                else if (enteredNumber == 2)
                {
                    DeleteLesson();
                    WriteListOfLessons();
                    Console.WriteLine(choices);
                }
                else if (enteredNumber == 3)
                {
                    AddNewLesson();
                    WriteListOfLessons();
                    Console.WriteLine(choices);
                }
                else if (enteredNumber != 0)
                {
                    Console.WriteLine("---The number is not correct---");
                }
            }
            while (enteredNumber != 0);
        }

        // final method for tasks
        public void ActWithTask()
        {
            WriteListOfTasks();
            int enteredNumber;
            string choices = "\n1 – information about task\r\n" +
                               "2 – add accepting the lesson by students\r\n" +
                               "3 – get task status by group students\r\n" +
                               "3 - delete task\r\n" +
                               "4 – add task\r\n" +
                               "0 – go back";
            Console.WriteLine(choices);

            do
            {
                Console.WriteLine("\nTo select the function enter its number, to go back enter 0\n");
                Console.WriteLine("You entered:");
                enteredNumber = ConvertStringToIntIfPossibleOrReturnNegativeOne(Console.ReadLine());
                Console.WriteLine();

                if (enteredNumber == 1)
                {
                    WriteListOfTasks();
                    ShowTask();
                    WriteListOfTasks();
                    Console.WriteLine(choices);
                }
                else if (enteredNumber == 2)
                {
                    ChooseTasksAndAddStudents();
                    WriteListOfTasks();
                    Console.WriteLine(choices);
                }
                else if (enteredNumber == 3)
                {
                    GetTasksStatusesOfStudents();
                    WriteListOfTasks();
                    Console.WriteLine(choices);
                }
                else if (enteredNumber == 4)
                {
                    DeleteTask();
                    WriteListOfTasks();
                    Console.WriteLine(choices);
                }
                else if (enteredNumber == 5)
                {
                    AddNewTask();
                    WriteListOfTasks();
                    Console.WriteLine(choices);
                }
                else if (enteredNumber != 0)
                {
                    Console.WriteLine("---The number is not correct---");
                }
            }
            while (enteredNumber != 0);
        }

        // privates
        private int ConvertStringToIntIfPossibleOrReturnNegativeOne(string str)
        {
            if (int.TryParse(str, out int number))
            {
                return number;
            }

            return -1;
        }

        private bool IsNumberInListOfStudents(int number)
        {
            number -= 1;
            
            for (int i = 0; i < Students.Length; i++)
            {
                if (i == number)
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsNumberInListOfLessons(int number)
        {
            number -= 1;

            for (int i = 0; i < Lessons.Length; i++)
            {
                if (i == number)
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsNumberInListOfTasks(int number)
        {
            number -= 1;

            for (int i = 0; i < Tasks.Length; i++)
            {
                if (i == number)
                {
                    return true;
                }
            }

            return false;
        }

        private void WriteListOfStudents()
        {
            Console.WriteLine("Group students list:");

            if (Students.Length > 0)
            {
                for (int i = 0; i < Students.Length; i++)
                {
                    Console.WriteLine($"  {i + 1}) " + Students[i].Name);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("---Group students list is empty---\n");
            } 
        }

        private void WriteListOfLessons()
        {
            Console.WriteLine("Group lessons list:");

            if (Lessons.Length > 0)
            {
                for (int i = 0; i < Lessons.Length; i++)
                {
                    Console.WriteLine($"  {i + 1}) " + Lessons[i].Title);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("---Group lessons list is empty---\n");
            }
        }

        private void WriteListOfTasks()
        {
            Console.WriteLine("Group tasks list is empty:");

            if (Tasks.Length > 0)
            {
                for (int i = 0; i < Tasks.Length; i++)
                {
                    Console.WriteLine($"  {i + 1}) " + Tasks[i].Title);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("---Group tasks list is empty---\n");
            }
        }

        private void GetStudentWithNumber(int number)
        {
            if (IsNumberInListOfStudents(number))
            {
                number -= 1;
                Students[number].GetInfo();
            }
            else
            {
                Console.WriteLine("\n---This number is not on the list---\n");
            }
        }

        private void GetLessonWithNumber(int number)
        {
            if (IsNumberInListOfLessons(number))
            {
                number -= 1;
                Lessons[number].GetInfo();
            }
            else
            {
                Console.WriteLine("---This number is not on the list---");
            }
        }

        private void GetTaskWithNumber(int number)
        {
            if (IsNumberInListOfTasks(number))
            {
                number -= 1;
                if (Tasks[number] is CommonTask)
                {
                    ((CommonTask)Tasks[number]).GetInfo();
                }
                else if (Tasks[number] is TestTask)
                {
                    ((TestTask)Tasks[number]).GetInfo();
                }
                else if (Tasks[number] is ProjectTask)
                {
                    ((ProjectTask)Tasks[number]).GetInfo();
                    int enteredNumber;

                    do
                    {
                        Console.WriteLine("Change subtasks?");
                        Console.WriteLine("1 - yes, change\n0 - no, go back");
                        Console.WriteLine("\nYou entered: ");
                        enteredNumber = ConvertStringToIntIfPossibleOrReturnNegativeOne(Console.ReadLine());

                        if (enteredNumber != 0)
                        {
                            ((ProjectTask)Tasks[number]).ChangeSubtasks();
                            Console.WriteLine($"\nNew subtasks: {((ProjectTask)Tasks[number]).Subtasks}\n");
                        }
                    }
                    while (enteredNumber != 0);
                }
            }
            else
            {
                Console.WriteLine("---This number is not on the list---");
            }
        }

        private void ShowStudent()
        {
            int enteredNumber;

            do
            {
                Console.WriteLine("To get information about a student, enter his number, to return, enter 0\n");
                Console.WriteLine("You entered: ");
                enteredNumber = ConvertStringToIntIfPossibleOrReturnNegativeOne(Console.ReadLine());

                if (enteredNumber != 0)
                {
                    GetStudentWithNumber(enteredNumber);
                }
            }
            while (enteredNumber != 0);
        }

        private void ShowLesson()
        {
            int enteredNumber;

            do
            {
                Console.WriteLine("To get information about a lesson, enter its number, to return, enter 0\n");
                Console.WriteLine("You entered: ");
                enteredNumber = ConvertStringToIntIfPossibleOrReturnNegativeOne(Console.ReadLine());

                if (enteredNumber != 0)
                {
                    GetLessonWithNumber(enteredNumber);
                }
            }
            while (enteredNumber != 0);
        }

        private void ShowTask()
        {
            int enteredNumber;

            do
            {
                Console.WriteLine("To get information about a task, enter its number, to return, enter 0\n");
                Console.WriteLine("You entered: ");
                enteredNumber = ConvertStringToIntIfPossibleOrReturnNegativeOne(Console.ReadLine());

                if (enteredNumber != 0)
                {
                    GetTaskWithNumber(enteredNumber);
                }
            }
            while (enteredNumber != 0);
        }

        private Student[] AddStudentToArrayAndReturnArray(Student student)
        {
            Student[] tmp = Students;
            Array.Resize(ref tmp, Students.Length + 1);
            tmp[^1] = student;
            Students = tmp;

            return Students;
        }

        private Lesson[] AddLessonToArrayAndReturnArray(Lesson lesson)
        {
            Lesson[] tmp = Lessons;
            Array.Resize(ref tmp, Lessons.Length + 1);
            tmp[^1] = lesson;
            Lessons = tmp;

            return Lessons;
        }

        private AbstractTask[] AddTaskToArrayAndReturnArray(AbstractTask task)
        {
            AbstractTask[] tmp = Tasks;
            Array.Resize(ref tmp, Tasks.Length + 1);
            tmp[^1] = task;
            Tasks = tmp;

            return Tasks;
        }

        private void AddNewStudent()
        {
            Student newStudent = new Student("-", "-", "-");
            newStudent.ChangeAttributes();
            Students = AddStudentToArrayAndReturnArray(newStudent);
            Console.WriteLine("\n---The student is added---\n");
        }

        private void AddNewLesson()
        {
            string[] themes = new string[0];
            Lesson newLesson = new Lesson("-", "-", themes, "-", "-");
            newLesson.ChangeAttributes();
            Lessons = AddLessonToArrayAndReturnArray(newLesson);
            Console.WriteLine("\n---The lesson is added---\n");
        }

        private void AddNewCommonTask()
        {
            string[] references = new string[0];
            AbstractTask newCommonTask = new CommonTask("-", "-", references, "-");
            newCommonTask.ChangeAttributes();
            Tasks = AddTaskToArrayAndReturnArray(newCommonTask);
            Console.WriteLine("\n---The common task is added---\n");
            WriteListOfTasks();
            WriteTasksChoices();
        }

        private void AddNewTestTask()
        {
            AbstractTask newTestTask = new TestTask("-", "-", "-");
            newTestTask.ChangeAttributes();
            Tasks = AddTaskToArrayAndReturnArray(newTestTask);
            Console.WriteLine("\n---The test is added---\n");
            WriteListOfTasks();
            WriteTasksChoices();
        }

        private void AddNewProjectTask()
        {
            string[] references = new string[0];
            AbstractTask newProjectTask = new ProjectTask("-", "-", "-", references, "-");
            newProjectTask.ChangeAttributes();
            Tasks = AddTaskToArrayAndReturnArray(newProjectTask);
            Console.WriteLine("\n---The project is added---\n");
            WriteListOfTasks();
            WriteTasksChoices();
        }

        private void WriteTasksChoices()
        {
            Console.Write("\nSelect the type of task to add:" + "\n");
            Console.WriteLine("1 - common task \n2 - test \n3 - project \n0 - go back\n");
        }

        private void AddNewTask()
        {
            Console.WriteLine($"Add task");
            WriteTasksChoices();
            int enteredNumber;

            do
            {
                Console.WriteLine("You entered:");
                enteredNumber = ConvertStringToIntIfPossibleOrReturnNegativeOne(Console.ReadLine());
                Console.WriteLine();

                if (enteredNumber == 1)
                {
                    AddNewCommonTask();
                }
                else if (enteredNumber == 2)
                {
                    AddNewTestTask();
                }
                else if (enteredNumber == 3)
                {
                    AddNewProjectTask();
                }
                else if (enteredNumber != 0)
                {
                    Console.WriteLine("---Wrong key---\n");
                }
            }
            while (enteredNumber != 0);
        }

        // deleting student data
        private Student[] DeleteStudentWithNumberFromArrayAndReturnArray(int number)
        {
            number -= 1;
            
            if (number != Students.Length - 1)
            {
                for (int i = number; i < Students.Length - 1; i++)
                {
                    Students[i] = Students[i + 1];
                }
            }
            
            Student[] tmp = Students;
            Array.Resize(ref tmp, Students.Length - 1);
            Students = tmp;

            return Students;
        }

        private void DeleteStudent()
        {
            int enteredNumber;

            do
            {
                WriteListOfStudents();
                Console.WriteLine($"To delete, enter the student number, to return, enter 0\n");
                Console.WriteLine("You entered: ");
                enteredNumber = ConvertStringToIntIfPossibleOrReturnNegativeOne(Console.ReadLine());

                if (IsNumberInListOfStudents(enteredNumber))
                {
                    Students = DeleteStudentWithNumberFromArrayAndReturnArray(enteredNumber);
                    Console.WriteLine("\n---The student deleted---\n");
                }
                else if (enteredNumber != 0 && IsNumberInListOfStudents(enteredNumber) == false)
                {
                    Console.WriteLine("\n---This number is not on the list---");
                }
            }
            while (enteredNumber != 0);
        }

        // deleting kesson data
        private Lesson[] DeleteLessonWithNumberFromArrayAndReturnArray(int number)
        {
            number -= 1;

            if (number != Lessons.Length - 1)
            {
                for (int i = number; i < Lessons.Length - 1; i++)
                {
                    Lessons[i] = Lessons[i + 1];
                }
            }

            Lesson[] tmp = Lessons;
            Array.Resize(ref tmp, Lessons.Length - 1);
            Lessons = tmp;

            return Lessons;
        }

        private void DeleteLesson()
        {
            int enteredNumber;

            do
            {
                WriteListOfLessons();
                Console.WriteLine($"To delete, enter the class number, to return, enter 0\n");
                Console.WriteLine("You entered: ");
                enteredNumber = ConvertStringToIntIfPossibleOrReturnNegativeOne(Console.ReadLine());

                if (IsNumberInListOfLessons(enteredNumber))
                {
                    Lessons = DeleteLessonWithNumberFromArrayAndReturnArray(enteredNumber);
                    Console.WriteLine("\n---The lesson deleted---\n");
                }
                else if (enteredNumber != 0 && IsNumberInListOfLessons(enteredNumber) == false)
                {
                    Console.WriteLine("\n---This number is not on the list---");
                }
            }
            while (enteredNumber != 0);
        }

        // deleting task data
        private AbstractTask[] DeleteTaskWithNumberFromArrayAndReturnArray(int number)
        {
            number -= 1;

            if (number != Tasks.Length - 1)
            {
                for (int i = number; i < Tasks.Length - 1; i++)
                {
                    Tasks[i] = Tasks[i + 1];
                }
            }

            AbstractTask[] tmp = Tasks;
            Array.Resize(ref tmp, Tasks.Length - 1);
            Tasks = tmp;

            return Tasks;
        }

        private void DeleteTask()
        {
            int enteredNumber;

            do
            {
                WriteListOfTasks();
                Console.WriteLine($"To delete, enter the job number, to return, enter 0\n");
                Console.WriteLine("You entered: ");
                enteredNumber = ConvertStringToIntIfPossibleOrReturnNegativeOne(Console.ReadLine());

                if (IsNumberInListOfTasks(enteredNumber))
                {
                    Tasks = DeleteTaskWithNumberFromArrayAndReturnArray(enteredNumber);
                    Console.WriteLine("\n---The task deleted---\n");
                }
                else if (enteredNumber != 0 && IsNumberInListOfTasks(enteredNumber) == false)
                {
                    Console.WriteLine("\n---This number is not on the list---\n");
                }
            }
            while (enteredNumber != 0);
        }

        // adding marks to the student about the acceptance of assignments
        private bool IsTasksInAcceptedTasks(Student student, AbstractTask abstractTask)
        {
            for (int i = 0; i < student.AcceptedTasks.Length; i++)
            {
                if (abstractTask == student.AcceptedTasks[i])
                {
                    return true;
                }
            }

            return false;
        }

        private void AddTasksToAcceptedTasksArray(Student student, AbstractTask abstractTask)
        {
            AbstractTask[] tmp = student.AcceptedTasks;
            Array.Resize(ref tmp, student.AcceptedTasks.Length + 1);
            tmp[^1] = abstractTask;
            student.AcceptedTasks = tmp;
        }

        private void AddTasksToStudent(Student student)
        {
            int enteredNumber;
            student.WriteListOfAcceptedTasks();

            do
            {
                WriteListOfTasks();
                Console.WriteLine("Enter task number to add, enter 0 to return\n");
                Console.WriteLine("You entered:");
                enteredNumber = ConvertStringToIntIfPossibleOrReturnNegativeOne(Console.ReadLine());
                Console.WriteLine();

                if (IsNumberInListOfTasks(enteredNumber))
                {
                    if (IsTasksInAcceptedTasks(student, Tasks[enteredNumber - 1]) == false)
                    {
                        AddTasksToAcceptedTasksArray(student, Tasks[enteredNumber - 1]);
                        AddStudentToListOfStudentWhoAcceptedTaskArray(Tasks[enteredNumber - 1], student);
                        Console.WriteLine("\n---The task is added---\n");
                        student.WriteListOfAcceptedTasks();
                    }
                    else
                    {
                        Console.WriteLine("\n---This assignment has already been accepted by the student---\n");
                        student.WriteListOfAcceptedTasks();
                    }
                }
                else if (enteredNumber != 0 && IsNumberInListOfTasks(enteredNumber) == false)
                {
                    Console.WriteLine("---This number is not on the list---\n");
                }
            }
            while (enteredNumber != 0);
        }

        private void ChooseStudentAndAddTasks()
        {
            int enteredNumber;

            do
            {
                WriteListOfStudents();
                Console.WriteLine("Enter the number of the student you want to add tasks to, enter 0 to return\n");
                Console.WriteLine("You entered:");
                enteredNumber = ConvertStringToIntIfPossibleOrReturnNegativeOne(Console.ReadLine());
                Console.WriteLine();

                if (IsNumberInListOfStudents(enteredNumber))
                {
                    AddTasksToStudent(Students[enteredNumber - 1]);
                }
                else if (enteredNumber != 0 && IsNumberInListOfStudents(enteredNumber) == false)
                {
                    Console.WriteLine("---This number is not on the list---\n");
                }
            }
            while (enteredNumber != 0);
        }

        // adding an assignment to students who accepted it
        private bool IsStudentInListOfStudentWhoAcceptedTask(AbstractTask abstractTask, Student student)
        {
            for (int i = 0; i < abstractTask.StudentsWhoAcceptedTask.Length; i++)
            {
                if (student == abstractTask.StudentsWhoAcceptedTask[i])
                {
                    return true;
                }
            }

            return false;
        }

        private void AddStudentToListOfStudentWhoAcceptedTaskArray(AbstractTask abstractTask, Student student)
        {
            Student[] tmp = abstractTask.StudentsWhoAcceptedTask;
            Array.Resize(ref tmp, abstractTask.StudentsWhoAcceptedTask.Length + 1);
            tmp[^1] = student;
            abstractTask.StudentsWhoAcceptedTask = tmp;
        }

        private void AddStudentToAcceptedTaskArray(AbstractTask abstractTask)
        {
            int enteredNumber;
            abstractTask.WriteListOfStudentWhoAcceptedTask();

            do
            {
                WriteListOfStudents();
                Console.WriteLine("Enter student number to add, enter 0 to return\n");
                Console.WriteLine("You entered:");
                enteredNumber = ConvertStringToIntIfPossibleOrReturnNegativeOne(Console.ReadLine());
                Console.WriteLine();

                if (IsNumberInListOfStudents(enteredNumber))
                {
                    if (IsStudentInListOfStudentWhoAcceptedTask(abstractTask, Students[enteredNumber - 1]) == false)
                    {
                        AddStudentToListOfStudentWhoAcceptedTaskArray(abstractTask, Students[enteredNumber - 1]);
                        AddTasksToAcceptedTasksArray(Students[enteredNumber - 1], abstractTask);
                        Console.WriteLine("\n---The student is added---\n");
                        abstractTask.WriteListOfStudentWhoAcceptedTask();
                    }
                    else
                    {
                        Console.WriteLine("\n---The student has already accepted this assignment.---\n");
                        abstractTask.WriteListOfStudentWhoAcceptedTask();
                    }
                }
                else if (enteredNumber != 0 && IsNumberInListOfStudents(enteredNumber) == false)
                {
                    Console.WriteLine("---This number is not on the list---\n"); 
                }
            }
            while (enteredNumber != 0);
        }

        private void ChooseTasksAndAddStudents()
        {
            int enteredNumber;

            do
            {
                WriteListOfTasks();
                Console.WriteLine("Enter the number of the assignment to be added to the student, enter 0 to return\n");
                Console.WriteLine("You entered:");
                enteredNumber = ConvertStringToIntIfPossibleOrReturnNegativeOne(Console.ReadLine());
                Console.WriteLine();

                if (IsNumberInListOfTasks(enteredNumber))
                {
                    AddStudentToAcceptedTaskArray(Tasks[enteredNumber - 1]);
                }
                else if (enteredNumber != 0 && IsNumberInListOfTasks(enteredNumber) == false)
                {
                    Console.WriteLine("---This number is not on the list---\n");
                }   
            }
            while (enteredNumber != 0);
        }

        // list of statuses (accepted, not accepted) of the student according to the assignments of the group
        private void WriteStudentStatusesOfTasks(Student student)
        {
            Console.WriteLine($"Student status {student.Name} by the group tasks:");
            
            for (int i = 0; i < Tasks.Length; i++)
            {
                if (IsTasksInAcceptedTasks(student, Tasks[i]))
                {
                    Console.WriteLine($"  {i + 1}) {Tasks[i].Title} - accepted");
                }
                else
                {
                    Console.WriteLine($"  {i + 1}) {Tasks[i].Title} - not accepted");
                }
            }

            Console.WriteLine();
        }

        private void GetStudentStatusesOfTasks()
        {
            int enteredNumber;

            do
            {
                WriteListOfStudents();
                Console.WriteLine("Enter the number of the student you want to know the status of assignments, to return, enter 0\n");
                Console.WriteLine("You entered:");
                enteredNumber = ConvertStringToIntIfPossibleOrReturnNegativeOne(Console.ReadLine());
                Console.WriteLine();

                if (IsNumberInListOfStudents(enteredNumber))
                {
                    WriteStudentStatusesOfTasks(Students[enteredNumber - 1]);
                }
                else if (enteredNumber != 0 && IsNumberInListOfStudents(enteredNumber) == false)
                {   
                    Console.WriteLine("---This number is not on the list---\n");
                }
            }
            while (enteredNumber != 0);
        }

        // list of student statuses by group assignments
        private void WriteTasksStatusesOfStudent(AbstractTask abstractTask)
        {
            Console.WriteLine($"Task statuses {abstractTask.Title} bu the students of the group:");

            for (int i = 0; i < Students.Length; i++)
            {
                if (IsStudentInListOfStudentWhoAcceptedTask(abstractTask, Students[i]))
                {
                    Console.WriteLine($"  {i + 1}) {Students[i].Name} - accepted");
                }
                else
                {
                    Console.WriteLine($"  {i + 1}) {Students[i].Name} - not accepted");
                }
            }

            Console.WriteLine();
        }

        private void GetTasksStatusesOfStudents()
        {
            int enteredNumber;

            do
            {
                WriteListOfTasks();
                Console.WriteLine("Enter the number of the task for which you want to know the status of students, to return, enter 0\n");
                Console.WriteLine("You entered:");
                enteredNumber = ConvertStringToIntIfPossibleOrReturnNegativeOne(Console.ReadLine());
                Console.WriteLine();

                if (IsNumberInListOfTasks(enteredNumber))
                {
                    WriteTasksStatusesOfStudent(Tasks[enteredNumber - 1]);
                }
                else if (enteredNumber != 0 && IsNumberInListOfTasks(enteredNumber) == false)
                {
                    Console.WriteLine("---This number is not on the list---\n");
                }
            }
            while (enteredNumber != 0);
        }
    }
}