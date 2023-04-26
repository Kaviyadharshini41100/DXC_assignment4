namespace Exam_Results
{
    class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public int Math { get; set; }
        public int Science { get; set; }
        public int English { get; set; }
        public int Language { get; set; }
        public int SST { get; set; }

        public int sum { get; set; }
        public void calTotal()
        {
            sum = Math + Science + English + Language + SST;
        }

    }

    class Score
    {
        int n = 0;
        Student[] students;
        public void AcceptDetails()
        {
            Console.WriteLine("Enter the number of students");
            n = Convert.ToInt16(Console.ReadLine());
            students = new Student[n];
            for (int i = 0; i < n; i++)
            {
                Student student = new Student();
                Console.WriteLine($"Enter Details for Student {i + 1}");
                Console.WriteLine("Enter Roll No");
                student.RollNo = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter Student Name");
                student.Name = Console.ReadLine();
                Console.WriteLine("Enter Marks for Maths");
                student.Math = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter Marks for Science");
                student.Science = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter Marks for English");
                student.English = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter Marks for Language");
                student.Language = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter Marks for SST");
                student.SST = Convert.ToInt16(Console.ReadLine());


                student.calTotal();

                students[i] = student;
            }
        }

        public void part1()
        {
            Console.WriteLine("Total Marks Acheived by each student:");
            foreach (Student student in students)
            {
                Console.WriteLine($"Total Marks of {student.Name} is: {student.sum}");
            }
            Console.WriteLine();
            int topScore = 0;
            Student topScorer = null;
            foreach (Student student in students)
            {
                if (student.sum > topScore)
                {
                    topScore = student.sum;
                    topScorer = student;
                }
            }
            Console.WriteLine($"Top Scorer: {topScorer.Name} (Roll Number: {topScorer.RollNo}), Total Marks: {topScorer.sum}");
            Console.WriteLine();
            int totalMathMarks = 0;
            int totalScienceMarks = 0;
            int totalEnglishMarks = 0;
            int totalLanguageMarks = 0;
            int totalSocialMarks = 0;

            foreach (Student student in students)
            {
                totalMathMarks += student.Math;
                totalScienceMarks += student.Science;
                totalEnglishMarks += student.English;
                totalLanguageMarks += student.Language;
                totalSocialMarks += student.SST;
            }

            double averageMathMarks = (double)totalMathMarks / n;
            double averageScienceMarks = (double)totalScienceMarks / n;
            double averageEnglishMarks = (double)totalEnglishMarks / n;
            double averageLanguageMarks = (double)totalLanguageMarks / n;
            double averageSocialMarks = (double)totalSocialMarks / n;

            Console.WriteLine($"Average Marks of Each Subject:  Maths: {averageMathMarks}  Science: {averageScienceMarks}  English: {averageEnglishMarks}  Language: {averageLanguageMarks} Social: {averageSocialMarks}");
            Console.WriteLine();
            int pass = 0;
            int fail = 0;
            Console.WriteLine("Result of Each Student(pass/fail):");
            foreach (Student student in students)
            {
                if (student.Math >= 35 && student.Science >= 35 && student.English >= 35
                    && student.Language >= 35 && student.SST >= 35)
                {
                    pass++;
                    Console.WriteLine($"{student.Name} (Roll Number: {student.RollNo}) has cleared the exam");
                }
                else
                {
                    fail++;
                    Console.WriteLine($"{student.Name} (Roll Number: {student.RollNo}) has not cleared the exam");
                }
            }
        }

        public void part2()
        {
            int pass = 0;
            int fail = 0;
            foreach (Student student in students)
            {
                if (student.Math >= 35 && student.Science >= 35 && student.English >= 35
                    && student.Language >= 35 && student.SST >= 35)
                {
                    pass++;
                }
                else
                {
                    fail++;
                }
            }

            Console.WriteLine($"Number of students who need to repeat the examination: {fail}");
            Console.WriteLine($"Number of students who passed the examination: {pass}");
            
        }

        public void part3()
        {
            foreach (Student student in students)
            {
                double studentAverage = student.sum / 5;
                string Grade;
                if (studentAverage >= 95)
                {
                    Grade = "A";
                }
                else if (studentAverage >= 80)
                {
                    Grade = "B";
                }
                else if (studentAverage >= 70)
                {
                    Grade = "C";
                }
                else if (studentAverage >= 60)
                {
                    Grade = "D";
                }
                else if (studentAverage >= 50)
                {
                    Grade = "E";
                }
                else
                {
                    Grade = "F";
                }
                Console.WriteLine($"Grade of {student.Name} (Roll Number: {student.RollNo}): {Grade}");
            }
        }
        public void part4(int roll)
        {
            foreach (Student student in students)
            {
                if (roll == student.RollNo)
                {
                    Console.WriteLine($"Name of the student: {student.Name}");
                    Console.WriteLine($"Roll Number: {student.RollNo}");
                    Console.WriteLine($"Math Marks: {student.Math}");
                    Console.WriteLine($"Science Marks: {student.Science}");
                    Console.WriteLine($"English Marks: {student.English}");
                    Console.WriteLine($"Language Marks: {student.Language}");
                    Console.WriteLine($"Social Marks: {student.SST}");
                    Console.WriteLine($"Total Marks Obtained: {student.sum}");
                    string Grade = "A";
                    double studentAverage = 0;
                    studentAverage = student.sum / 5;
                    if (studentAverage >= 95)
                    {
                        Grade = "A";
                    }
                    else if (studentAverage >= 80)
                    {
                        Grade = "B";
                    }
                    else if (studentAverage >= 70)
                    {
                        Grade = "C";
                    }
                    else if (studentAverage >= 60)
                    {
                        Grade = "D";
                    }
                    else if (studentAverage >= 50)
                    {
                        Grade = "E";
                    }
                    else
                    {
                        Grade = "F";
                    }

                    Console.WriteLine($"Grade Achived {Grade}");
                }
                else
                 {
                        Console.WriteLine($"Student with Roll Number {roll} not found.");
                 }
               

            }
         }
        internal class Program
        {
            static void Main(string[] args)
            {
                Score card = new Score();
                card.AcceptDetails();
                Console.WriteLine();
                card.part1();
                Console.WriteLine();
                card.part2();
                Console.WriteLine();
                card.part3();
                Console.WriteLine();
                Console.WriteLine("Enter a Roll Number:");
                int roll = int.Parse(Console.ReadLine());
                card.part4(roll);
            }
        }
    }
}