using System.Text.RegularExpressions;

namespace School
{
    public class Student
    {
        private string _email;

        private string _phoneNumber;

        private AbstractTask[] _acceptedTasks = new AbstractTask[0];

        public Student(string fullName, 
                       string email,
                       string phoneNumber)
        {
            Name = fullName;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public Student(string fullName,
                       string email,
                       string phoneNumber,
                       AbstractTask[] acceptedTasks)
        {
            Name = fullName;
            Email = email;
            PhoneNumber = phoneNumber;
            AcceptedTasks = acceptedTasks;
        }

        public string Name { get; set; }

        public string Email 
        { 
            get
            {
                return _email;
            } 
            set
            {
                string emailPattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
                Match isMatch = Regex.Match(value, emailPattern, RegexOptions.IgnoreCase);

                if (isMatch.Success)
                {
                    _email = value;
                }
                else
                {
                    _email = "Email does not match the format";
                }
            }
        }

        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (value.StartsWith("+") && (value.Length == 12 || value.Length == 13 || value.Length == 14))
                {
                    _phoneNumber = value;
                }
                else
                {
                    _phoneNumber = "Phone number does not match the format";
                }
            }
        }

        public AbstractTask[] AcceptedTasks 
        {
            get
            {
                return _acceptedTasks;
            }
            set
            {
                if (value != null)
                {
                    _acceptedTasks = new AbstractTask[value.Length];

                    for (int i = 0; i < value.Length; i++)
                    {
                        _acceptedTasks[i] = value[i];
                    }
                }
                else
                {
                    _acceptedTasks = Array.Empty<AbstractTask>();
                }
            }
        }

        public void GetInfo()
        {
            Console.WriteLine("\n" + "Full name: " + Name);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Phone number: " + PhoneNumber);
            WriteListOfAcceptedTasks();
        }

        public void WriteListOfAcceptedTasks()
        {
            Console.Write($"List of assignments accepted by the student {Name}:\n");

            if (AcceptedTasks.Length > 0)
            {
                for (int i = 0; i < AcceptedTasks.Length; i++)
                {
                    Console.WriteLine($"  {i + 1}) " + AcceptedTasks[i].Title);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("---No accepted assignments---\n");
            }
        }

        public void ChangeAttributes()
        {
            Console.WriteLine("Enter the student's full name");
            Name = Console.ReadLine();

            Console.WriteLine("Enter the student's email in the format example@email.com");
            Email = Console.ReadLine();

            Console.WriteLine("Enter the student's phone number in the format +000000000000");
            PhoneNumber = Console.ReadLine();
        }
    }
}