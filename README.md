# School
The first project in C# to learn the basic principles of OOP

The task was:

*"Develop a project that will be a console organizer of the learning process for a group of students for a teacher"*

# The main entities of the project from the point of view of the customer:

1) Student: contains basic information about the student (name, phone number, email).

2) Occupation:
the entity contains the date, a list of topics, a comment from the instructor, and one of the three types of class (lecture, consultation, other).

3) Task (the entity has 3 options for implementation): 

- regular task (contains the title, wording, links to additional materials, deadlines),
- testing (contains the name, a link to testing in a third-party resource, deadlines),
- project (contains a title, a short description, a set of subtasks, links to additional materials, deadlines.

4) Group: the group is the main entity of the project and stores the list of students, the list of classes and the list of tasks.

# Project functionality:

Minimal (done): 
- describe the optimal class structure that can store all the necessary information.

Basic (done):
- add the ability for the user to get (through the console) all available information about the group on request,
- add the ability for the user to add (via the console) independently (via the console) to create / delete in a group of students, classes, tasks and subtasks in the project.

Interesting (done):
- add the ability for the user to mark which assignments were accepted by which student,
- add the ability for the user to get a list of statuses (accepted, not accepted) of a specific task from all students in the group,
- add the ability for the user to get a list of the statuses of a particular student for all tasks of the group.
