using System.Text.RegularExpressions;

namespace School
{
    public abstract class AbstractTask 
    {
        private string[] _references;

        private Student[] _studentsWhoAcceptedTask = new Student[0];

        public string Title { get; set; }

        public string Description { get; set; }

        public string Subtasks { get; set; }

        public string[] References 
        {
            get
            {
                return _references;
            }
            set
            {
                _references = new string[value.Length];
                string referencesPattern = "([\\w-]{1,32}\\.[\\w-]{1,32})[^\\s@]*$";

                for (int i = 0; i < value.Length; i++)
                {
                    Match isMatch = Regex.Match(value[i], referencesPattern);

                    if (isMatch.Success)
                    {
                        _references[i] = value[i];
                    }
                    else
                    {
                        _references[i] = $"The link #{i + 1} does not match the format";
                    }
                }
            }
        }

        public string Deadline { get; set; }

        public Student[] StudentsWhoAcceptedTask
        {
            get
            {
                return _studentsWhoAcceptedTask;
            }
            set
            {
                if (value != null)
                {
                    _studentsWhoAcceptedTask = new Student[value.Length];

                    for (int i = 0; i < value.Length; i++)
                    {
                        _studentsWhoAcceptedTask[i] = value[i];
                    }
                }
                else
                {
                    _studentsWhoAcceptedTask = Array.Empty<Student>();
                }
            }
        }

        public abstract void WriteListOfStudentWhoAcceptedTask();

        public abstract void ChangeAttributes();

        public abstract void GetInfo();

        public void WriteReferencesArray()
        {
            for (int i = 0; i < References.Length; i++)
            {
                Console.WriteLine($"  {i + 1}) " + References[i]);
            }
        }
    }
}