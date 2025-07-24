// // Create a collection of students to store student id ,student name and  subjectmarks(key as a subject and value as a marks)
// // then display each student detail with average score

class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public Dictionary<string, int> SubjectMarks { get; set; }

    public double GetAverage()
    {
        int total = 0;
        foreach (var mark in SubjectMarks.Values)
        {
            total += mark;
        }
        return (double)total / SubjectMarks.Count;
    }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>()
        {
            new Student
            {
                ID = 1,
                Name = "Alice",
                SubjectMarks = new Dictionary<string, int>
                {
                    { "Math", 90 },
                    { "Science", 85 },
                    { "English", 88 }
                }
            },
            new Student
            {
                ID = 2,
                Name = "Bob",
                SubjectMarks = new Dictionary<string, int>
                {
                    { "Math", 75 },
                    { "Science", 80 },
                    { "English", 70 }
                }
            }
        };
        foreach (Student student in students)
        {
            Console.WriteLine($"ID: {student.ID}, Name: {student.Name}");
            Console.WriteLine("Subject Marks:");
            foreach (var subject in student.SubjectMarks)
            {
                Console.WriteLine($" - {subject.Key}: {subject.Value}");
            }
            Console.WriteLine($"Average Marks: {student.GetAverage():F2}");
            Console.WriteLine("------------------------");
        }
    }
}