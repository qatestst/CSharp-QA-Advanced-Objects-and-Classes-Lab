namespace _02._Students
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Home { get; set; }
   
    }


    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (input != "end")
            {
                string[] studentData = input.Split(" ");
                string firstName = studentData[0];
                string lastName = studentData[1];
                int age = int.Parse(studentData[2]);
                string home = studentData[3];

                Student currentStudent = new Student();
                {
                    currentStudent.FirstName = firstName;
                    currentStudent.LastName = lastName;
                    currentStudent.Age = age;
                    currentStudent.Home = home;
                    students.Add(currentStudent);
                }
                      
                input = Console.ReadLine();
            }

            string cityName = Console.ReadLine();

            List<Student> filteredStudents = new List<Student>();
            foreach (Student student in students) 
            {
                filteredStudents = students.Where(x => x.Home.Contains(cityName)).ToList();
            }
            foreach (Student filteredStudent in filteredStudents)
            {
                Console.WriteLine($"{filteredStudent.FirstName} {filteredStudent.LastName} is {filteredStudent.Age} years old.");

            }

        }
    }
}