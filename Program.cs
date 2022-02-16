using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Alik";
            student.Surname = "Gafarov";
            student.Group = "P127";
            student.Point = 100;
            student.Graduated = true;
            Console.WriteLine(student.getinfo() , student.gettf() , student.getsl());
            //Console.WriteLine(student.gettf());
            //Console.WriteLine(student.getsl());

        }
    }
    class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public double Point;
        public bool Graduated;

        //////public Student(/*string name, string surname, string group, double point,*/ bool graduated)
        //////{
        //////    //Name = name;
        //////    //Surname = surname;
        //////    //Group = group;
        //////    //Point = point;
        //////    Graduated = graduated;
        //////}
        public string getinfo()
        {
            return $"Name: {Name}\nSurname: {Surname}\nGroup: {Group}\nPoint: {Point}\nGraduated: {Graduated} ";
        }
        public double getsl()
        {
            {

            }
            if (Point >= 80)
            {
                Console.WriteLine("\nBu telebe 2-ci imtahan gire biler.\n");
            }
            else
            {
                Console.WriteLine("\nBu telebe 2-ci imtahana gire bilmez.\n");

            }
            return Point;
        }
        public bool gettf()
        {
            {

            }
            if (Graduated == true)
            {
                Console.WriteLine("\nBu telebe mezun olub\n");
            }
            else
            {
                Console.WriteLine("\nBu telebe mezun olmadi");

            }
            return Graduated;
        }

    }
}
    
    
        


