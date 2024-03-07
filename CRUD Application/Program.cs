namespace CRUD_Application
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Student and Instructor information system!");
            // Console.WriteLine("Please select your role:");
            bool ch = false;
            while (!ch)
            {
                Console.WriteLine("Please select your role:");
                Console.WriteLine("1. Student");
                Console.WriteLine("2. Instructor");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                string roleChoice = Console.ReadLine() ?? string.Empty;
                Console.WriteLine("=================");

                /*switch (roleChoice)
                {
                    case "1":
                        CRUD("Student");
                        break;
                    case "2":
                        CRUD("Instructor");
                        break;
                    case "3":
                        ch = true;
                        break;

                    default:
                        Console.WriteLine("\nInvalid choice. Please try again.\n");
                        break;
                }*/
                HandleRoleChoice(roleChoice);
            }


            // this week you took delegates, so this usage for it, 
            // we use delegate to store the action we want to execute
            // and execute it when we receive the role choice from the user
            // based on the values in the dictionary
            void HandleRoleChoice(string roleChoice)
            {
                Dictionary<string, Action> roleActions = new Dictionary<string, Action>()
                {
                     { "1", () => ApplyCRUD("Student") },
                     { "2", () => ApplyCRUD("Instructor") }
                };

                Action action = roleActions[roleChoice];
                if (action != null)
                    action.Invoke();
                else
                    Console.WriteLine("Invalid choice. Please try again.\n");
            }


            /* void CRUD(string person)
             {
                 bool x = false;
                 while (!x)
                 {
                     Console.WriteLine("1. Add");
                     Console.WriteLine("2. View");
                     Console.WriteLine("3. Update");
                     Console.WriteLine("4. Delete");
                     Console.WriteLine("5. Exit\n");


                     Console.Write("Select an Option: ");
                     string option = Console.ReadLine();
                     Console.WriteLine("-----------------------");
                     CRUD crud;
                     if (person == "Student")
                     {
                         crud = new CreateStudent();
                     }
                     else
                     {
                         crud = new CreateInstructor();
                     }

                     switch (option)
                     {
                         case "1":
                         case "add":
                             crud.Add();
                             break;

                         case "2":
                         case "view":
                             crud.View();
                             break;

                         case "3":
                         case "update":
                             crud.Update();
                             break;

                         case "4":
                         case "delete":
                             crud.Delete();
                             break;

                         case "5":
                         case "exit":
                             x = true;
                             break;

                         default:
                             Console.WriteLine("Invalid option. Please try again.\n");
                             break;

                     }
                    }
                 }
             */

            string GetOperation()
            {
                bool x = false;
                string option = string.Empty; 

                while (!x)
                {
                    Console.WriteLine("1. Add");
                    Console.WriteLine("2. View");
                    Console.WriteLine("3. Update");
                    Console.WriteLine("4. Delete");
                    Console.WriteLine("5. Exit\n");

                    Console.Write("Select an Option: ");
                    option = Console.ReadLine().ToLower(); // Convert user input to lowercase for case-insensitive matching
                    
                    Console.WriteLine("-----------------------");
                    x = true;
                }
                return option;
            }

            void ApplyCRUD(string person)
            {
                if (person == "Student")
                {
                    var crud = new CreateStudent();
                    string option = GetOperation();
                    Dictionary<string, Action> options = new Dictionary<string, Action>()
                    {
                      { "1", () => crud.Add() },
                      { "2", () => crud.View() },
                      { "3", () => crud.Update() },
                      { "4", () => crud.Delete() }
                    };

                    options[option].Invoke();
                }
                else
                {
                    var crud = new CreateInstructor();
                    string option = GetOperation();
                    Dictionary<string, Action> options = new Dictionary<string, Action>()
                    {
                      { "1", () => crud.Add() },
                      { "2", () => crud.View() },
                      { "3", () => crud.Update() },
                      { "4", () => crud.Delete() }
                    };
                   options[option].Invoke();
                }
            }
        }
    }
}

