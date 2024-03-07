using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Application
{
    // change the access modifier to be public 
    public class CreateInstructor : CRUD
    { 
        static List<Instructor> instructors = new List<Instructor>();

        public override void Add()
        {
            Console.WriteLine("~~~~Add Instructor~~~~");
            Console.WriteLine("-----------------------");

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            int age = ReadInt("Enter Age: ");

            Console.Write("Enter Address: ");
            string address = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Specialization: ");
            string specialization = Console.ReadLine();

            Console.Write("Enter Salary: ");
            decimal salary = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Department: ");
            string department = Console.ReadLine();


            Instructor instructor = new(name, age, address, email, specialization, salary, department);

            instructors.Add(instructor);
            Console.Clear();

            Console.WriteLine("=============================");
            Console.WriteLine("[ instructors added successfully.]");
            Console.WriteLine("=============================\n");

        }
        public override void View()
        {
            Console.WriteLine("~~~~View Instructors~~~~");
            Console.WriteLine("-----------------------");


            if (instructors.Count == 0)
            {
                Console.WriteLine("No instructors available.\n");
                return;
            }

            var SortedList = instructors.OrderBy(x => x.Name).ToList();
            Console.Clear();
            foreach (var instructor in SortedList)
            {
                Console.WriteLine($"Name: {instructor.Name.ToUpper()}");
                Console.WriteLine($"Age: {instructor.Age}");
                Console.WriteLine($"Address: {instructor.Address}");
                Console.WriteLine($"Email: {instructor.Email}");
                Console.WriteLine($"Salary: {instructor.Salary}");
                Console.WriteLine($"Department: {instructor.Department}");

                Console.WriteLine("-------------------");
            }
        }
        public override void Update()
        {
            Console.WriteLine("~~~~Update Instructor~~~~");
            Console.WriteLine("-----------------------");

            Console.WriteLine("Enter Student Name:");
            string Name = Console.ReadLine();

            Console.WriteLine();
            var found = instructors.Find(x => x.Name.ToLower() == Name.ToLower());
            if (found == null)
            {
                Console.WriteLine("Instructor not found.\n");
                return;
            }
            bool x = false;
            while (!x)
            {
                Console.WriteLine("1. Update Name");
                Console.WriteLine("2. Update Age");
                Console.WriteLine("3. Update Address");
                Console.WriteLine("4. Update Email");
                Console.WriteLine("5. Update Salary");
                Console.WriteLine("6. Update Department");
                Console.WriteLine("7. Exit\n");

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
                        Console.Write("Enter New Age: ");
                        int Age = int.Parse(Console.ReadLine());
                        found.Age = Age;
                        break;

                    case "3":
                        Console.Write("Enter New Address: ");
                        string Address = Console.ReadLine();
                        found.Address = Address;
                        break;

                    case "4":
                        Console.Write("Enter New Email: ");
                        string Email = Console.ReadLine();
                        found.Email = Email;
                        break;

                    case "5":
                        Console.Write("Enter New Salary: ");
                        decimal Salary = decimal.Parse(Console.ReadLine());
                        found.Salary = Salary;
                        break;

                    case "6":
                        Console.Write("Enter New Department: ");
                        string Department = Console.ReadLine();
                        found.Department = Department;
                        break;
                    case "7":
                        x = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.\n");
                        break;


                }

            }
            Console.Clear();
            Console.WriteLine("=============================");
            Console.WriteLine("[ Instructor updated successfully.]");
            Console.WriteLine("=============================\n");


        }
        public override void Delete()
        {
            Console.WriteLine("~~~~Delete Instructor~~~~");
            Console.WriteLine("-------------------");
            Console.WriteLine("Enter instructor Name:");
            string Name = Console.ReadLine();

            var found = instructors.Find(x => x.Name.ToLower() == Name.ToLower());
            if (found == null)
            {
                Console.WriteLine("Instructor Not Found\n");
                return;
            }

            instructors.Remove(found);
            Console.Clear();
            Console.WriteLine("=============================");
            Console.WriteLine("[ Student deleted successfully.]");
            Console.WriteLine("=============================\n");

        }
    }
}

