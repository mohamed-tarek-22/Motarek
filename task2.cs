using System;

namespace ConsoleApp1
{
    public  class Person
        {
        public string Name;
        public int Age;

        public Person(string n,int a)
        {
            Name = n;
            Age = a;
        }
        public virtual void print()
        {
            Console.WriteLine("MY NAME " + Name + ", MY ADE " + Age);
        }

        }
    public class Student: Person
    {
        public int Year;
        public float Gpa;
        public Student(string n, int a,int year,float gpa) :base(n,a)
        {
            Year = year;
            Gpa = gpa;

        }
        public override void print()
        {
            Console.WriteLine("MY NAME " + Name+", MY AGE " +Age+" MY GPA "+Gpa);
    }
    }
    public class Datebase
    {
        private int _currentInndex;
        public Person[] people = new Person[50];
        public void AddStudent(Student student)
        {
            people[_currentInndex++] = student;
        }
        public void Addstaff(Staff staff)
        {
            people[_currentInndex++] = staff;
        }
        public void Addperson(Person person)
        {
            people[_currentInndex++] = person;
        }
        public void PrintAll()
        {
            foreach( var item in people)
            {
                item?.print();
            }
        }
    }
    public class Staff :Person
    {
        public double Salary;
        public int joinYear;
        public Staff(string name,int age,double salary,int joinyear): base(name,age)
        {
            Salary = salary;
            joinYear = joinyear;
        }
        public override void print()
        {
            Console.WriteLine("MY NAME "+Name+", MY AGE "+Age+"SALARY "+Salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var database = new Datebase();
           
            while (true) {
                Console.WriteLine("SELECT : 1-Student   2-Staff   3-Person   4-PrintAll");
                var t = Convert.ToInt32(Console.ReadLine());
                switch (t) {
                    case 1:
                        Console.Write("NAME: ");
                        var name = Console.ReadLine();
                        Console.Write("AGE: ");
                        var age = Convert.ToInt32(Console.ReadLine());
                        Console.Write("YEAR: ");
                        var year = Convert.ToInt32(Console.ReadLine());
                        Console.Write("GPA: ");
                        var gpa = Convert.ToInt32(Console.ReadLine());
                        var student = new Student(name, age, year, gpa);
                        database.AddStudent(student);
                        break;
                    case 2:
                        Console.Write("NAME: ");
                        var Name = Console.ReadLine();
                        Console.Write("AGE: ");
                        var Age = Convert.ToInt32(Console.ReadLine());
                        Console.Write("SALARY: ");
                        var salary = Convert.ToInt32(Console.ReadLine());
                        Console.Write("JoinYear: ");
                        var joinyear = Convert.ToInt32(Console.ReadLine());
                        var staff = new Staff(Name, Age, salary, joinyear);
                        database.Addstaff(staff);
                        break;
                        case 3:
                        Console.Write("NAME: ");
                        var Nam = Console.ReadLine();
                        Console.Write("AGE: ");
                        var Agee = Convert.ToInt32(Console.ReadLine());
                        var person = new Person(Nam,Agee);
                        database.Addperson(person);
                        break;
                    case 4:
                        database.PrintAll();
                        break;
                    default:
                        return;
}
    }
        }
    }
}
