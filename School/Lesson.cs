namespace School
{
    public class Lesson
    {
        private string _type;

        public Lesson(string title,
                      string date,
                      string[] themes,
                      string comment,
                      string type)
        {
            Title = title;
            Date = date;
            Themes = themes;
            Comment = comment;
            Type = type;
        }

        public string Title { get; set; }

        public string Date { get; set; }

        public string[] Themes { get; set; } = new string[0];

        public string Comment { get; set; }

        public string Type 
        {
            get
            {
                return _type;
            }
            set
            {
                if (value == "lecture" || value == "consultation")
                {
                    _type = value;
                }
                else
                {
                    _type = "other";
                }
            } 
        }

        public void GetInfo()
        {
            Console.WriteLine("\n" + Title);
            Console.WriteLine("Date: " + Date);
            Console.WriteLine("Topics: ");

            for (int i = 0; i < Themes.Length; i++)
            {
                Console.WriteLine($"  {i + 1}) " + Themes[i]);
            }

            Console.WriteLine("Comment: " + Comment);
            Console.WriteLine("Type: " + Type + "\n");
        }

        public void ChangeAttributes()
        {
            Console.WriteLine("Enter the name of the lesson");
            Title = Console.ReadLine();

            Console.WriteLine("Enter the date of the lesson in the format dd.MM.yyyy");
            Date = Console.ReadLine();

            Console.WriteLine("Enter the topics of the lesson separated by commas and spaces (topic 1, topic 2, etc.)");
            string themesOfLessonString = Console.ReadLine();
            Themes = themesOfLessonString.Split(", ");

            Console.WriteLine("Enter a comment");
            Comment = Console.ReadLine();

            Console.WriteLine("Enter the class type (lecture, consultation, other)");
            Type = Console.ReadLine();
        }
    }
}