using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CRUD_Application
{
    public abstract class CRUD // this is an abstract class can be changed with Interface, revise the difference between both 
    {     
        public abstract void Add();
        public abstract void View();
        public abstract void Update();
        public abstract void Delete();
       

        protected int ReadInt(string message)
        {
            while (true)
            {
                Console.Write(message);
                if(int.TryParse(Console.ReadLine(), out int value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Invalid input,Please Try Again.");
                }
            }
            

        }
    }
}
