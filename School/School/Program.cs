using School;

// Examples

// tasks objects
string[] references = new string[] { "ref1.com", "ref2.com" };

AbstractTask task1 = new CommonTask("Common task", "common task description", references, "12.12.2025");
AbstractTask task2 = new TestTask("Test task", "test-ref.com", "12.12.2025");
AbstractTask task3 = new ProjectTask("Project", "project description", "subtasks", references, "12.12.2025");
AbstractTask[] tasks1 = new AbstractTask[] { task1, task2, task3 };
AbstractTask[] tasks2 = new AbstractTask[] { task1, task3 };
AbstractTask[] tasks3 = new AbstractTask[] { task1, task2 };

// students objects
Student st1 = new Student("Tom Jones", "example@example.com", "+000000000000", tasks1);
Student st2 = new Student("John Doe", "example@example.com", "+000000000000", tasks2);
Student st3 = new Student("Ronald Smith", "example@example.com", "+000000000000", tasks3);
Student st4 = new Student("Garry Thompson", "example@example.com", "+000000000000", tasks2);
Student[] students = new Student[] { st1, st2, st3, st4 };

// adding students who accepted an assignment
Student[] studentsTask1 = new Student[] { st1, st2, st3, st4 };
task1.StudentsWhoAcceptedTask = studentsTask1;

Student[] studentsTask2 = new Student[] { st1, st3};
task2.StudentsWhoAcceptedTask = studentsTask2;

Student[] studentsTask3 = new Student[] { st1, st2, st4 };
task3.StudentsWhoAcceptedTask = studentsTask3;

// lessons objects
string[] th1 = new string[] { "тема 1", "тема 2" };

Lesson les1 = new Lesson("Lesson 1", "12.12.2020", th1, "comment", "lecture");
Lesson les2 = new Lesson("Lesson 2", "12.12.2020", th1, "comment", "lecture");
Lesson les3 = new Lesson("Lesson 3", "12.12.2020", th1, "comment", "lecture");
Lesson les4 = new Lesson("Lesson 4", "12.12.2020", th1, "comment", "lecture");
Lesson[] lessons = new Lesson[] { les1, les2, les3, les4 };

// groups objects
Group group1 = new Group("Group 1", students, lessons, tasks1);
Group group2 = new Group("Group 2", students, lessons, tasks2);
Group group3 = new Group("Group 3", students, lessons, tasks3);
Group[] groupsArray = new Group[] { group1, group2, group3 };

group1.ActWithGroup();