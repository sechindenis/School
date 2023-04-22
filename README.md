# School
The first project in C# to learn the basic principles of OOP

The task was:

*Develop a project that will be a console organizer of the learning process for a group of students for a teacher.

# The main entities of the project from the point of view of the customer:

1) Student: Contains basic information about the student (name, phone number, mail).

2) Occupation:
The entity contains the date, a list of topics, a comment from the instructor, and one of the three types of class (lecture, consultation, other).

3) Back: The entity has 3 options for implementation: - Regular task (Contains the title, wording, links to additional materials, deadlines).
         - Testing (Contains the name, a link to testing in a third-party resource, deadlines).
         - Project (Contains a title, a short description, a set of subtasks, links to additional materials, deadlines.

4) Group: The group is the main entity of the project and stores the list of students, the list of classes and the list of tasks.

# Project functionality:

Minimal: - Describe the optimal class structure that can store all the necessary information.

Basic: - Add the ability for the user to get (through the console) all available information about the group on request.
       - It is possible for the user to add (via the console) independently (via the console) to create / delete in a group of students, classes, tasks and subtasks in the project.

Interesting: - Add the ability for the user to mark which assignments were accepted by which student.
             - Add to the user the ability to get a list of statuses (accepted, not accepted) of a specific task from all students in the group.
             - Add to the user the ability to get a list of the statuses of a particular student for all tasks of the group.
