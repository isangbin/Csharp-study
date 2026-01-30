using System;

namespace struct_practice
{
    internal class Program
    {
        struct Point
        {
            public int x;
            public int y;
        }

        struct Student
        {
            public string name;
            public int age;
            public double score;
        }
        static void Main(string[] args)
        {   
            // 1.
            Point point1 = new Point();
            Point point2 = new Point();

            Console.Write("X1 입력: ");
            point1.x = int.Parse(Console.ReadLine());
            Console.Write("Y1 입력: ");
            point1.y = int.Parse(Console.ReadLine());
            Console.Write("X2 입력: ");
            point2.x = int.Parse(Console.ReadLine());
            Console.Write("Y2 입력: ");
            point2.y = int.Parse(Console.ReadLine());

            double dist = Distance(point1.x, point1.y, point2.x, point2.y);
            Console.WriteLine("두 점 사이 거리: "+ dist);

            // 2.
            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();

            Console.Write("학생 이름 입력: ");
            student1.name = Console.ReadLine();
            Console.Write("학생 나이 입력: ");
            student1.age = int.Parse(Console.ReadLine());
            Console.Write("학생 성적 입력: ");
            student1.score = double.Parse(Console.ReadLine());
            Console.Write("학생 이름 입력: ");
            student2.name = Console.ReadLine();
            Console.Write("학생 나이 입력: ");
            student2.age = int.Parse(Console.ReadLine());
            Console.Write("학생 성적 입력: ");
            student2.score = double.Parse(Console.ReadLine());
            Console.Write("학생 이름 입력: ");
            student3.name = Console.ReadLine();
            Console.Write("학생 나이 입력: ");
            student3.age = int.Parse(Console.ReadLine());
            Console.Write("학생 성적 입력: ");
            student3.score = double.Parse(Console.ReadLine());


            Console.WriteLine("이름: " + student1.name + " 나이: " + student1.age + " 성적: " + student1.score);
            Console.WriteLine("이름: " + student2.name + " 나이: " + student2.age + " 성적: " + student2.score);
            Console.WriteLine("이름: " + student3.name + " 나이: " + student3.age + " 성적: " + student3.score);


        }
        static double Distance(int x1, int y1, int x2, int y2)
        {
            double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return d;
        }
    }
}

