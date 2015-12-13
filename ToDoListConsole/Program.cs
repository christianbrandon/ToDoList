using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListConsole.ServiceReference;

namespace ToDoListConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new WcfServiceClient("BasicHttpBinding_IWcfService");
            Console.WriteLine("The service is online");
            Console.WriteLine("ToDoList:");
            var todoList = client.GetToDoList();

            foreach (var list in todoList)
            {
                
                Console.WriteLine(list.Id);
                Console.WriteLine(list.Name);
                Console.WriteLine(list.CreatedDate);
                Console.WriteLine(list.DeadLine);
                Console.WriteLine(list.Description);
                Console.WriteLine(list.EstimationTime);
                Console.WriteLine(list.Finnished);
            }

            Console.ReadKey();
        }
    }
}
