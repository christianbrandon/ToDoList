using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList;
using ToDoListRepository;

namespace ToDoListService
{
    public class Service
    {
        // Make sure to change Data Source = Alexej-L450 to your local DB name!
        private static string connection = @"Data Source = Alexej-L450; Initial Catalog = DB_ToDoList; User ID = RestFullUser; Password = RestFull123";

        // This is the DAL object, use it in your methods, don't create a new one.
        private static DAL repository = new DAL(connection);

        public static List<ToDo> GetToDoList()
        {
            // TODO: Add error checks. Datetime datatype is wierd when returned to to json
            var toDoList = repository.GetToDoList();
            return toDoList;
        }

        public static List<ToDo> GetToDoListById(string id)
        {
            // TODO: Add error checks. Datetime datatype is wierd when returned to to json
            int idParsed = int.Parse(id);
            var toDoList = repository.GetToDoListById(idParsed);
            return toDoList;
        }

        public static List<ToDo> GetToDoListByName(string name)
        {
            // TODO: Add error checks. Datetime datatype is wierd when returned to to json
            var toDoList = repository.GetToDoListByName(name);
            return toDoList;
        }

        public static bool AddToDoList(ToDo toDoList)
        {
            // TODO add error checks, based on result return bool value. Convert json time to .net datetime datatype.
            repository.AddToDo(toDoList);
            return true;
        }

        public static bool RemoveToDoList(string id)
        {
            // TODO add error checks, based on result return bool value. When trying to invoke spits out Method not allowed.
            int idParsed = int.Parse(id);
            repository.DeleteToDoList(idParsed);
            return true;
        }
    }
}
