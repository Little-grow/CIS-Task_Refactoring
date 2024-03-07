using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Application
{
    internal class CreateStudent: CRUD
    {
        static List<Student> students = new List<Student>();

        public override void Add()
        {
            Console.WriteLine("~~~~Add Student~~~~");
            Console.WriteLine("-----------------------");

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            int age = ReadInt("Enter Age: ");

            Console.Write("Enter Address: ");
            string address = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            int StudentId = ReadInt("Enter StudentID: ");

            Console.Write("Enter Faculty: ");
            string faculty = Console.ReadLine();

            Console.Write("Enter Your Technology: ");
            string tech = Console.ReadLine();

            Student student = new(StudentId, name, faculty, age, tech,address,email);

            students.Add(student);
            Console.Clear();

            Console.WriteLine("=============================");
            Console.WriteLine("[ Student added successfully.]");
            Console.WriteLine("=============================\n");

        }
        public override void View()
        {
            Console.WriteLine("~~~~View Students~~~~");
            Console.WriteLine("-----------------------");


            if (students.Count == 0)
            {
                Console.WriteLine("No students available.\n");
                return;
            }

            var SortedList = students.OrderBy(x => x.StudentId).ToList();
            Console.Clear();
            foreach (var student in SortedList)
            {
                Console.WriteLine($"Name: {student.Name.ToUpper()}");
                Console.WriteLine($"Age: {student.Age}");
                Console.WriteLine($"Address: {student.Address}");
                Console.WriteLine($"Email: {student.Email}");
                Console.WriteLine($"StudentID: {student.StudentId}");
                Console.WriteLine($"Faculty: {student.Faculty.ToUpper()}");
                Console.WriteLine($"Technology: {student.Technology.ToUpper()}");
                Console.WriteLine("-------------------");
            }
        }
        public override void Update()
        {
            Console.WriteLine("~~~~Update Student~~~~");
            Console.WriteLine("-----------------------");

            Console.WriteLine("Enter Student Name:");
            string Name = Console.ReadLine();

            Console.WriteLine();
            var found = students.Find(x => x.Name.ToLower() == Name.ToLower());
            if (found == null)
            {
                Console.WriteLine("Student not found.\n");
                return;
            }
            bool x = false;
            while (!x)
            {
                Console.WriteLine("1. Update Name");
                Console.WriteLine("2. Update ID");
                Console.WriteLine("3. Update Faculty");
                Console.WriteLine("4. Update Age");
                Console.WriteLine("5. Update Technology");
                Console.WriteLine("6. Update Email");
                Console.WriteLine("7. Update Address");
                Console.WriteLine("8. Exit\n");

                Console.Write("Select an Option: ");
                string option = Console.ReadLine();
                Console.WriteLine("-----------------------");


                switch (option)
                {
                    case "1":
                        Console.Write("Enter New Name: ");
                        string name = Console.ReadLine();
                        found.Name = name;
                        break;

                    case "2":
                        Console.Write("Enter New ID: ");
                        int id = int.Parse(Console.ReadLine());
                        found.StudentId = id;
                        break;

                    case "3":
                        Console.Write("Enter New Faculty: ");
                        string faculty = Console.ReadLine();
                        found.Faculty = faculty;
                        break;

                    case "4":
                        Console.Write("Enter New Age: ");
                        int age = int.Parse(Console.ReadLine());
                        found.Age = age;
                        break;

                    case "5":
                        Console.Write("Enter New Technology: ");
                        string tech = Console.ReadLine();
                        found.Technology = tech;
                        break;

                    case "6":
                        Console.Write("Enter New Email: ");
                        string Email = Console.ReadLine();
                        found.Email = Email;
                        break;

                    case "7":
                        Console.Write("Enter New Address: ");
                        string Address = Console.ReadLine();
                        found.Address = Address;
                        break;
                    case "8":
                        x = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.\n");
                        break;


                }

            }
            Console.Clear();
            Console.WriteLine("=============================");
            Console.WriteLine("[ Student updated successfully.]");
            Console.WriteLine("=============================\n");
        }
        public override void Delete()
        {
            Console.WriteLine("~~~~Delete Student~~~~");
            Console.WriteLine("-------------------");
            Console.WriteLine("Enter Student Name:");
            string Name = Console.ReadLine();

            var found = students.Find(x => x.Name == Name);
            if (found == null)
            {
                Console.WriteLine("Student Not Found\n");
                return;
            }

            students.Remove(found);
            Console.Clear();
            Console.WriteLine("=============================");
            Console.WriteLine("[ Student deleted successfully.]");
            Console.WriteLine("=============================\n");
        }

        
    }
}

