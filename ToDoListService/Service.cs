﻿using System;
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

        public static List<ToDo> GetToDoListById(string name, string id)
        {
            // TODO: Add error checks. Datetime datatype is wierd when returned to to json
            var idParsed = int.Parse(id);
            var toDoByName = repository.GetToDoListByName(name);
            var toDoList = toDoByName.Where(todoList => todoList.Id == idParsed).ToList();

            return toDoList;
        }

        public static List<ToDo> GetToDoListByName(string name)
        {
            // TODO: Add error checks. Datetime datatype is wierd when returned to to json
            var toDoList = repository.GetToDoListByName(name);
            return toDoList;
        }
    }
}
