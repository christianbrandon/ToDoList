using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Repository;
using ToDoList;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ToDoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ToDoService.svc or ToDoService.svc.cs at the Solution Explorer and start debugging.
    public class ToDoService : IToDoService
    {
        private static string connection = @"Data Source = ALEXEJ-L450; Initial Catalog = DB_ToDoList; User ID = RestFullUser; Password = RestFull123";

        private static DAL repo = new DAL(connection);

        public List<ToDo> GetToDo()
        {
            List<ToDo> toDo = repo.GetToDoList();
            return toDo;
        }

        public List<ToDo> GetToDoListByName(string name)
        {
            List<ToDo> toDoList = repo.GetToDoListByName(name);
            return toDoList;
        }
    }
}
